using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;
using CS3280AirBnBGroupProject.Models;
using CS3280AirBnBGroupProject.Models.Interfaces;

namespace CS3280AirBnBGroupProject.Repositories
{
    [ExcludeFromCodeCoverage]
    /// <summary>
    /// The class is a mock repository meant to imitate the results which will be populated by the Database, and is/was for initial setup and testing.
    /// </summary>
    public class MockResultRepository : IResultRepository
    {

        public IList<IResult> Search()
        {
            return new List<IResult>
            {
                new Result
                {
                    Id = 1,
                    MainImageUrl = "/Images/image1.jpg",
                    AdditionalImageUrls = { "/Images/image1.jpg", "/Images/image2.jpg", "/Images/image3.jpg", "/Images/image4.jpg", "/Images/image5.jpg", "/Images/image6.jpg", "/Images/image7.jpg", "/Images/image8.jpg", "/Images/image9.jpg" },
                    City = "Giant's Causeway",
                    State = "Ireland",
                    Address = "123 Causeway Drive",
                    Description = "Beautiful coastside local views, walking distance away from the Giant's Causeway. With beautiful coastal views.",
                    Amenities = { "wifi", "handicap accessible", "pool", "washer-dryer" },
                    SleepingOptions = { "One Bedroom", "Two Bedroom", "Three Bedroom", "Four Bedroom" },
                    Rating = "5 star",
                    Cost = 500
                },
                new Result
                {
                    Id = 2,
                    MainImageUrl = "/Images/image2.jpg",
                    AdditionalImageUrls = { "/Images/image1.jpg", "/Images/image2.jpg", "/Images/image3.jpg", "/Images/image4.jpg", "/Images/image5.jpg", "/Images/image6.jpg", "/Images/image7.jpg", "/Images/image8.jpg", "/Images/image9.jpg" },
                    City = "Rickatick Bridge",
                    State = "Ireland",
                    Address = "123 Fatal Fall",
                    Description = "Beautiful coastside local views, walking distance away from the Giant's Causeway. With beautiful coastal views.",
                    Amenities = { "wifi", "washer-dryer" },
                    SleepingOptions = { "One Bedroom", "Two Bedroom", "Three Bedroom" },
                    Rating = "4 star",
                    Cost = 400
                },
                new Result
                {
                    Id = 3,
                    MainImageUrl = "/Images/image3.jpg",
                    AdditionalImageUrls = { "/Images/image1.jpg", "/Images/image2.jpg", "/Images/image3.jpg", "/Images/image4.jpg", "/Images/image5.jpg", "/Images/image6.jpg", "/Images/image7.jpg", "/Images/image8.jpg", "/Images/image9.jpg" },
                    City = "Salt Lake City",
                    State = "Utah",
                    Address = "123 State St.",
                    Description = "Salt Lake City is the capital and most populous municipality of the U.S. state of Utah, as well as the seat of Salt Lake County, the most populous county in Utah.",
                    Amenities = { "wifi", "handicap accessible", "washer-dryer" },
                    SleepingOptions = { "One Bedroom", "Two Bedroom" },
                    Rating = "3 star",
                    Cost = 300
                },
                new Result
                {
                    Id = 4,
                    MainImageUrl = "/Images/image4.jpg",
                    AdditionalImageUrls = { "/Images/image1.jpg", "/Images/image2.jpg", "/Images/image3.jpg", "/Images/image4.jpg", "/Images/image5.jpg", "/Images/image6.jpg", "/Images/image7.jpg", "/Images/image8.jpg", "/Images/image9.jpg" },
                    City = "Scottsdale",
                    State = "Arizona",
                    Address = "456 Main St.",
                    Description = "A city in the eastern part of Maricopa County, Arizona, United States, part of the Greater Phoenix Area. Named Scottsdale in 1894 after its founder Winfield Scott, a retired U.S. Army chaplain, the city was incorporated in 1951 with a population of 2,000. ",
                    Amenities = { "wifi", "washer-dryer" },
                    SleepingOptions = { "One Bedroom", "Two Bedroom" },
                    Rating = "1 star",
                    Cost = 100
                },
                new Result
                {
                    Id = 5,
                    MainImageUrl = "/Images/image5.jpg",
                    AdditionalImageUrls = { "/Images/image1.jpg", "/Images/image2.jpg", "/Images/image3.jpg", "/Images/image4.jpg", "/Images/image5.jpg", "/Images/image6.jpg", "/Images/image7.jpg", "/Images/image8.jpg", "/Images/image9.jpg" },
                    City = "St. George",
                    State = "Utah",
                    Address = "234 St. George Way",
                    Description = "a city in and the county seat of Washington County, Utah, United States. Located in the southwestern part of the state on the Arizona border, near the tri-state junction of Utah, Arizona and Nevada, it is the principal city of the St. George Metropolitan Statistical Area.",
                    Amenities = { "wifi", "handicap accessible", "washer-dryer" },
                    SleepingOptions = { "One Bedroom" },
                    Rating = "2 star",
                    Cost = 200
                },
                new Result
                {
                    Id = 6,
                    MainImageUrl = "/Images/image6.jpg",
                    AdditionalImageUrls = { "/Images/image1.jpg", "/Images/image2.jpg", "/Images/image3.jpg", "/Images/image4.jpg", "/Images/image5.jpg", "/Images/image6.jpg", "/Images/image7.jpg", "/Images/image8.jpg", "/Images/image9.jpg" },
                    City = "Denver",
                    State = "Colorado",
                    Address = "1st Legal Way",
                    Description = "the capital and most populous municipality of the U.S. state of Colorado. Denver is located in the South Platte River Valley on the western edge of the High Plains just east of the Front Range of the Rocky Mountains. With an estimated population of 727,211 in 2019.",
                    Amenities = { "wifi", "handicap accessible", "washer-dryer", "Pot Grown On-site" },
                    SleepingOptions = { "One Bedroom", "Two Bedroom" },
                    Rating = "4 star",
                    Cost = 400
                }
            };
        }
    }
}
