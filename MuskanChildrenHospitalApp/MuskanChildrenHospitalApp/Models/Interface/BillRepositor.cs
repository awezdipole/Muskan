using MuskanChildrenHospitalApp.Data;
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
        public Bill Add(Bill bill)
        {
            _context.Bills.Add(bill);
            _context.SaveChanges();
            return bill;
        }

        public IEnumerable<Bill> bills()
        {
            return _context.Bills;
        }

        public Bill GetBill(int id)
        {
            Bill bill = _context.Bills.Find(id);

            return bill;
        }
    }
}
