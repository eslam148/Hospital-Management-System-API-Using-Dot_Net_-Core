using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Management_System.Domain
{
    public class Laboratory
    {
        public Guid id { get; set; }
        public string name { get; set; }
        public string NormalRang { get; set; }
        public string result { get; set; }

        public Guid PatientId { get; set; }
        public Patient Patients { get; set; }

    }
}
