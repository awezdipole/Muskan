using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MuskanChildrenHospitalApp.Models.Interface
{
    public interface IRoomRepository
    {
        Room GetRoom(int id);
        IEnumerable<Room> GetRooms();
        Room Add(Room room);
        Room Update(Room rooChanges);
        Room Delete(int id);
    }
}
