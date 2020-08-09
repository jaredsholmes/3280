using CS3280AirBnBGroupProject.Models;
using CS3280AirBnBGroupProject.Models.Interfaces;
using CS3280AirBnBGroupProject.Repositories;
using CS3280AirBnBGroupProject.Services;
using CS3280AirBnBGroupProject.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Security.Cryptography.X509Certificates;
using Unity;
using Xunit;

namespace DanielsTests
{
    [ExcludeFromCodeCoverage]
    public class DanielsTests
    {
        [Theory]
        [MemberData(nameof(GetByIdData))]
        public void GetById_VariousIdInputted_ReturnsValid(int id, string city, string state, string address, int cost, string description, string rating, string mainImageUrl, List<string> amenities, List<string> sleepingOption, List<string> additionalImageUrls)
        {
            var container = new UnityContainer();
            container.RegisterType<IResultService, ResultService>();
            var sut = container.Resolve<ResultService>();

            var expectedResult = new Result
            {
                Id = id,
                City = city,
                State = state,
                Address = address,
                Cost = cost,
                Description = description,
                Rating = rating,
                MainImageUrl = mainImageUrl,
                Amenities = amenities,
                SleepingOptions = sleepingOption,
                AdditionalImageUrls = additionalImageUrls
            };

            var actual = sut;

            Assert.Equal(sut.GetById(id).Id, expectedResult.Id);
            Assert.Equal(sut.GetById(id).City, expectedResult.City);
            Assert.Equal(sut.GetById(id).State, expectedResult.State);
            Assert.Equal(sut.GetById(id).Address, expectedResult.Address);
            Assert.Equal(sut.GetById(id).Cost, expectedResult.Cost);
            Assert.Equal(sut.GetById(id).Description, expectedResult.Description);
            Assert.Equal(sut.GetById(id).Rating, expectedResult.Rating);
            Assert.Equal(sut.GetById(id).MainImageUrl, expectedResult.MainImageUrl);
            Assert.Equal(sut.GetById(id).Amenities, expectedResult.Amenities);
            Assert.Equal(sut.GetById(id).SleepingOptions, expectedResult.SleepingOptions);
            Assert.Equal(sut.GetById(id).AdditionalImageUrls, expectedResult.AdditionalImageUrls);
        }

        public static IEnumerable<object[]> GetByIdData => new List<object[]>
        {
           new object[] { 1, "Giant's Causeway", "Ireland", "123 Causeway Drive", 500,  "Beautiful coastside local views, walking distance away from the Giant's Causeway. With beautiful coastal views.",  "5 star", "/Images/image1.jpg", new List<string>{ "wifi", "handicap accessible", "pool", "washer-dryer" }, new List<string>{ "One Bedroom", "Two Bedroom", "Three Bedroom", "Four Bedroom" }, new List<string>{ "/Images/image1.jpg", "/Images/image2.jpg", "/Images/image3.jpg", "/Images/image4.jpg", "/Images/image5.jpg", "/Images/image6.jpg", "/Images/image7.jpg", "/Images/image8.jpg", "/Images/image9.jpg" }},
           new object[] { 2, "Rickatick Bridge", "Ireland", "123 Fatal Fall", 400, "Beautiful coastside local views, walking distance away from the Giant's Causeway. With beautiful coastal views.", "4 star", "/Images/image2.jpg", new List<string> { "wifi", "washer-dryer" }, new List<string> { "One Bedroom", "Two Bedroom", "Three Bedroom" },  new List<string>{ "/Images/image1.jpg", "/Images/image2.jpg", "/Images/image3.jpg", "/Images/image4.jpg", "/Images/image5.jpg", "/Images/image6.jpg", "/Images/image7.jpg", "/Images/image8.jpg", "/Images/image9.jpg" }},
           new object[] { 3, "Salt Lake City", "Utah", "123 State St.", 300, "Salt Lake City is the capital and most populous municipality of the U.S. state of Utah, as well as the seat of Salt Lake County, the most populous county in Utah.", "3 star", "/Images/image3.jpg", new List<string> { "wifi", "handicap accessible", "washer-dryer" }, new List<string> { "One Bedroom", "Two Bedroom" }, new List<string> { "/Images/image1.jpg", "/Images/image2.jpg", "/Images/image3.jpg", "/Images/image4.jpg", "/Images/image5.jpg", "/Images/image6.jpg", "/Images/image7.jpg", "/Images/image8.jpg", "/Images/image9.jpg" }}
         };

