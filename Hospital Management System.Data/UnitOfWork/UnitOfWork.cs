using Hospital_Management_System.Data.TypeReposittory;
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
    }
    public IPatientRepository Patient {
        get;
        private set;
    }
    
    public void Dispose() {
        context.Dispose();
    }
    public int Save() {
        return context.SaveChanges();
    }
}
}
