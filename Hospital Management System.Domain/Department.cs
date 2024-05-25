using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Management_System.Domain
{
    public class Department
    {
        public Guid id { get; set; }
        public string Name { get; set; }

        public string HospitalId { get; set; }

        public Hospital Hospitals { get; set; }
        public ICollection<Doctor> Doctors { get; set; }
    }
}
