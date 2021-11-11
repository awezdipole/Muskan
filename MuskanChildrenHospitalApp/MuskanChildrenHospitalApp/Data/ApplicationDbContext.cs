using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MuskanChildrenHospitalApp.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MuskanChildrenHospitalApp.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Bed> Beds { get; set; }
        public DbSet<Addmision> Addmisions { get; set; }
        public DbSet<Receipt> Receipts { get; set; }
        public DbSet<ExpenseHeads> ExpenseHeads { get; set; }
        public DbSet<ExpenseReceipt> ExpenseReceipts { get; set; }
        public DbSet<IncomeHeads> IncomeHeads { get; set; }
        public DbSet<Bill> Bills { get; set; }
        public DbSet<BillDetails> BillDetails { get; set; }

        public DbSet<service> Services { get; set; }
    }
}
