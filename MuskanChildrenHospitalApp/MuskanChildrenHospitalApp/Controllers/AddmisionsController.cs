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

namespace MuskanChildrenHospitalApp.Controllers
{
    public class AddmisionsController : Controller
    {
        private readonly IAdmissionRepositoy _context;
        private readonly IbedRepository Bedcontext;
        private readonly IRoomRepository RoomCotext;

        public AddmisionsController(IAdmissionRepositoy context, IbedRepository ibedContext, IRoomRepository room)
        {
            _context = context;
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
        public async Task<IActionResult> Create([Bind("id,PatientName,Age,Sex,RegistrationNumber,Address,RoomId,BedId,ContactNo,DateOfAdmission,Weight,Refrence,TimeOfAddmision")] Addmision addmision)
        {
            if (ModelState.IsValid)
            {
                _context.Add(addmision);
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
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id,PatientName,Age,Sex,RegistrationNumber,Address,RoomId,BedId,ContactNo,DateOfAdmission,Weight,Refrence,TimeOfAddmision")] Addmision addmision)
        {
            if (id != addmision.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(addmision);
                }
                catch (DbUpdateConcurrencyException)
                {
                    
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["BedId"] = new SelectList(Bedcontext.GetBeds(), "id", "id", addmision.BedId);
            ViewData["RoomId"] = new SelectList(RoomCotext.GetRooms(), "Id", "Id", addmision.RoomId);
            return View(addmision);
        }

        // GET: Addmisions/Delete/5
        public IActionResult Delete(int id)
        {
            if (id == null)
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
