﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataBaseLayer
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class OASEntities : DbContext
    {
        public OASEntities()
            : base("name=OASEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            var ensureDLLIsCopied = System.Data.Entity.SqlServer.SqlProviderServices.Instance;
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<ExpenseType> ExpenseTypes { get; set; }
        public virtual DbSet<Expense> Expenses { get; set; }
        public virtual DbSet<ClassDetail> ClassDetails { get; set; }
        public virtual DbSet<Division> Divisions { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<City> Cities { get; set; }
        public virtual DbSet<Country> Countries { get; set; }
        public virtual DbSet<State> States { get; set; }
        public virtual DbSet<Bonofied> Bonofieds { get; set; }
        public virtual DbSet<FeeDetail> FeeDetails { get; set; }
        public virtual DbSet<FeeCollection> FeeCollections { get; set; }
        public virtual DbSet<FeeConcession> FeeConcessions { get; set; }
        public virtual DbSet<Attendance> Attendances { get; set; }
        public virtual DbSet<LeaveTaken> LeaveTakens { get; set; }
        public virtual DbSet<LeaveType> LeaveTypes { get; set; }
        public virtual DbSet<Staff> Staffs { get; set; }
        public virtual DbSet<AllowanceType> AllowanceTypes { get; set; }
        public virtual DbSet<SalaryDetail> SalaryDetails { get; set; }
        public virtual DbSet<TransactionAllowance> TransactionAllowances { get; set; }
        public virtual DbSet<Charge> Charges { get; set; }
        public virtual DbSet<ReciptDetail> ReciptDetails { get; set; }
        public virtual DbSet<AccountantLogin> AccountantLogins { get; set; }
    }
}
