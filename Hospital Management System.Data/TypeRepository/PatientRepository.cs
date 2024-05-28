using Hospital_Management_System.Domain;
using Hospital_Management_System.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Management_System.Data.TypeRepository
{
    public class PatientRepository : GenericRepository<Patient>, IPatientRepository
    {
        public PatientRepository(AppDbContext context) : base(context) { }

        public IEnumerable<Patient> GetAdultPatients()
        {
            return context.Patients.Where(p => p.age >= 18).ToList();
        }
    }
}
