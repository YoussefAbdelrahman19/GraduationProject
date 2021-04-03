﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GraduationProject.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class GraduationProjectDBEntities : DbContext
    {
        public GraduationProjectDBEntities()
            : base("name=GraduationProjectDBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<C__MigrationHistory> C__MigrationHistory { get; set; }
        public virtual DbSet<AspNetRole> AspNetRoles { get; set; }
        public virtual DbSet<AspNetUserClaim> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUserLogin> AspNetUserLogins { get; set; }
        public virtual DbSet<AspNetUser> AspNetUsers { get; set; }
        public virtual DbSet<Beneficier> Beneficiers { get; set; }
        public virtual DbSet<BeneficierMedicineRequest> BeneficierMedicineRequests { get; set; }
        public virtual DbSet<BMedicineRequestStatu> BMedicineRequestStatus { get; set; }
        public virtual DbSet<City> Cities { get; set; }
        public virtual DbSet<Complaint> Complaints { get; set; }
        public virtual DbSet<ComplaintStatu> ComplaintStatus { get; set; }
        public virtual DbSet<CompliantFile> CompliantFiles { get; set; }
        public virtual DbSet<Doctor> Doctors { get; set; }
        public virtual DbSet<Donator> Donators { get; set; }
        public virtual DbSet<Gender> Genders { get; set; }
        public virtual DbSet<Governarte> Governartes { get; set; }
        public virtual DbSet<Medicine> Medicines { get; set; }
        public virtual DbSet<Member> Members { get; set; }
        public virtual DbSet<Pharamacy> Pharamacies { get; set; }
        public virtual DbSet<PharmacyMedicineRequest> PharmacyMedicineRequests { get; set; }
        public virtual DbSet<PharmacyWorker> PharmacyWorkers { get; set; }
        public virtual DbSet<PhMedicineRequestStatu> PhMedicineRequestStatus { get; set; }
        public virtual DbSet<Status> Status { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<Worker> Workers { get; set; }
    }
}