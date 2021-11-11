using MuskanChildrenHospitalApp.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MuskanChildrenHospitalApp.Models.Interface
{
    public class BillDetailsRepositoy : IBillDetailsRepositoy
    {
        private readonly ApplicationDbContext _context;

        public BillDetailsRepositoy(ApplicationDbContext Context)
        {
            this._context = Context;
        }
        public BillDetails Add(BillDetails billDetails)
        {
            _context.BillDetails.Add(billDetails);
            _context.SaveChanges();
            return billDetails;
        }

        public BillDetails GetBillDetails(int id)
        {
            BillDetails billDetail = _context.BillDetails.Find(id);
            return billDetail;
        }

        public IEnumerable<BillDetails> OderDetailList(int orderId)
        {
            return _context.BillDetails.OrderBy(d=> d.BillId==orderId).ToList();
        }
    }
}
