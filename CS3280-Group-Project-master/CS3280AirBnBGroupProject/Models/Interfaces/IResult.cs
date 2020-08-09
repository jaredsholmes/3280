using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;

namespace CS3280AirBnBGroupProject.Models.Interfaces
{
    /// <summary>
    /// This inteface is meant to be implemented by a class to serve as a blueprint for the Result object which contains a number of parameters(Id, Cost, MainImageUrl, 
    /// City, State, Address, Description, Amenities, SleepingOptions, and Rating) which make up a Result object and implements the IResult interface.
    /// </summary>
    public interface IResult
    {
        #region Parameters

        /// <summary>
        /// The unique Id of the result/location
        /// </summary>
        int Id { get; set; }

        /// <summary>
        /// The nightly charge/cost of the result/location
        /// </summary>
        decimal Cost { get; set; }

        /// <summary>
        /// The main image URL for the result/location
        /// </summary>
        string MainImageUrl { get; set; }

        /// <summary>
        /// Additional image urls for the result/location and surrounding areas
        /// </summary>
        public IList<string> AdditionalImageUrls { get; set; }

        /// <summary>
        /// The name of the city that the result/location is located
        /// </summary>
        string City { get; set; }

        /// <summary>
        /// The name of the state that the result/location is located
        /// </summary>
        string State { get; set; }

        /// <summary>
        /// The street address that the result/location is located
        /// </summary>
        string Address { get; set; }

        /// <summary>
        /// The brief description of the result/location and/or the surrounding area
        /// </summary>
        string Description { get; set; }

        /// <summary>
        /// The current rating of the result/location
        /// </summary>
        string Rating { get; set; }

        /// <summary>
        /// A list of Amenities available at the result/location
        /// </summary>
        public IList<string> Amenities { get; set; }

        /// <summary>
        /// A list of Sleeping Options available at the result/location
        /// </summary>
        public IList<string> SleepingOptions { get; set; }

        #endregion
    }
}
