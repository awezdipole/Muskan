using MuskanChildrenHospitalApp.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MuskanChildrenHospitalApp.Models.Interface
{
    public class ExpenseReceiptRepository : IExpenseRepository
    {
        private readonly ApplicationDbContext _context;

        public ExpenseReceiptRepository(ApplicationDbContext Context)
        {
            this._context = Context;
        }
        public ExpenseReceipt Add(ExpenseReceipt expenseReceipt)
        {
            _context.ExpenseReceipts.Add(expenseReceipt);
            _context.SaveChanges();
            return expenseReceipt;
        }

        public ExpenseReceipt GetExpenseReceipt(int id)
        {
            ExpenseReceipt expenseReceipt = _context.ExpenseReceipts.Find(id);
            return expenseReceipt;
        }

        public IEnumerable<ExpenseReceipt> GetExpenseReceipts()
        {
            return _context.ExpenseReceipts;
        }
    }
}
