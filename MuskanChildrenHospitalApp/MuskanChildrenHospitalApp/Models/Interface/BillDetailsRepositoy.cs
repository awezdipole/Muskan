using MuskanChildrenHospitalApp.Data;
using MuskanChildrenHospitalApp.Models.Work;
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
        public mBillDetailsService Add(mBillDetailsService billDetails)
        {
            _context.BillDetails.Add(billDetails);
            _context.SaveChanges();
            return billDetails;
        }

        public mBillDetailsService GetBillDetails(int id)
        {
            mBillDetailsService billDetail = _context.BillDetails.Find(id);
            return billDetail;
        }

        public IEnumerable<mBillDetailsService> OderDetailList(int orderId)
        {
            return _context.BillDetails.OrderBy(d=> d.mBillId==orderId).ToList();
        }
    }
}
