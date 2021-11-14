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
    public class AddmisionsController : Controller
    {
        private readonly ApplicationDbContext db;
        private readonly IAdmissionRepositoy _context;
        private readonly IPatientRepository patientRepository;
        private readonly IAssignRoomRepository assignRoomRepository;
        private readonly IbedRepository Bedcontext;
        private readonly IRoomRepository RoomCotext;

        mkAddmision Mkadd = new mkAddmision();
        Patient Patient = new Patient();
        AssignRoom aroom = new AssignRoom();


       

        public AddmisionsController(ApplicationDbContext db,IAdmissionRepositoy context,IPatientRepository patientRepository,IAssignRoomRepository assignRoomRepository, IbedRepository ibedContext, IRoomRepository room)
        {
            this.db = db;
            _context = context;
            this.patientRepository = patientRepository;
            this.assignRoomRepository = assignRoomRepository;
            Bedcontext = ibedContext;
            RoomCotext = room;
        }

        // GET: Addmisions
        public IActionResult Index()
        {

            return View(_context.GetAddmisions()) ;
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
            ViewData["BedId"] = new SelectList(Bedcontext.GetBeds(), "id", "BedName");
            ViewData["RoomId"] = new SelectList(RoomCotext.GetRooms(), "Id", "RoomName");
            return View();
        }

        // POST: Addmisions/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("id,PatientName,Age,Sex,RegistrationNumber,Address,RoomId,BedId,ContactNo,DateOfAdmission,Weight,Refrence,TimeOfAddmision")] Addmision addmision)
        {
            if (ModelState.IsValid)
            {
                Patient.Name = addmision.PatientName;
                Patient.Age = addmision.Age;
                Patient.ContactNo = addmision.ContactNo;
                Patient.Address = addmision.Address;
                Patient.Gender = addmision.Sex;
                
                db.Patients.Add(Patient);
                db.SaveChanges();

              

                Mkadd.RoomId = addmision.RoomId;
                Mkadd.BedId = addmision.BedId;
                Mkadd.RegNo = addmision.RegistrationNumber;
                Mkadd.DateOfAddmission = addmision.DateOfAdmission;
                Mkadd.PatientId = Patient.id;
                Mkadd.DateOfDischarge = "";

                db.Addmisions.Add(Mkadd);
                db.SaveChanges();

                aroom.AddmissionId = Mkadd.id;
                aroom.RoomId = Mkadd.RoomId;
                aroom.BedId = Mkadd.BedId;
                aroom.RegNo = Mkadd.RegNo;
                aroom.DateAdded = DateTime.Now.ToString();

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
            ViewData["BedId"] = new SelectList(Bedcontext.GetBeds(), "id", "id", addmision.BedId);
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
