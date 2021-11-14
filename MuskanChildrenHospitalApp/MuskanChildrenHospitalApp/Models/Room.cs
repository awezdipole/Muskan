using MuskanChildrenHospitalApp.Models.Work;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MuskanChildrenHospitalApp.Models
{
    public class Room
    {
        public int Id { get; set; }
        [DisplayName("Name")]
        public string RoomName { get; set; }
        [DisplayName("Room Type")]
        public string RoomType { get; set; }
        public bool Status { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        [DisplayName("Total Amount")]
        public decimal TotalCharges { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        [DisplayName("Bed Charge")]
        public decimal BedCharge { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        [DisplayName("Doctor Charge")]
        public decimal DoctorCharge { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        [DisplayName("Nursing Charge")]
        public decimal NursingCharges { get; set; }
        public string CreatedBy { get; set; }
        public DateTime createdDate { get; set; }

        public string ModifiedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
        [DisplayName("Boked")]
        public bool IsAssign { get; set; }

        //Foreign Key Reference
        public ICollection<Bed> Beds { get; set; }
        public ICollection<mkAddmision> Addmisions { get; set; }


    }
}
