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

     
        public int RoomId { get; set; }
      

        public int BedId { get; set; }
       

        public string ContactNo { get; set; }

        public string DateOfAdmission { get; set; }

        public int Weight { get; set; }
        public string Refrence { get; set; }
        public string TimeOfAddmision { get; set; }
        public string DateOfDischarge { get; set; }


    }
}
