using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MuskanChildrenHospitalApp.Models.Work
{
    public class mBillDetailsService
    {
        public int Id { get; set; }
        public int mBillId { get; set; }
        public mBill Mbills { get; set; }
        public int ServiceId { get; set; }
        public service Services { get; set; }
        public string ServiceName { get; set; }
        public int Day { get; set; }
        public decimal Price { get; set; }
        public decimal Amount { get; set; }
    }
}
