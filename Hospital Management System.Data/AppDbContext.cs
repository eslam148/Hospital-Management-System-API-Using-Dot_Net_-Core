﻿using Hospital_Management_System.Domain;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;

namespace Hospital_Management_System.Data
{

    public class AppDbContext: IdentityDbContext
    {
       



        public AppDbContext(DbContextOptions options):base(options)
        {
            
        }
        public virtual DbSet<Patient> Patients { get; set; }
        public virtual DbSet<Doctor> Doctors { get; set; }
        public virtual DbSet<Nurse> Nurses { get; set; }
        public virtual DbSet<Room> Rooms { get; set; }
        public virtual DbSet<Laboratory> Laboratores { get; set; }
        public virtual DbSet<Pharmacy> Pharmaces { get; set; }
        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<Hospital> Hospitals { get; set; }
        public virtual DbSet<Diagnoses> Diagnoses { get; set; }
        public virtual DbSet<Patient_Pharmacy> Patient_Pharmacy { get; set; }
        public virtual DbSet<Patient_Nurse> Patient_Nurse { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //One to Many Patient to Diagnoses
            modelBuilder.Entity<Patient>()
                .HasMany(p => p.Diagnoses)
                .WithOne(d => d.Patients);


            //One to Many Doctor to Patient
            modelBuilder.Entity<Doctor>()
                .HasMany(p=>p.Patients)
                .WithOne(d=> d.Doctors);

            ////One to Many Department to Doctor
            modelBuilder.Entity<Doctor>()
                .HasOne(d => d.Departments)
                .WithMany(d => d.Doctors);

            //One to Many Hospital to Departments
            modelBuilder.Entity<Hospital>()
                .HasMany(d => d.Departments)
                .WithOne(d => d.Hospitals)
                .HasForeignKey(d=>d.HospitalId);

            //One to Many Hospital to Departments
            modelBuilder.Entity<Room>()
                .HasMany(p => p.Patients)
                .WithOne(r => r.Rooms);

            //One to Many Hospital to Rooms
            modelBuilder.Entity<Hospital>()
                .HasMany(r => r.Rooms)
                .WithOne(h => h.Hospitals);

            //One to Many Patient to Laboratory
            modelBuilder.Entity<Patient>()
                .HasMany(l => l.Laboratory)
                .WithOne(p => p.Patients);

            //Many to Many Patient to Pharmacy
            modelBuilder.Entity<Patient>()
               .HasMany(e => e.Pharmacy)
               .WithMany(e => e.Patient)
               .UsingEntity<Patient_Pharmacy>();

            //Many to Many Patient to Nurses
            modelBuilder.Entity<Patient>()
               .HasMany(e => e.Nurse)
               .WithMany(e => e.Patient)
               .UsingEntity<Patient_Nurse>();
            modelBuilder.Entity<IdentityRole>().HasData(
              new IdentityRole { Name = "Receptionist", NormalizedName = "RECEPTIONIST" },
              new IdentityRole { Name = "Doctor", NormalizedName = "DOCTOR" },
              new IdentityRole { Name = "Nurse", NormalizedName = "NURSE" }
            );
            base.OnModelCreating(modelBuilder);
        }

    }
}
