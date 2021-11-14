using MuskanChildrenHospitalApp.Data;
using MuskanChildrenHospitalApp.Models.Work;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MuskanChildrenHospitalApp.Models.Interface
{
    public class BillRepositor : IBillRepository
    {
        private readonly ApplicationDbContext _context;

        public BillRepositor(ApplicationDbContext Context)
        {
            this._context = Context;
        }
        public mBill Add(mBill bill)
        {
            _context.Bills.Add(bill);
            _context.SaveChanges();
            return bill;
        }

        public IEnumerable<mBill> bills()
        {
            return _context.Bills;
        }

        public mBill GetBill(int id)
        {
            mBill bill = _context.Bills.Find(id);

            return bill;
        }
    }
}
