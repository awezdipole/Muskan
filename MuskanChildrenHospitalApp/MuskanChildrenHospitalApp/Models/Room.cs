using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MuskanChildrenHospitalApp.Models
{
    public class Room
    {
        public int Id { get; set; }
        public string RoomName { get; set; }
        public string RoomType { get; set; }
        public bool Status { get; set; }

        public decimal TotalCharges { get; set; }
        public decimal BedCharge { get; set; }
        public decimal DoctorCharge { get; set; }
        public decimal NursingCharges { get; set; }
        public string CreatedBy { get; set; }
        public DateTime createdDate { get; set; }

        public string ModifiedBy { get; set; }
        public DateTime ModifiedDate { get; set; }

        //Foreign Key Reference
        public ICollection<Bed> Beds { get; set; }
        public ICollection<Addmision> Addmisions { get; set; }


    }
}
