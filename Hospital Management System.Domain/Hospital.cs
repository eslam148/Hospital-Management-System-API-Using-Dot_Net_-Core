using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Management_System.Domain
{
    public class Hospital
    {
        public int id { get; set; }
        public string Name { get; set; }
        public int numberOfFloor { get; set; }

        public ICollection<Department> Departments { get; set; }
        public ICollection<Room> Rooms { get; set; }

    }
}
