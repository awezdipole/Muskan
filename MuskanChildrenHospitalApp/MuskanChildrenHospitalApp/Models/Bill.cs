using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MuskanChildrenHospitalApp.Models
{
    public class Bill
    {
        public int Id { get; set; }
        public string BillNo { get; set; }
        public String RegistrationNumber { get; set; }

        [DisplayName( "Date Of Discharge")]
        public String DateOfDischarge { get; set; }
        public string Diagnosis { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        [DisplayName("Total Amount")]
        public Decimal TotalAmount { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        [DisplayName("Advance Amount")]
        public Decimal Advance { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public Decimal Discount { get; set; }

        [Column(TypeName = "decimal(18,2)")]

        [DisplayName("Balance Amount")]
        public Decimal Balance { get; set; }
        [DisplayName("Amount In Words")]
        public String AmountInWords { get; set; }


        //Foreign key Injected
        [ForeignKey("Addmision")]
        [DisplayName("Registration Number")]
        public int AddmisionId { get; set; }
        public Addmision Addmision { get; set; }



        [Column(TypeName = "decimal(18,2)")]
        public decimal Refund { get; set; }
    }
}
