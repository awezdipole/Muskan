using MuskanChildrenHospitalApp.Data;
using MuskanChildrenHospitalApp.Models.Work;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MuskanChildrenHospitalApp.Models.Interface
{
    public class AssignRoomRepository : IAssignRoomRepository
    {
        private readonly ApplicationDbContext _context;

        public AssignRoomRepository(ApplicationDbContext context)
        {
            this._context = context;
        }
        public AssignRoom Add(AssignRoom room)
        {
            _context.AssignRooms.Add(room);
            _context.SaveChanges();
            return room;
        }

        public AssignRoom Delete(int id)
        {
            AssignRoom room = _context.AssignRooms.Find(id);
            if(room != null)
            {
                _context.AssignRooms.Remove(room);
                _context.SaveChanges();
            }
            return room;
        }

        public AssignRoom GetAssignRoom(int id)
        {
            AssignRoom room = _context.AssignRooms.Find(id);
            return room;
        }

        public IEnumerable<AssignRoom> GetAssignRooms()
        {
            return _context.AssignRooms;
        }

        public AssignRoom Update(AssignRoom roomChanges)
        {
            var room = _context.AssignRooms.Attach(roomChanges);
            room.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
            return roomChanges;
        }
    }
}
