using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MuskanChildrenHospitalApp.Models
{
    public class Addmision
    {
        public int id { get; set; }
        public String PatientName { get; set; }
        public String Age { get; set;  }

        public String Sex { get; set; }
        public String RegistrationNumber { get; set; }

        public String Address { get; set; }

        //Foreign key Injected
        [ForeignKey("Room")]
        public int? RoomId { get; set; }
        public Room Room { get; set; }

        //Foreign key Injected
        [ForeignKey("Bed")]
        public int? BedId { get; set; }
        public Bed Bed { get; set; }

        public string ContactNo { get; set; }

        public string DateOfAdmission { get; set; }

        public int Weight { get; set; }
        public string Refrence { get; set; }
        public string TimeOfAddmision { get; set; }

        public ICollection<Bill> Bill { get; set; }
        public ICollection<Receipt> Receipt { get; set; }


    }
}
