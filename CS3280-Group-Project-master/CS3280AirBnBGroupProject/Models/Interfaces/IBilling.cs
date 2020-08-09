using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;

namespace CS3280AirBnBGroupProject.Models.Interfaces
{
    public interface IBilling
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmergencyContact { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zipcode { get; set; }
        public Payment Payment { get; set; }
    }
}
