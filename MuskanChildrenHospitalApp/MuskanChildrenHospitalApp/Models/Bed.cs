using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MuskanChildrenHospitalApp.Models
{
    public class Bed
    {
        public int id { get; set; }
        public string BedName { get; set; }

        public bool Status { get; set; }
        public string CreatedBy { get; set; }
        public DateTime createdDate { get; set; }

        public string ModifiedBy { get; set; }
        public DateTime ModifiedDate { get; set; }

        //Foreign key Injected
        [ForeignKey("Room")]
        public int RoomId { get; set; }
        public Room Room { get; set; }

        public ICollection<Addmision> Addmisions { get; set; }
    }
}
