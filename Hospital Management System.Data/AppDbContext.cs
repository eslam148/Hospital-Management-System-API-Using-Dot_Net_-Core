using Hospital_Management_System.Domain;
using Microsoft.EntityFrameworkCore;

namespace Hospital_Management_System.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions options):base(options)
        {
            
        }
        public DbSet<Patient> Patients { get; set; }

    }
}
