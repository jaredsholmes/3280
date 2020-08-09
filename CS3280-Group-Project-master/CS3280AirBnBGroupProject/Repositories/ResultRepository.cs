using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;
using CS3280AirBnBGroupProject.Models;

namespace CS3280AirBnBGroupProject.Repositories
{
    [ExcludeFromCodeCoverage]
    public class ResultRepository : IResultRepository
    {
        public IList<Result> Search(object criteria)
        {
            //Bens Repository for DB
            return null;
        }
    }
}
