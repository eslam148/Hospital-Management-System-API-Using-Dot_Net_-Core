using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Management_System.Domain.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IPatientRepository Patient
        {
            get;
        }
        IHospitalRepository Hospital
        {
            get;
        }
        IDepartmentRepository Department
        {
            get;
        }
        ILaboratoryRepository Laboratory { get; }
        IDoctorRepository Doctor { get; }
        IPharmacyRepository Pharmacy { get; }
        IDiagnosesRepository Doiagnoses { get; }

        int Save();
    }
}
