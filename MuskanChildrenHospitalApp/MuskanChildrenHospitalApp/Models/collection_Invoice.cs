using MuskanChildrenHospitalApp.Models.Work;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MuskanChildrenHospitalApp.Models
{
    public class collection_Invoice
    {
        public mBill bill { get; set; }
        public mkAddmision addmision { get; set; }
        public Patient Patient { get; set; }
        public List<mBillDetailsService> ServiceDetails { get; set; }
        public List<mBillRommDetailsCharges> RoomDetails { get; set; }
    }
}
