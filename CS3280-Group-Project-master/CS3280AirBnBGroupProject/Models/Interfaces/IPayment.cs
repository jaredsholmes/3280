using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;

namespace CS3280AirBnBGroupProject.Models.Interfaces
{
    public interface IPayment
    {
        public string Name { get; set; }
        public string CreditCardNumber { get; set; }
        public string ExpirationMonth { get; set; }
        public string ExpirationYear { get; set; }
        public string CCV { get; set; }
    }
}
