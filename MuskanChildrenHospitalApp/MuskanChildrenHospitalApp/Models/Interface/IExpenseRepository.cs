using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MuskanChildrenHospitalApp.Models.Interface
{
    public interface IExpenseRepository
    {
        ExpenseReceipt GetExpenseReceipt(int id);

        IEnumerable<ExpenseReceipt> GetExpenseReceipts();
        ExpenseReceipt Add(ExpenseReceipt expenseReceipt);
    }
}
