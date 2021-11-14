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
    public class RoomsController : Controller
    {
        private readonly IRoomRepository _room;

        public RoomsController(IRoomRepository room)
        {
            this._room = room;
        }

        // GET: Rooms
        public IActionResult Index()
        {
            return View(_room.GetRooms());
        }

        // GET: Rooms/Details/5
        public IActionResult Details(int id)
        {
           
            var room = _room.GetRoom(id);
            if (room == null)
            {
                return NotFound();
            }

            return View(room);
        }

        // GET: Rooms/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Rooms/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("Id,RoomName,RoomType,BedCharge,DoctorCharge,NursingCharges,TotalCharges")] Room room)
        {
            
            if (ModelState.IsValid)
            {

                room.Status = true;
                room.IsAssign = false;
                room.ModifiedDate = DateTime.Now;
                room.ModifiedBy = "Admin"; 
                room.createdDate = DateTime.Now;
                room.CreatedBy = "Admin";
                _room.Add(room);
                return RedirectToAction(nameof(Index));
            }
            return View(room);
        }

        // GET: Rooms/Edit/5
        public IActionResult Edit(int id)
        {
            var room = _room.GetRoom(id);
            if (room == null)
            {
                return NotFound();
            }
            return View(room);
        }

        // POST: Rooms/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, [Bind("Id,RoomName,RoomType")] Room room)
        {
            if (id != room.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
               
                    room.Status = true;
                    room.ModifiedBy = "Admin";
                    room.ModifiedDate = DateTime.Now;
                    _room.Update(room);
                
                
                return RedirectToAction(nameof(Index));
            }
            return View(room);
        }

        // GET: Rooms/Delete/5
        public IActionResult Delete(int id)
        {
            var room = _room.GetRoom(id);
            if (room == null)
            {
                return NotFound();
            }

            return View(room);
        }

        // POST: Rooms/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            var room = _room.GetRoom(id);
       
                room.Status = false;
                room.ModifiedBy = "Admin";
                room.ModifiedDate = DateTime.Now;
                _room.Update(room);
           
           
            return RedirectToAction(nameof(Index));
        }

        //private bool RoomExists(int id)
        //{
        //    return _context.Rooms.Any(e => e.Id == id);
        //}
    }
}
