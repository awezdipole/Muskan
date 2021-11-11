using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MuskanChildrenHospitalApp.Models.Work
{
    public class AssignRoom
    {
        public int id { get; set; }
        //Foreign key Injected
        [ForeignKey("Room")]
        public int RoomId { get; set; }
        public Room Rooms { get; set; }
        //Foreign key Injected
        [ForeignKey("Bed")]
        public int BedId { get; set; }
        public Bed beds { get; set; }
        //Foreign key Injected
        [ForeignKey("mkAddmision")]
        public int AddmissionId { get; set; }
        public mkAddmision mkAddmisions { get; set; }
        public string RegNo { get; set; }
        public string DateAdded { get; set; }
        public string DateUpdate { get; set; }
        public bool Status { get; set; }
        public bool IsDischarge { get; set; }

    }
}
