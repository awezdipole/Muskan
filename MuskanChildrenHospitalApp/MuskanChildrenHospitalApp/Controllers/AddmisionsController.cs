using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MuskanChildrenHospitalApp.Data;
using MuskanChildrenHospitalApp.Models;
using MuskanChildrenHospitalApp.Models.Interface;
using MuskanChildrenHospitalApp.Models.Work;

namespace MuskanChildrenHospitalApp.Controllers
{
    public class AddmisionsController : Controller
    {
        private readonly ApplicationDbContext db;
        private readonly IbedRepository beds;
        private readonly IAdmissionRepositoy _context;
        private readonly IPatientRepository patientRepository;
        private readonly IAssignRoomRepository assignRoomRepository;
        private readonly IbedRepository Bedcontext;
        private readonly IRoomRepository RoomCotext;

        mkAddmision Mkadd = new mkAddmision();
        Patient Patient = new Patient();
        AssignRoom aroom = new AssignRoom();


       

        public AddmisionsController(ApplicationDbContext db,IbedRepository beds,IAdmissionRepositoy context,IPatientRepository patientRepository,IAssignRoomRepository assignRoomRepository, IbedRepository ibedContext, IRoomRepository room)
        {
            this.db = db;
            this.beds = beds;
            _context = context;
            this.patientRepository = patientRepository;
            this.assignRoomRepository = assignRoomRepository;
            Bedcontext = ibedContext;
            RoomCotext = room;
        }

        // GET: Addmisions
        public IActionResult Index()
        {
            var query = from p in db.Patients
                        join c in db.Addmisions on p.id equals c.PatientId
                        join r in db.Rooms on c.RoomId equals r.Id
                        join cu in db.Beds on c.BedId equals cu.id

                        select new MuskanChildrenHospitalApp.Models.Addmision
                        {
                            RegistrationNumber = c.RegNo,
                            RoomName = r.RoomName,
                            BedName = cu.BedName,
                            PatientName = p.Name,
                            DateOfAdmission=c.DateOfAddmission,
                            DateOfDischarge=c.DateOfDischarge,
                            IsDischarge=c.IsDischarge
                        };
            return View(query) ;
        }

        // GET: Addmisions/Details/5
        public IActionResult Details(int id)
        {


            var addmision = _context.GetAddmision(id);
            if (addmision == null)
            {
                return NotFound();
            }

            return View(addmision);
        }

