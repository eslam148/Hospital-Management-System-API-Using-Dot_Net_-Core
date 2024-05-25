using Hospital_Management_System.Domain;
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
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Nurse> Nurses { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Laboratory> Laboratores { get; set; }
        public DbSet<Pharmacy> Pharmaces { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Hospital> Hospitals { get; set; }
        public DbSet<Diagnoses> Diagnoses { get; set; }
        public DbSet<Patient_Pharmacy> Patient_Pharmacy { get; set; }
        public DbSet<Patient_Nurse> Patient_Nurse { get; set; }
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
                .WithOne(d => d.Hospitals);

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
            base.OnModelCreating(modelBuilder);
        }

    }
}
