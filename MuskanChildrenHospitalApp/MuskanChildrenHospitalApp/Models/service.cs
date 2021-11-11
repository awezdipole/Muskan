using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace MuskanChildrenHospitalApp.Models
{
    public class service
    {
        public int id { get; set; }

        [DisplayName("Service Name")]
        public string ServiceName { get; set; }
        public decimal Charges { get; set; }
        public bool Status { get; set; }
        public string UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public string AddDate { get; set; }
        public string addedBy { get; set; }
    }
}