        // GET: Addmisions/Create
        public IActionResult Create()
        {
            ViewBag.RegNo = getRegNumber();
            ViewData["RoomId"] = new SelectList(RoomCotext.GetRooms(), "Id", "RoomName");

            return View();
        }
        public JsonResult getBedsByRoomId(int RoomId)
        {


            var result = db.Beds.Where(m => m.RoomId == RoomId && m.IsAssign == false).Select(c => new
            {
                ID = c.id,
                Text = c.BedName
            });



            ViewData["beds"] = result;
            return Json(result);
        }
        public JsonResult SetBedId(int RoomId)
        {

            var result = "Thank You" +RoomId;
            ViewData["bedId"] = RoomId;
            return Json(result);
        }
        public string getRegNumber()
        {
            var getlastenquiry = db.Addmisions.OrderByDescending(y => y.RegNo).FirstOrDefault();

            string EnNumber = null;
            if (getlastenquiry != null && getlastenquiry.RegNo != null)
            {
                string enquiryNumber = getlastenquiry.RegNo;
                int number = 0;
                number = Convert.ToInt32(enquiryNumber.Substring(5));

                EnNumber = string.Format("RN{0}{1}{2:0000}", DateTime.Now.ToString("yy"), DateTime.Now.ToString("MM") , ++number);
            }
            else
            {
                EnNumber = string.Format("RN{0}{1}{2:0000}", DateTime.Now.ToString("yy"), DateTime.Now.ToString("MM"), 1);
                // EnNumber = string.Format("{0}{1:0000}", DateTime.Now.Year, 1);
            }
            return EnNumber;
        }
        // POST: Addmisions/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("id,PatientName,Age,Sex,Address,RoomId,BedId,ContactNo,DateOfAdmission,Weight,Refrence,TimeOfAddmision")] Addmision addmision)
        {
            if (ModelState.IsValid)
            {
                // string bedid = ViewData["bedId"].ToString();
                Patient.Name = addmision.PatientName;
                Patient.Age = addmision.Age;
                Patient.ContactNo = addmision.ContactNo;
                Patient.Address = addmision.Address;
                Patient.Gender = addmision.Sex;
                
                db.Patients.Add(Patient);
                db.SaveChanges();

              

                Mkadd.RoomId = addmision.RoomId;
                 Mkadd.BedId = addmision.BedId;// Convert.ToInt32(bedid);
                Mkadd.RegNo = getRegNumber();
                Mkadd.DateOfAddmission = addmision.DateOfAdmission;
                Mkadd.PatientId = Patient.id;
                Mkadd.DateOfDischarge = "";

                db.Addmisions.Add(Mkadd);
                db.SaveChanges();
               var x= db.Rooms.Select(c => new
                {
                    roomName = c.RoomName,
                    roomId = c.Id
                }).Where(k => k.roomId== addmision.RoomId).FirstOrDefault();
                aroom.AddmissionId = Mkadd.id;
                aroom.RoomId = Mkadd.RoomId;
                aroom.BedId = Mkadd.BedId;
                aroom.RegNo = Mkadd.RegNo;
                aroom.DateAdded = DateTime.Now.ToString();
                aroom.RoomName = x.roomName;

                Bed bed1 = new Bed();
                bed1=beds.GetBed(Mkadd.BedId);
                bed1.IsAssign = true;
                beds.Update(bed1);
                
                db.AssignRooms.Add(aroom);
                db.SaveChanges();
                //adding data into database
                //if(Mkadd !=null && aroom !=null && Patient != null)
                // {
                //patientRepository.Add(Patient);
                //_context.Add(Mkadd);
                //assignRoomRepository.Add(aroom);
                //}
               


               // Mkadd.
               //_context.Add(Mkadd);
                return RedirectToAction(nameof(Index));
                }
            ViewBag.RegNo = getRegNumber();
            // ViewData["BedId"] = new SelectList(Bedcontext.GetBeds(), "id", "id", addmision.BedId);
            ViewData["RoomId"] = new SelectList(RoomCotext.GetRooms(), "Id", "Id", addmision.RoomId);
            return View(addmision);
        }

        // GET: Addmisions/Edit/5
        public IActionResult Edit(int id)
        {
            var addmision = _context.GetAddmision(id);
            if (addmision == null)
            {
                return NotFound();
            }
            ViewData["BedId"] = new SelectList(Bedcontext.GetBeds(), "id", "id", addmision.BedId);
            ViewData["RoomId"] = new SelectList(RoomCotext.GetRooms(), "Id", "Id", addmision.RoomId);
            return View(addmision);
        }

        // POST: Addmisions/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Edit(int id, [Bind("id,PatientName,Age,Sex,RegistrationNumber,Address,RoomId,BedId,ContactNo,DateOfAdmission,Weight,Refrence,TimeOfAddmision")] Addmision addmision)
        //{
        //    if (id != addmision.id)
        //    {
        //        return NotFound();
        //    }

        //    if (ModelState.IsValid)
        //    {
        //        try
        //        {
        //            //_context.Update(addmision);
        //        }
        //        catch (DbUpdateConcurrencyException)
        //        {
                    
        //        }
        //        return RedirectToAction(nameof(Index));
        //    }
        //    ViewData["BedId"] = new SelectList(Bedcontext.GetBeds(), "id", "id", addmision.BedId);
        //    ViewData["RoomId"] = new SelectList(RoomCotext.GetRooms(), "Id", "Id", addmision.RoomId);
        //    return View(addmision);
        //}

        // GET: Addmisions/Delete/5
        public IActionResult Delete(int id)
        {
            if (id == 0)
            {
                return NotFound();
            }

            var addmision = _context.GetAddmision(id);
            if (addmision == null)
            {
                return NotFound();
            }

            return View(addmision);
        }

        // POST: Addmisions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            var addmision = _context.Delete(id);
            return RedirectToAction(nameof(Index));
        }

    }
}
