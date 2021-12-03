using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MuskanChildrenHospitalApp.Models
{
    public class Addmision
    {
        public int id { get; set; }
        public int PatientId { get; set; }
        [DisplayName("Patient Name")]
        public String PatientName { get; set; }
        public String Age { get; set;  }

        [DisplayName("Room Name")]
        public string RoomName { get; set; }
        [DisplayName("Bed Name")]
        public string BedName { get; set; }
        public String Sex { get; set; }
        [DisplayName("Reg No")]
        public String RegistrationNumber { get; set; }

        public String Address { get; set; }

        [DisplayName("Room")]
        public int RoomId { get; set; }

        [DisplayName("Bed")]
        public int BedId { get; set; }

        [DisplayName("Contact No")]
        public string ContactNo { get; set; }
        [DisplayName("Date Of Addmission")]
        public string DateOfAdmission { get; set; }

        public int Weight { get; set; }
        public string Refrence { get; set; }
        public string TimeOfAddmision { get; set; }
        [DisplayName("Date Of Discharge")]
        public string DateOfDischarge { get; set; }

        public bool IsDischarge { get; set; }

    }

   

}