        [Theory]
        [MemberData(nameof(NumberOfDaysData))]
        public void NumberOfDays_VariousValuesInputted_ReturnsValid(DateTime checkIn, DateTime checkOut, int expectedResult)
        {
            var container = new UnityContainer();
            container.RegisterType<IResultService, ResultService>();
            var sut = container.Resolve<ResultService>();

            Assert.Equal(sut.NumberOfDays(checkIn.ToString(), checkOut.ToString()), expectedResult);
        }
        public static IEnumerable<object[]> NumberOfDaysData => new List<object[]>
        {
            new object[] {DateTime.Today, DateTime.Today.AddDays(1), 1 },
            new object[] { DateTime.Today, DateTime.Today.AddDays(2), 2 },
            new object[] { DateTime.Today, DateTime.Today.AddDays(5), 5 },
            new object[] { DateTime.Today, DateTime.Today.AddDays(10), 10 }
        };

        [Theory]
        [MemberData(nameof(TotalNightlyCostData))]
        public void TotalNightlyCost_VariousValuesInputted_ReturnsValid(Result result, int numberOfDays, decimal expectedResult)
        {
            var container = new UnityContainer();
            container.RegisterType<IResultService, ResultService>();
            var sut = container.Resolve<ResultService>();

            Assert.Equal(sut.TotalNightlyCost(result, numberOfDays), expectedResult);
        }
        public static IEnumerable<object[]> TotalNightlyCostData => new List<object[]>
        {
            new object[] { new Result {Cost= 100 }, 1, 100 },
            new object[] { new Result {Cost= 200 }, 5, 1000 },
            new object[] { new Result {Cost= 300 }, 4, 1200 },
            new object[] { new Result { Cost = 500 }, 10, 5000 }
        };

        [Theory]
        [MemberData(nameof(TaxesFeeData))]
        public void TaxesFee_VariousValuesInputted_ReturnsValid(decimal totalCost, decimal expectedResult)
        {
            var container = new UnityContainer();
            container.RegisterType<IResultService, ResultService>();
            var sut = container.Resolve<ResultService>();

            Assert.Equal(sut.TaxesFee(totalCost), expectedResult);
        }
        public static IEnumerable<object[]> TaxesFeeData => new List<object[]>
        {
            new object[] { 1000, 125 },
            new object[] { 500, 75 },
            new object[] { 120, 37},
            new object[] { 123, 37.3 }
        };

        [Theory]
        [MemberData(nameof(TotalCostOfBookingData))]
        public void TotalCostOfBooking_VariousValuesInputted_ReturnsValid(decimal totalNightlyCost, decimal taxesAndFees, decimal expectedResult)
        {
            var container = new UnityContainer();
            container.RegisterType<IResultService, ResultService>();
            var sut = container.Resolve<ResultService>();

            Assert.Equal(sut.TotalCostOfBooking(totalNightlyCost, taxesAndFees), expectedResult);
        }
        public static IEnumerable<object[]> TotalCostOfBookingData => new List<object[]>
        {
            new object[] { 1000, 125, 1375 },
            new object[] { 500, 75, 825},
            new object[] { 120, 37, 407},
            new object[] { 123, 37.3, 410.3}
        };

