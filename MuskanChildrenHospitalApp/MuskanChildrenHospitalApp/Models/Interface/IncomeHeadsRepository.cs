using MuskanChildrenHospitalApp.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MuskanChildrenHospitalApp.Models.Interface
{
    public class IncomeHeadsRepository : IincomeHeadsRepository
    {
        private readonly ApplicationDbContext _context;

        public IncomeHeadsRepository(ApplicationDbContext Context)
        {
            this._context = Context;
        }
        public IncomeHeads Add(IncomeHeads incomeHeads)
        {
            _context.IncomeHeads.Add(incomeHeads);
            _context.SaveChanges();
            return incomeHeads;
        }

        public IncomeHeads Delete(int id)
        {
            IncomeHeads income = _context.IncomeHeads.Find(id);
            if (income != null)
            {
                _context.IncomeHeads.Remove(income);
                _context.SaveChanges();
            }
            return income;
        }

        public IncomeHeads GetIncome(int id)
        {
            IncomeHeads income = _context.IncomeHeads.Find(id);
            return income;
        }

        public IEnumerable<IncomeHeads> IncomeHeads()
        {
            return _context.IncomeHeads;
        }

        public IncomeHeads Update(IncomeHeads incomeHeadsChanges)
        {
            var income = _context.IncomeHeads.Attach(incomeHeadsChanges);
            income.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();

            return incomeHeadsChanges;
        }
    }
}
