using MuskanChildrenHospitalApp.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MuskanChildrenHospitalApp.Models.Interface
{
    public class ExpenseHeadsRepository : IExpenseHeadsRepository
    {
        private readonly ApplicationDbContext _context;

        public ExpenseHeadsRepository(ApplicationDbContext Context)
        {
            this._context = Context;
        }
        public ExpenseHeads Add(ExpenseHeads expenseHeads)
        {
            _context.ExpenseHeads.Add(expenseHeads);
            _context.SaveChanges();
            return expenseHeads;
        }

        public ExpenseHeads Delete(int Id)
        {
            ExpenseHeads expenseHeads = _context.ExpenseHeads.Find(Id);

            if (expenseHeads !=null)
            {
                _context.ExpenseHeads.Remove(expenseHeads);
                _context.SaveChanges();

            }
            return expenseHeads;

        }

        public IEnumerable<ExpenseHeads> ExpenseHeads()
        {
            return _context.ExpenseHeads;
        }

        public ExpenseHeads GetExpenseHead(int id)
        {
            ExpenseHeads expenseHeads = _context.ExpenseHeads.Find(id);
            return expenseHeads;
        }

        public ExpenseHeads Update(ExpenseHeads expenseHeadsChanges)
        {
            var head = _context.ExpenseHeads.Attach(expenseHeadsChanges);
            head.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();

            return expenseHeadsChanges;
        }
    }
}
