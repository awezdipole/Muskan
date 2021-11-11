using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MuskanChildrenHospitalApp.Models
{
    public class TransferAddmissionTable
    {
        public int Id { get; set; }

        [ForeignKey("Room")]
        public int? RoomId { get; set; }
        public Room Room { get; set; }
        //Foreign key Injected
        [ForeignKey("Bed")]
        public int? BedId { get; set; }
        public Bed Bed { get; set; }
        public string BedName { get; set; }
        public string RoomName { get; set; }
        public string AddDate { get; set; }
        public bool  Status { get; set; }
        public bool IsDischarge { get; set; }

        [ForeignKey("Addmision")]
        public int? AddmisionId { get; set; }
        public Addmision addmision { get; set; }

        public string RegistrationNumber { get; set; }

    }
}
