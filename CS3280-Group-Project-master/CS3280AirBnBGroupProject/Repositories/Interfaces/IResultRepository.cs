using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CS3280AirBnBGroupProject.Models;

namespace CS3280AirBnBGroupProject.Repositories
{
    /// <summary>
    /// The interface is intended to be implemented by a class in order to assist in getting the results from a Database.
    /// </summary>
    interface IResultRepository
    {
        /// <summary>
        /// This returns a list of manually initialized results, meant to imitate the query results from a database.
        /// </summary>
        /// <returns>Returns a list of results/locations.</returns>
        IList<Result> GetResults()
        {
            return null;
        }
    }
}
