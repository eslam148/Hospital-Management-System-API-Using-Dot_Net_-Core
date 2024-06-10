using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Management_System.Domain
{
    public class Room
    {
        public int Id { get; set; }
        public int RoomNumber { get; set;}
        public string Location { get; set; }
        public int HospitalId { get; set; }
        public bool IsAvailable { get; set; } = true;
        public virtual ICollection<Patient> Patients { get; set; }
        public virtual Hospital Hospitals { get; set; }

    }
}
