using MuskanChildrenHospitalApp.Models.Work;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MuskanChildrenHospitalApp.Models
{
    public class Bed
    {
        public int id { get; set; }
        [DisplayName("Bed Name")]
        public string BedName { get; set; }

        public bool Status { get; set; }
        public string CreatedBy { get; set; }
        public DateTime createdDate { get; set; }

        public string ModifiedBy { get; set; }
        [DisplayName("Modified Date")]
        public DateTime ModifiedDate { get; set; }

        //Foreign key Injected
        [ForeignKey("Room")]
        [DisplayName("Room")]
        public int RoomId { get; set; }
        public Room Room { get; set; }
        [DisplayName("Boked")]
        public bool IsAssign { get; set; }
        public ICollection<mkAddmision> Addmisions { get; set; }
    }
}