        [Theory]
        [MemberData(nameof(AmenitiesData))]
        public void Amenities_VariousValuesInputted_ReturnsValid(bool wifi, bool handicap, bool washerDryer, bool pool, Amenities expectedResult)
        {
            var sut = new Amenities();
            sut.Wifi = wifi;
            sut.Handicap = handicap;
            sut.WasherDryer = washerDryer;
            sut.Pool = pool;

            Assert.Equal(sut.Wifi, expectedResult.Wifi);
            Assert.Equal(sut.Handicap, expectedResult.Handicap);
            Assert.Equal(sut.WasherDryer, expectedResult.WasherDryer);
            Assert.Equal(sut.Pool, expectedResult.Pool);
        }
        public static IEnumerable<object[]> AmenitiesData => new List<object[]>
        {
            new object[] { true, true, true, true, new Amenities { Wifi = true, Handicap = true, WasherDryer= true, Pool = true} },
            new object[] {  false, false, false, false, new Amenities { Wifi = false, Handicap = false, WasherDryer= false, Pool = false } },
            new object[] {  true, false, true, false, new Amenities { Wifi = true, Handicap = false, WasherDryer= true, Pool = false } },
            new object[] { false, true, false, true, new Amenities { Wifi = false, Handicap = true, WasherDryer = false, Pool = true } }
        };

        [Theory]
        [MemberData(nameof(AddFiltersData))]
        public void AddFilters_VariousValuesInputted_ReturnsValid(string[] amenities, int expectedResult)
        {
            var container = new UnityContainer();
            container.RegisterType<IResourceRepository, ResourceRepository>();
            var sut = container.Resolve<ResourceRepository>();
            var amenitiesFilters = new List<string>();

            sut.AddFilters(amenitiesFilters, amenities);

            Assert.Equal(amenitiesFilters.Count, expectedResult);
        }
        public static IEnumerable<object[]> AddFiltersData => new List<object[]>
        {
            new object[] { new string[2] { "wifi", "handicap accessible" }, 2 },
            new object[] {  new string[1] { "wifi" }, 1 },
            new object[] {  new string[3] { "wifi", "handicap accessible", "washer-dryer" }, 3 },
            new object[] {  new string[4] { "wifi", "handicap accessible", "washer-dryer", "pool" }, 4 }
        };

        [Theory]
        [MemberData(nameof(ApplyFiltersData))]
        public void ApplyFilters_VariousValuesInputted_ReturnsValid(List<IResult> repositoryResults, List<string> appliedFilters, string location, int expectedResult)
        {
            var container = new UnityContainer();
            container.RegisterType<IResourceRepository, ResourceRepository>();
            var sut = container.Resolve<ResourceRepository>();
            var filteredResults = new List<IResult>();

            sut.ApplyFiltersToSearchResults(repositoryResults, filteredResults, appliedFilters, location);

            Assert.Equal(filteredResults.Count, expectedResult);
        }
        public static IEnumerable<object[]> ApplyFiltersData => new List<object[]>
        {
            new object[] { new List<IResult>
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
                } }, 
                new List<string>{"wifi" }, 
                "RickaTick Bridge",
                0 },
            new object[] {  new List<IResult>
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
                    Amenities = { "wifi", "handicap accessible", "washer-dryer" },
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
                } },
                new List<string>{"pool"},
                "RickaTick Bridge",
                0 },
            new object[] {  new List<IResult>
            {
                new Result
                {
                    Id = 1,
                    MainImageUrl = "/Images/image1.jpg",
                    AdditionalImageUrls = { "/Images/image1.jpg", "/Images/image2.jpg", "/Images/image3.jpg", "/Images/image4.jpg", "/Images/image5.jpg", "/Images/image6.jpg", "/Images/image7.jpg", "/Images/image8.jpg", "/Images/image9.jpg" },
                    City = "RickaTick Bridge",
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
                } },
                new List<string>{"wifi", "washer-dryer" },
                "RickaTick Bridge",
                1 },
            new object[] {  new List<IResult>
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
                } },
                new List<string>{"wifi" },
                "Giant's Causeway",
                1 }
        };
    }
}
