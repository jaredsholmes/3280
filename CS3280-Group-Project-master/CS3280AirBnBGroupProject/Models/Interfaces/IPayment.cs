using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;

namespace CS3280AirBnBGroupProject.Models.Interfaces
{
    /// <summary>
    /// This interface is meant to be implemented by the Payment object. It contains a number of parameters which make up the payment object (Name, CreditCardNumber, ExpirationMonth, ExpirationYear, CCV)
    /// </summary>
    public interface IPayment
    {
        #region Properties

        /// <summary>
        /// Gets and sets the name in the Payment object which is determined in the PaymentInformation Form
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets and sets the credit card number in the Payment object which is determined in the PaymentInformation Form
        /// </summary>
        public string CreditCardNumber { get; set; }

        /// <summary>
        /// Gets and sets the expiration month in the Payment object which is determined in the PaymentInformation Form
        /// </summary>
        public string ExpirationMonth { get; set; }

        /// <summary>
        /// Gets and sets the expiration year in the Payment object which is determined in the PaymentInformation Form
        /// </summary>
        public string ExpirationYear { get; set; }

        /// <summary>
        /// Gets and sets the CCV number in the Payment object which is determined in the PaymentInformation Form
        /// </summary>
        public string CCV { get; set; }

        #endregion
    }
}
