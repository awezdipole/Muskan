using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MuskanChildrenHospitalApp.Models.Work
{
    [Table("Addmision")]
    public class mkAddmision
    {
        public int id { get; set; }
        [ForeignKey("Patient")]
        public int PatientId { get; set; }
        public Patient Patients { get; set; }
        [DisplayName("Date Of Addmission")]
        public string DateOfAddmission { get; set; }
        [DisplayName("Date Of Discharge")]
        public string DateOfDischarge { get; set; }
        [DisplayName("Reg No")]
        public string RegNo { get; set; }
        public bool Status { get; set; }
        public int UserId { get; set; }
        public bool IsDischarge { get; set; }
        [ForeignKey("Room")]
        public int? RoomId { get; set; }
        public Room Rooms { get; set; }
        //Foreign key Injected
        [ForeignKey("Bed")]
        public int BedId { get; set; }
        public Bed beds { get; set; }

        public ICollection<AssignRoom> assignRooms { get; set; }
        public ICollection<mBill> mBills { get; set; }
        public ICollection<Receipt> receipts { get; set; }

    }
}
