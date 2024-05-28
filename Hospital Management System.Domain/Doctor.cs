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


       public virtual Department Departments { get; set; }
       public virtual ICollection<Patient> Patients { get; set; }

    }
}
