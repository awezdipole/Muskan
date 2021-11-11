using MuskanChildrenHospitalApp.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MuskanChildrenHospitalApp.Models.Interface
{
    public class RoomRepository : IRoomRepository
    {
        private readonly ApplicationDbContext context;

        public RoomRepository(ApplicationDbContext context)
        {
            this.context = context;
        }
        public Room Add(Room room)
        {
            context.Rooms.Add(room);
            context.SaveChanges();
            return room;
        }

        public Room Delete(int id)
        {
            Room room = context.Rooms.Find(id);

            if (room!=null)
            {
                context.Rooms.Remove(room);
                context.SaveChanges();
            }
            return room;
        }

        public Room GetRoom(int id)
        {
            Room room = context.Rooms.Find(id);
            return room;
        }

        public IEnumerable<Room> GetRooms()
        {
           return context.Rooms;
        }

        public Room Update(Room rooChanges)
        {
            var room = context.Rooms.Attach(rooChanges);
            room.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();

            return rooChanges;
        }
    }
}
