using CS3280AirBnBGroupProject.Models;
using CS3280AirBnBGroupProject.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CS3280AirBnBGroupProject.Services.Interfaces
{
    /// <summary>
    /// This interface contains methods meant to be implemented by a class in order to assist in retreiving specific results from the Database/repository based off of 
    /// their ID, as well as various methods to help in calculating the Cost/Fees/Charges when booking a result/location.
    /// </summary>
    public interface IResultService
    {
        #region Methods

        /// <summary>
        /// Accesses the data/repository and returns a single result/location based off of its Unique ID
        /// </summary>
        /// <param name="id">The unique Id parameter for an object</param>
        IResult GetById(int id);

        /// <summary>
        /// Calculates the number of days different between the check-in date and the check-out date.
        /// </summary>
        /// <param name="CheckInDate">The check-in date specified from the home page search criteria, after it has been altered and changed to a string</param>
        /// <param name="CheckOutDate">The check-in date specified from the home page search criteria, after it has been altered and changed to a string</param>
        /// <returns>Returns the amount of days different between the two dates in the form of an int.</returns>
        int NumberOfDays(string CheckInDate, string CheckOutDate)
        {
            return 0;
        }

        /// <summary>
        /// Calculates the cost of the booking based off of the number of days reserved. It does not include additional fees and charges.
        /// </summary>
        /// <param name="result">The result/place selected by the user from the PopulatedResults Page.</param>
        /// <param name="numberOfDays">The amount of days between the check-in date, and the check-out date.</param>
        /// <returns>Returns the location cost for the amount of days reserved in the form of a decimal.</returns>
        public decimal TotalNightlyCost(IResult result, int numberOfDays)
        {
            return 0;
        }

        /// <summary>
        /// Calculates the taxes to be applied to the booking based off of 10% of the total location cost and the cleaning and booking fees
        /// </summary>
        /// <param name="totalNightlyCost">The total location cost dependent on the nightly charge and the number of days for the booking</param>
        /// <returns>Returns the tax amount for the booking in the form of a decimal type.</returns>
        public decimal TaxesFee(decimal totalNightlyCost)
        {
            return 0;
        }

        /// <summary>
        /// Calculates the total cost of the booking after all costs/fees/taxes are applied.
        /// </summary>
        /// <param name="totalNightlyCost">The total location cost dependent on the nightly charge and the number of days for the booking</param>
        /// <param name="taxesAndFees">The taxes to be applied to the booking based off of 10% of the total location cost and the cleaning and booking fees.</param>
        /// <returns>Returns the total cost of the booking in the form of a decimal type.</returns>
        public decimal TotalCostOfBooking(decimal totalNightlyCost, decimal taxesAndFees)
        {
            return 0;
        }

        #endregion
    }
}
