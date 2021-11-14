using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MuskanChildrenHospitalApp.Models.Work
{
    public class mBillDetailsService
    {
        public int Id { get; set; }
        //Foreign key Injected
        [ForeignKey("mBill")]
        public int mBillId { get; set; }
        public mBill Mbills { get; set; }
        [ForeignKey("service")]
        public int ServiceId { get; set; }
        public service Services { get; set; }
        public string ServiceName { get; set; }
        public int Day { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        [DisplayName("Price")]
        public decimal Price { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        [DisplayName(" Amount")]
        public decimal Amount { get; set; }
    }
}
