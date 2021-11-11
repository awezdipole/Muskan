using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MuskanChildrenHospitalApp.Models.Interface
{
    public interface IExpenseHeadsRepository
    {
        ExpenseHeads GetExpenseHead(int id);
        IEnumerable<ExpenseHeads> ExpenseHeads();
        ExpenseHeads Add(ExpenseHeads expenseHeads);
        ExpenseHeads Update(ExpenseHeads expenseHeadsChanges);
        ExpenseHeads Delete(int Id);
    }
}
