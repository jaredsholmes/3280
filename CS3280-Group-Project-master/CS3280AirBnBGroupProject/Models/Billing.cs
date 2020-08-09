using CS3280AirBnBGroupProject.Models;
using CS3280AirBnBGroupProject.Models.Interfaces;
using System;
using System.ComponentModel.DataAnnotations;


namespace CS3280AirBnBGroupProject.Models
{
    public class Billing : IBilling
    {
        #region Properties
        [Required(ErrorMessage = "First name is required")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last name is required")]
        public string LastName { get; set; }

        [Required(ErrorMessage ="An emergency contact name is required")]
        public string EmergencyContact { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        [EmailAddress(ErrorMessage = "Please enter a valid email address")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Address is required")]
        public string Address { get; set; }

        [Required(ErrorMessage = "City is required")]
        public string City { get; set; }

        [Required(ErrorMessage = "State is required")]
        [MinLength(2, ErrorMessage = "Value must be 2 letters")]
        [MaxLength(2, ErrorMessage = "Value must be 2 letters")]
        public string State { get; set; }

        [Required(ErrorMessage = "Zipcode is required")]
        [MinLength(5, ErrorMessage = "Valid zipcodes have 5 digits")]
        [MaxLength(5, ErrorMessage = "Valid zipcodes have 5 digits")]
        public string Zipcode { get; set; }

        public Payment Payment { get; set; } = new Payment();

        #endregion
    }
}
