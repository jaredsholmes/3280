using CS3280AirBnBGroupProject.Models;
using CS3280AirBnBGroupProject.Models.Interfaces;
using System;
using System.ComponentModel.DataAnnotations;


namespace CS3280AirBnBGroupProject.Models
{
    /// <summary>
    /// This class serves as the blueprint for the Billing object. It contains a number of parameters that make up the Billing object (FirstName, LastName, EmergencyContact, Email, Address, City, State, Zipcode, and a Payment object)
    /// </summary>
    public class Billing : IBilling
    {
        #region Properties

        /// <summary>
        /// Gets and sets the first name in the Billing object which is determined in the BillingInformation Form
        /// </summary>
        [Required(ErrorMessage = "First name is required")]
        public string FirstName { get; set; }

        /// <summary>
        /// Gets and sets the last name in the Billing object which is determined in the BillingInformation Form
        /// </summary>
        [Required(ErrorMessage = "Last name is required")]
        public string LastName { get; set; }

        /// <summary>
        /// Gets and sets the emergency contact in the Billing object which is determined in the BillingInformation Form
        /// </summary>
        [Required(ErrorMessage ="An emergency contact name is required")]
        public string EmergencyContact { get; set; }

        /// <summary>
        /// Gets and sets the email address in the Billing object which is determined in the BillingInformation Form
        /// </summary>
        [Required]
        [DataType(DataType.EmailAddress)]
        [EmailAddress(ErrorMessage = "Please enter a valid email address")]
        public string Email { get; set; }

        /// <summary>
        /// Gets and sets the address in the Billing object which is determined in the BillingInformation Form
        /// </summary>
        [Required(ErrorMessage = "Address is required")]
        public string Address { get; set; }

        /// <summary>
        /// Gets and sets the city in the Billing object which is determined in the BillingInformation Form
        /// </summary>
        [Required(ErrorMessage = "City is required")]
        public string City { get; set; }

        /// <summary>
        /// Gets and sets the state in the Billing object which is determined in the BillingInformation Form
        /// </summary>
        [Required(ErrorMessage = "State is required")]
        [MinLength(2, ErrorMessage = "Value must be 2 letters")]
        [MaxLength(2, ErrorMessage = "Value must be 2 letters")]
        public string State { get; set; }

        /// <summary>
        /// Gets and sets the zipcode in the Billing object which is determined in the BillingInformation Form
        /// </summary>
        [Required(ErrorMessage = "Zipcode is required")]
        [MinLength(5, ErrorMessage = "Valid zipcodes have 5 digits")]
        [MaxLength(5, ErrorMessage = "Valid zipcodes have 5 digits")]
        public string Zipcode { get; set; }

        #endregion
    }
}
