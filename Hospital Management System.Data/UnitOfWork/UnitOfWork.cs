using Hospital_Management_System.Data.TypeRepository;
 using Hospital_Management_System.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Management_System.Data.UnitOfWork
{
    public class UnitOfWork:IUnitOfWork {
    private AppDbContext context;
    public UnitOfWork(AppDbContext context) {
        this.context = context;
        Patient = new PatientRepository(this.context);
        Hospital = new HospitalRepository(this.context);
        Department = new DepartmentRepository(this.context);
        Laboratory = new LaboratoryRepository(this.context);
        Doctor = new DoctorRepository(this.context);
        Pharmacy = new PharmacyRepository(this.context);

        Doiagnoses = new DiagnosesRepository(this.context);
        Patient_Pharmacy = new Patient_PharmacyRepository(this.context);
        Room = new RoomRepository(this.context);



        }
        public IPatientRepository Patient {
        get;
        private set;
    }
    public IHospitalRepository Hospital
    {
        get;
        private set;
    }
    public IDepartmentRepository Department { get; private set; }

    public ILaboratoryRepository Laboratory { get; private set; }
    public IDoctorRepository Doctor { get; private set; }
    public IPharmacyRepository Pharmacy { get; private set; }
    public IDiagnosesRepository Doiagnoses { get; private set; }
    public IPatient_PharmacyRepository Patient_Pharmacy { get; private set; }
    public IRoomRepository Room { get; private set; }

        public void Dispose() {
        context.Dispose();
    }
    public int Save() {
        return context.SaveChanges();
    }
}
}
