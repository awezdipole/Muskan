using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MuskanChildrenHospitalApp.Models;
using MuskanChildrenHospitalApp.Models.Work;
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
      public DbSet<mkAddmision> Addmisions { get; set; }
        public DbSet<Receipt> Receipts { get; set; }
        public DbSet<ExpenseHeads> ExpenseHeads { get; set; }
        public DbSet<ExpenseReceipt> ExpenseReceipts { get; set; }
        public DbSet<IncomeHeads> IncomeHeads { get; set; }
        public DbSet<mBill> Bills { get; set; }
        public DbSet<mBillDetailsService> BillDetails { get; set; }
        public DbSet<mBillRommDetailsCharges> mBillRoom { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<service> Services { get; set; }
        public DbSet<AssignRoom> AssignRooms { get; set; }
        //public DbSet<MuskanChildrenHospitalApp.Models.Addmision> Addmision { get; set; }
    }
}
