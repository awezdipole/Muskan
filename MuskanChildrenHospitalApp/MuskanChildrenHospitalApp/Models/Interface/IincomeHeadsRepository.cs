using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MuskanChildrenHospitalApp.Models.Interface
{
    public interface IincomeHeadsRepository
    {
        IncomeHeads GetIncome(int id);
        IEnumerable<IncomeHeads> IncomeHeads();
        IncomeHeads Add(IncomeHeads incomeHeads);
        IncomeHeads Update(IncomeHeads incomeHeadsChanges);
        IncomeHeads Delete(int id);
    }
}
