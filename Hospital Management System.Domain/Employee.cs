using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Management_System.Domain
{
    public enum Gender{
        Male,
        Female
    }
    public class Employee : IdentityUser
    {
        
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public decimal Age { get; set; }
        public Gender Gender { get; set; }
        public DateTime DateOfBith { get; set; }
        public string Address { get; set; }

    }
}
