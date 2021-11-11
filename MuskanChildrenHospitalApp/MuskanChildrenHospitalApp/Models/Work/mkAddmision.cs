using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MuskanChildrenHospitalApp.Models.Work
{
    public class mkAddmision
    {
        public int id { get; set; }
        [ForeignKey("Patient")]
        public int PatientId { get; set; }
        public Patient Patients { get; set; }
        public string DateOfAddmission { get; set; }
        public string DateOfDischarge { get; set; }
        public string RegNo { get; set; }
        public bool Status { get; set; }
        public int UserId { get; set; }
    }
}
