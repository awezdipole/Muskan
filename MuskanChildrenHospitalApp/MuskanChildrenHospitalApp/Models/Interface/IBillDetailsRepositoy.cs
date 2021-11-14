using MuskanChildrenHospitalApp.Models.Work;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MuskanChildrenHospitalApp.Models.Interface
{
    public interface IBillDetailsRepositoy
    {
        mBillDetailsService GetBillDetails(int id);
        IEnumerable<mBillDetailsService> OderDetailList(int orderId);

        mBillDetailsService Add(mBillDetailsService billDetails);
    }
}
