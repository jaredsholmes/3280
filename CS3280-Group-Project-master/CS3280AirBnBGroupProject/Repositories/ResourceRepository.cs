using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CS3280AirBnBGroupProject.Models;
using CS3280AirBnBGroupProject.Models.Interfaces;
using Microsoft.AspNetCore.Components;

namespace CS3280AirBnBGroupProject.Repositories
{
    /// <summary>
    /// This class contains methods which help to filter results that come from the Database/Repository
    /// </summary>
    public class ResourceRepository : IResourceRepository
    {
        #region Methods

        /// <summary>
        /// Add an array of amenities to a list<string>() to be compared against other results.
        /// </summary>
        /// <param name="amenitiesFilter">A list of amenities selected in the FilterPopUp Page, as chosen by the user.</param>
        /// <param name="amenity">A dynamically changing quanitity array of amenities in string format that will be added to the amenitiesFilter list.</param>
        public void AddFilters(IList<string> amenitiesFilter, params string[] amenity)
        {
            for (int index = 0; index < amenity.Length; index++)
            {
                if (amenity[index] != null)
                {
                    amenitiesFilter.Add(amenity[index]);
                }
            }
        }

        /// <summary>
        /// Compares the list of filters if any were selected from the FiltersPopUp Page, to the original set of results populated from the intital search criteria, 
        /// in order to narrow down results. 
        /// </summary>
        /// <param name="repositoryResults">The initial list of results from the Database/Repository based off of the initial search criteria.</param>
        /// <param name="filteredResults">The list of results based off of the initial repositoryResults after filters are applied. </param>
        /// <param name="appliedFilters">The list of filters to be applied to the results.</param>
        /// <param name="location">The city name/property for the result</param>
        public void ApplyFiltersToSearchResults(IList<IResult> repositoryResults, IList<IResult> filteredResults, List<string> appliedFilters, string location)
        {
            foreach (var result in repositoryResults)
            {
                var counter = 1;
                if (appliedFilters.Count == 0 && result.City == location)
                {
                    filteredResults.Add(result);
                }
                else
                {
                    foreach (var amenity in appliedFilters)
                    {
                        if (appliedFilters.Count != 0 && result.Amenities.Contains(amenity) && result.City == location)
                        {
                            while (counter == 1)
                            {
                                filteredResults.Add(result);
                                counter++;
                            }
                        }
                    }
                }
            }
        }

        #endregion
    }
}
