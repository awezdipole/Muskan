using MuskanChildrenHospitalApp.Models.Work;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MuskanChildrenHospitalApp.Models.Interface
{
    public interface IBillRepository
    {
        mBill GetBill(int id);
        IEnumerable<mBill> bills();

        mBill Add(mBill bill);

    }
}
