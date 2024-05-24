﻿using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Hospital_Management_System.Domain
{
    public class Patient
    {
        public Guid id { get; set; }
        public string Name { get; set; }
        public string Address  { get; set; }
        public string Phone { get; set; }
        public string Gender { get; set; }
        public decimal age { get; set; }
        public DateTime AdmitDate { get; set; }
        public DateTime Discharge { get; set; }
        public string PatientType { get; set; }

    }
}