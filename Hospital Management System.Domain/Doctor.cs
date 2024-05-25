using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Management_System.Domain
{
    public class Doctor: Employee
    {
       public string Specialization { get; set; }
       public Guid departmentId{ get; set; }


       public Department Departments { get; set; }
       public ICollection<Patient> Patients { get; set; }

    }
}
