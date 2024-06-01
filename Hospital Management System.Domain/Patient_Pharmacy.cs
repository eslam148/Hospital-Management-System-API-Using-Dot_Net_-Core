using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Management_System.Domain
{
    public class Patient_Pharmacy
    {
        //public Guid id { get; set; }

        public Guid PatientId { get; set; }
        public Guid PharmacyId { get; set; }

        public decimal Amount { get; set; }
        public string info { get; set; }

        //public Patient Patients { get; set; }
        //public Pharmacy Pharmacy { get; set; }

    }
}
