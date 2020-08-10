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
    /// <summary>
    /// This class serves as a blueprint for the Payment object. It contains a number of parameters which make up the Payment object (Name, CreditCardNumber, ExpirationMonth, ExpirationYear, CCV)
    /// </summary>
    [ExcludeFromCodeCoverage]
    public class Payment : IPayment
    {
        #region Properties
        /// <summary>
        /// Gets and sets the name in the Payment object which is determined in the PaymentInformation Form. It also contains an attribute that requires the Name to be present
        /// </summary>
        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }

        /// <summary>
        /// Gets and sets the credit card number in the Payment object which is determined in the PaymentInformation Form. It also contains attributes that require a credit card number to be present and valid
        /// </summary>
        [Required(ErrorMessage = "Credit card number is required")]
        [DataType(DataType.CreditCard)]
        [CreditCard(ErrorMessage = "Invalid credit card number")]
        public string CreditCardNumber { get; set; }

        /// <summary>
        /// Gets and sets the expiration month in the Payment object which is determined in the PaymentInformation Form. It also contains attributes that require a month to be present and not longer than two digits. It also requires it to be a valid month
        /// </summary>
        [Required(ErrorMessage = "Expiration month is required")]
        [MinLength(2, ErrorMessage = "Value must be 2 digits")]
        [MaxLength(2, ErrorMessage = "Value must be 2 digits")]
        [Range(01, 12, ErrorMessage = "Value must be a valid month")]
        public string ExpirationMonth { get; set; }

        /// <summary>
        /// Gets and sets the expiration year in the Payment object which is determined in the PaymentInformation Form. It also contains attributes that require a year to be present and not longer than two digits. It also requires it to be up to 3 years out
        /// </summary>
        [Required(ErrorMessage = "Expiration year is required")]
        [MinLength(2, ErrorMessage = "Value must be 2 digits")]
        [MaxLength(2, ErrorMessage = "Value must be 2 digits")]
        [Range(20, 23, ErrorMessage = "Value must be a valid year")]
        public string ExpirationYear { get; set; }

        /// <summary>
        /// Gets and sets the CCV number in the Payment object which is determined in the PaymentInformation Form. It also contains attributes that require the CCV to be present and 3 digits. Also validates it must be between 000-999.
        /// </summary>
        [Required(ErrorMessage = "CCV number is required")]
        [MinLength(3, ErrorMessage = "Value must be 3 digits")]
        [MaxLength(3, ErrorMessage = "Value must be 3 digits")]
        [Range(000, 999, ErrorMessage = "Must be a valid CVV number")]
        public string CCV { get; set; }

        #endregion
    }
}
