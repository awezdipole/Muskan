using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MuskanChildrenHospitalApp.Models.Interface
{
    public interface IReceiptRepository
    {
        Receipt GetReceipt(int id);
        IEnumerable<Receipt> Receipts();
        Receipt Add(Receipt receipt);
        
    }
}
