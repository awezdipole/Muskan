using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MuskanChildrenHospitalApp.Models
{
    public class BillDetails
    {
        public int Id { get; set; }
        public string ServiceName { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal qty { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal Amount { get; set; }

        //Foreign key Injected
        [ForeignKey("Bill")]
        public int BillId { get; set; }
        public Bill bill { get; set; }

    }
}
