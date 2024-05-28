using Hospital_Management_System.Domain;
using Hospital_Management_System.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Management_System.Data.TypeRepository
{
    public class LaboratoryRepository:GenericRepository<Laboratory>,ILaboratoryRepository
    {
        public LaboratoryRepository(AppDbContext context):base(context)
        {
            
        }

        public IEnumerable<Laboratory> GetLabByPatientId(string PatientId)
        {
          return  context.Laboratores.Where(l => l.PatientId.ToString() == PatientId).ToList();
        }
    }
}
