using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MuskanChildrenHospitalApp.Models
{
    public class ExpenseReceipt
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Date { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal Amount { get; set; }
        public string ReceiptNo { get; set; }

        //Foreign key Injected
        [ForeignKey("ExpenseHeads")]
        public int HeadsId { get; set; }
        public ExpenseHeads expenseHeads { get; set; }

        public string PayementMode { get; set; }
        public string  RefrenceId { get; set; }

        public string AccountName { get; set; }
    }
}
