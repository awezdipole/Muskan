using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MuskanChildrenHospitalApp.Models.Interface
{
    public interface IBillRepository
    {
        Bill GetBill(int id);
        IEnumerable<Bill> bills();

        Bill Add(Bill bill);

    }
}
