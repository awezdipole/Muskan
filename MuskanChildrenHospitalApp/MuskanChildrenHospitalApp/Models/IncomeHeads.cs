using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MuskanChildrenHospitalApp.Models
{
    public class IncomeHeads
    {
        public int Id { get; set; }
        public String HeadsName { get; set; }
        public bool Status { get; set; }
        public String CreatedDate { get; set; }
        public String ModifiedDate { get; set; }
        public ICollection<Receipt> Receipts { get; set; }
    }
}
