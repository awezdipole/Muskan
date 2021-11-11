using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MuskanChildrenHospitalApp.Models.Work
{
    public class mBillRommDetailsCharges
    {
        public int id { get; set; }
        public int BillId { get; set; }
        public int RoomChargeId { get; set; }
        public int AssignRoomId { get; set; }
        public decimal Days { get; set; }
        public decimal Charge { get; set; }
        public decimal Amount { get; set; }
    }
}
