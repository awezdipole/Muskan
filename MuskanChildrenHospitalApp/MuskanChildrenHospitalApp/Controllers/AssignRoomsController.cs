using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MuskanChildrenHospitalApp.Data;
using MuskanChildrenHospitalApp.Models;
using MuskanChildrenHospitalApp.Models.Interface;
using MuskanChildrenHospitalApp.Models.Work;

namespace MuskanChildrenHospitalApp.Controllers
{
    public class AssignRoomsController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IbedRepository beds;
        private readonly IAdmissionRepositoy admission;

        public AssignRoomsController(ApplicationDbContext context, IbedRepository beds,IAdmissionRepositoy admission)
        {
            _context = context;
            this.beds = beds;
            this.admission = admission;
        }

        // GET: AssignRooms
        public async Task<IActionResult> Index()
        {
            var query = await (from p in _context.Patients
                        join c in _context.Addmisions on p.id equals c.PatientId
                        join r in _context.Rooms on c.RoomId equals r.Id
                        join cu in _context.Beds on c.BedId equals cu.id

                        select new MuskanChildrenHospitalApp.Models.Addmision
                        {
                            id=c.id,
                            RegistrationNumber = c.RegNo,
                            RoomName = r.RoomName,
                            BedName = cu.BedName,
                            PatientName = p.Name,
                            DateOfAdmission = c.DateOfAddmission,
                            DateOfDischarge = c.DateOfDischarge,
                            IsDischarge = c.IsDischarge
                        }).ToListAsync();
            return View(query);
        }

        // GET: AssignRooms/Details/5
        //public async Task<IActionResult> Details(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var assignRoom = await _context.AssignRooms
        //        .FirstOrDefaultAsync(m => m.id == id);
        //    if (assignRoom == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(assignRoom);
        //}

        // GET: AssignRooms/Create
        public IActionResult Create(int id)
        {
            var query = (from p in _context.AssignRooms
                        join c in _context.Addmisions on p.AddmissionId equals c.id
                        join r in _context.Rooms on p.RoomId equals r.Id
                        join cu in _context.Beds on p.BedId equals cu.id
                        where p.AddmissionId== id
                        select new MuskanChildrenHospitalApp.Models.Addmision
                        {
                            id= c.id,
                            BedId=p.BedId,
                            RegistrationNumber = c.RegNo,
                            RoomName = r.RoomName,
                            BedName = cu.BedName,
                            DateOfAdmission = c.DateOfAddmission
                        }).FirstOrDefault();
            ViewBag.Date = query.DateOfAdmission;
            ViewData["Addmisions"] = query.RegistrationNumber;
            ViewData["RoomName"] = query.RoomName;
            ViewData["BedName"] = query.BedName;
            ViewData["Date"] = query.DateOfAdmission;
            ViewData["Rooms"] = new SelectList(_context.Rooms, "Id", "RoomName");
            ViewBag.id = id;
           // ViewData["beds"] = new SelectList(_context.Beds, "id", "RegNo");
            return View();
        }

        // POST: AssignRooms/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("RoomId,BedId,AddmissionId")] AssignRoom assignRoom)
        {
            if (ModelState.IsValid)
            {
                var query = (from p in _context.AssignRooms
                             join c in _context.Addmisions on p.AddmissionId equals c.id
                             join r in _context.Rooms on p.RoomId equals r.Id
                             join cu in _context.Beds on p.BedId equals cu.id
                             where p.AddmissionId == assignRoom.AddmissionId
                             select new MuskanChildrenHospitalApp.Models.Addmision
                             {
                                 id = c.id,
                                 PatientId=c.PatientId,
                                 BedId = p.BedId,
                                 RegistrationNumber = c.RegNo,
                                 RoomName = r.RoomName,
                                 BedName = cu.BedName,
                                 DateOfAdmission = c.DateOfAddmission
                             }).FirstOrDefault();
                // assignRoom.AddmissionId = Convert.ToInt32(ViewData["id"].ToString());
                Bed bed1 = new Bed();

                bed1 = beds.GetBed(query.BedId);
                bed1.IsAssign = false;
                beds.Update(bed1);

                bed1 = beds.GetBed(assignRoom.BedId);
                bed1.IsAssign = true;
                beds.Update(bed1);
                var x = _context.Rooms.Select(c => new
                {
                    roomName = c.RoomName,
                    roomId = c.Id
                }).Where(k => k.roomId == assignRoom.RoomId).FirstOrDefault();
                mkAddmision add = new mkAddmision();
                add.PatientId = query.PatientId;
                add.id = assignRoom.AddmissionId;
                add.BedId = assignRoom.BedId;
                add.RoomId = assignRoom.RoomId;
                add.RegNo = query.RegistrationNumber;
                add.DateOfAddmission = query.DateOfAdmission;
                admission.Update(add);
                assignRoom.RegNo = query.RegistrationNumber;
                assignRoom.RoomName = x.roomName;
                assignRoom.DateAdded = DateTime.Now.ToString();
                _context.Add(assignRoom);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(assignRoom);
        }


        public JsonResult getBedsByRoomId(int RoomId)
        {


            var result = _context.Beds.Where(m => m.RoomId == RoomId && m.IsAssign==false).Select(c => new
            {
                ID = c.id,
                Text = c.BedName
            });



            ViewData["beds"] = result;
            return Json(result);
        }


        // GET: AssignRooms/Edit/5
        //public async Task<IActionResult> Edit(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var assignRoom = await _context.AssignRooms.FindAsync(id);
        //    if (assignRoom == null)
        //    {
        //        return NotFound();
        //    }
        //    return View(assignRoom);
        //}

        //// POST: AssignRooms/Edit/5
        //// To protect from overposting attacks, enable the specific properties you want to bind to.
        //// For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Edit(int id, [Bind("id,RoomId,RoomName,BedId,AddmissionId,RegNo,DateAdded,DateUpdate,Status")] AssignRoom assignRoom)
        //{
        //    if (id != assignRoom.id)
        //    {
        //        return NotFound();
        //    }

        //    if (ModelState.IsValid)
        //    {
        //        try
        //        {
        //            _context.Update(assignRoom);
        //            await _context.SaveChangesAsync();
        //        }
        //        catch (DbUpdateConcurrencyException)
        //        {
        //            if (!AssignRoomExists(assignRoom.id))
        //            {
        //                return NotFound();
        //            }
        //            else
        //            {
        //                throw;
        //            }
        //        }
        //        return RedirectToAction(nameof(Index));
        //    }
        //    return View(assignRoom);
        //}

        //// GET: AssignRooms/Delete/5
        //public async Task<IActionResult> Delete(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var assignRoom = await _context.AssignRooms
        //        .FirstOrDefaultAsync(m => m.id == id);
        //    if (assignRoom == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(assignRoom);
        //}

        //// POST: AssignRooms/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> DeleteConfirmed(int id)
        //{
        //    var assignRoom = await _context.AssignRooms.FindAsync(id);
        //    _context.AssignRooms.Remove(assignRoom);
        //    await _context.SaveChangesAsync();
        //    return RedirectToAction(nameof(Index));
        //}

        //private bool AssignRoomExists(int id)
        //{
        //    return _context.AssignRooms.Any(e => e.id == id);
        //}
    }
}
