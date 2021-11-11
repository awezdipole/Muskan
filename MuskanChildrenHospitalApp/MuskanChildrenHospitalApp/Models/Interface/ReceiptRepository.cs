using MuskanChildrenHospitalApp.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MuskanChildrenHospitalApp.Models.Interface
{
    public class ReceiptRepository : IReceiptRepository
    {
        private readonly ApplicationDbContext _context;

        public ReceiptRepository(ApplicationDbContext Context)
        {
            this._context = Context;
        }
        public Receipt Add(Receipt receipt)
        {
            _context.Receipts.Add(receipt);
            _context.SaveChanges();
            return receipt;
        }

        public Receipt GetReceipt(int id)
        {
            Receipt receipt = _context.Receipts.Find(id);
            return receipt;
        }

        public IEnumerable<Receipt> Receipts()
        {
            return _context.Receipts;
        }
    }
}
