using Hospital_Management_System.Domain;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

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

    }
}
