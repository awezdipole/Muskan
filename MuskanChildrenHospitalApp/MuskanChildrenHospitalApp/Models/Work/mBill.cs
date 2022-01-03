using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MuskanChildrenHospitalApp.Models.Work
{ 
    public class mBill
    {
        public int id { get; set; }
        //Foreign key Injected
        [ForeignKey("mkAddmision")]
        public int addmisionId { get; set; }
        public mkAddmision mAddmisions { get; set; }
        [DisplayName("Reg No")]
        public string RegNo { get; set; }
        [DisplayName("Diagnosis")]
        public string Diagnosis { get; set; }
        [DisplayName("Amount In Words")]
        public string AmtInWords { get; set; }
        public string Date { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        [DisplayName("Total Amount")]
        public decimal TotalAmt { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        [DisplayName("Advance Amount")]
        public decimal AdvanceAmt { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        [DisplayName("Balance Amount")]
        public decimal BalanceAmt { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        [DisplayName("Refund Amount")]
        public decimal RefundAmt { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        [DisplayName("Discount Amount")]
        public decimal DiscountAmt { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        [DisplayName("Paid Amount")]
        public decimal PaidAmt { get; set; }
        public string BillNo { get; set; }

        public ICollection<mBillDetailsService> mServices { get; set; }
        public ICollection<mBillRommDetailsCharges> mRooms { get; set; }
    }
}
