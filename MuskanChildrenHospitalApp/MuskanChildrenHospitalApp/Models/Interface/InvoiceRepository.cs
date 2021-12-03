using MuskanChildrenHospitalApp.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MuskanChildrenHospitalApp.Models.Interface
{
    public class InvoiceRepository : IinvoiceRepository
    {
        private readonly ApplicationDbContext context;

        public InvoiceRepository(ApplicationDbContext Context)
        {
            context = Context;
        }
        public collection_Invoice Add(collection_Invoice bill)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<collection_Invoice> bills()
        {
            throw new NotImplementedException();
        }

        public collection_Invoice GetBill(int id)
        {
            throw new NotImplementedException();
        }
    }
}
