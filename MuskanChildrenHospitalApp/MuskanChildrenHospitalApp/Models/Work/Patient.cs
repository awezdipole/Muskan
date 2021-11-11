using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MuskanChildrenHospitalApp.Models.Work
{
    public class Patient
    {
        public int id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public string ContactNo { get; set; }
        public string Age { get; set; }
        public string Address { get; set; }
    }
}
