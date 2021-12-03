using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MuskanChildrenHospitalApp.Models.Interface
{
   public interface IinvoiceRepository
    {
        collection_Invoice GetBill(int id);
        IEnumerable<collection_Invoice> bills();

        collection_Invoice Add(collection_Invoice bill);
    }
}
