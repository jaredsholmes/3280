using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;

namespace CS3280AirBnBGroupProject.Models.Interfaces
{
    /// <summary>
    /// This interface is meant to be implemented by the Billing object. It contains a number of parameters which make up the Billing object (FirstName, LastName, EmergencyContact, Email, Address, City, State, Zipcode, and a Payment object)
    /// </summary>
    public interface IBilling
    {
        #region Properties

        /// <summary>
        /// Gets and sets the first name in the Billing object which is determined in the BillingInformation Form
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Gets and sets the last name in the Billing object which is determined in the BillingInformation Form
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Gets and sets the emergency contact in the Billing object which is determined in the BillingInformation Form
        /// </summary>
        public string EmergencyContact { get; set; }

        /// <summary>
        /// Gets and sets the email address in the Billing object which is determined in the BillingInformation Form
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Gets and sets the address in the Billing object which is determined in the BillingInformation Form
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// Gets and sets the city in the Billing object which is determined in the BillingInformation Form
        /// </summary>
        public string City { get; set; }

        /// <summary>
        /// Gets and sets the state in the Billing object which is determined in the BillingInformation Form
        /// </summary>
        public string State { get; set; }

        /// <summary>
        /// Gets and sets the zipcode in the Billing object which is determined in the BillingInformation Form
        /// </summary>
        public string Zipcode { get; set; }

        #endregion
    }
}
