using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Management_System.Domain
{
    public class Nurse: Employee
    {
        public virtual ICollection<Patient> Patient { get; set; }

    }
}
