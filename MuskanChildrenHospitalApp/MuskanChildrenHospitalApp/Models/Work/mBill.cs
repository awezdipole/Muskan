using System;
using System.Collections.Generic;
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
        public string RegNo { get; set; }
        public string Date { get; set; }
        public decimal TotalAmt { get; set; }
        public decimal AdvanceAmt { get; set; }
        public decimal BalanceAmt { get; set; }
        public decimal RefundAmt { get; set; }

        public decimal DiscountAmt { get; set; }
        public string BillNo { get; set; }
    }
}
