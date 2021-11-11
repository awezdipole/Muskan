using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MuskanChildrenHospitalApp.Models.Interface
{
    public interface IBillDetailsRepositoy
    {
        BillDetails GetBillDetails(int id);
        IEnumerable<BillDetails> OderDetailList(int orderId);

        BillDetails Add(BillDetails billDetails);
    }
}
