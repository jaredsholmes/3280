using CS3280AirBnBGroupProject.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using CS3280AirBnBGroupProject.Models.Interfaces;

namespace CS3280AirBnBGroupProject.Models
{
    [ExcludeFromCodeCoverage]
    public class Payment : IPayment
    {
        #region Properties

        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Credit card number is required")]
        [DataType(DataType.CreditCard)]
        [CreditCard(ErrorMessage = "Invalid credit card number")]
        public string CreditCardNumber { get; set; }

        [Required(ErrorMessage = "Expiration month is required")]
        [MinLength(2, ErrorMessage = "Value must be 2 digits")]
        [MaxLength(2, ErrorMessage = "Value must be 2 digits")]
        [Range(01, 12, ErrorMessage = "Value must be a valid month")]
        public string ExpirationMonth { get; set; }

        [Required(ErrorMessage = "Expiration year is required")]
        [MinLength(2, ErrorMessage = "Value must be 2 digits")]
        [MaxLength(2, ErrorMessage = "Value must be 2 digits")]
        [Range(20, 23, ErrorMessage = "Value must be a valid year")]
        public string ExpirationYear { get; set; }

        [Required(ErrorMessage = "CCV number is required")]
        [MinLength(3, ErrorMessage = "Value must be 3 digits")]
        [MaxLength(3, ErrorMessage = "Value must be 3 digits")]
        [Range(000, 999, ErrorMessage = "Must be a valid CVV number")]
        public string CCV { get; set; }

        #endregion
    }
}
