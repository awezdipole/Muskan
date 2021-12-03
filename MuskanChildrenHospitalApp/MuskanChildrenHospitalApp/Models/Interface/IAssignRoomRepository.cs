using MuskanChildrenHospitalApp.Models.Work;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MuskanChildrenHospitalApp.Models.Interface
{
    public interface IAssignRoomRepository
    {
        AssignRoom GetAssignRoom(int id);

        IEnumerable<AssignRoom> GetAssignRooms();
        IEnumerable<AssignRoom> GetAssignRoomsByAddId(int id);
        AssignRoom Add(AssignRoom room);
        AssignRoom Update(AssignRoom roomChanges);
        AssignRoom Delete(int id);
    }
}
