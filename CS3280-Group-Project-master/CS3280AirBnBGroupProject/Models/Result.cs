using CS3280AirBnBGroupProject.Models;
using CS3280AirBnBGroupProject.Models.Interfaces;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Drawing;

namespace CS3280AirBnBGroupProject.Models
{
    /// <summary>
    /// This class is the blueprint for Result object which contains a number of parameters(Id, Cost, MainImageUrl, City, 
    /// State, Address, Description, Amenities, SleepingOptions, and Rating) which make up a Result object and implements the IResult interface.
    /// </summary>
    public class Result : IResult
    {
        #region Parameters

        /// <summary>
        /// The unique Id of the result/location
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// The nightly charge/cost of the result/location
        /// </summary>
        public decimal Cost { get; set; }

        /// <summary>
        /// The main image URL for the result/location
        /// </summary>
        public string MainImageUrl { get; set; }

        /// <summary>
        /// Additional image urls for the result/location and surrounding areas
        /// </summary>
        public IList<string> AdditionalImageUrls { get; set; } = new List<string>();

        /// <summary>
        /// The name of the city that the result/location is located
        /// </summary>
        public string City { get; set; }

        /// <summary>
        /// The name of the state that the result/location is located
        /// </summary>
        public string State { get; set; }

        /// <summary>
        /// The street address that the result/location is located
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// The brief description of the result/location and/or the surrounding area
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// The current rating of the result/location
        /// </summary>
        public string Rating { get; set; }

        /// <summary>
        /// A list of Amenities available at the result/location
        /// </summary>
        public IList<string> Amenities { get; set; } = new List<string>();

        /// <summary>
        /// A list of Sleeping Options available at the result/location
        /// </summary>
        public IList<string> SleepingOptions { get; set; } = new List<string>();

        #endregion
    }
}