using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MuskanChildrenHospitalApp.Models.Work
{
    public class mBillRommDetailsCharges
    {
        public int id { get; set; }
        //Foreign key Injected
        [ForeignKey("mBill")]
        public int BillId { get; set; }
        public mBill Mbills { get; set; }
        //Foreign key Injected
        [ForeignKey("Room")]
        public int roomId { get; set; }
        public Room rooms { get; set; }
        //Foreign key Injected
        [ForeignKey("AssignRoom")]
        public int AssignRoomId { get; set; }
        public AssignRoom assign { get; set; }
        public int Days { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        [DisplayName("Charge")]
        public decimal Charge { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        [DisplayName(" Amount")]
        public decimal Amount { get; set; }
    }
}
