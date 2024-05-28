using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Management_System.Domain
{
    public class Diagnoses
    {
        public Guid id { get; set; }
        public string info { get; set; }
        public DateTime DateTime { get; set; }

        public Guid PatientId { get; set; }
        public virtual Patient Patients { get; set; }
    }
}
