using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;

namespace CS3280AirBnBGroupProject.Controllers
{
    [ExcludeFromCodeCoverage]
    public class SearchResultController
    {
        public int ID { get; set; }

        public string Location { get; set; }

        public int NumAdults { get; set; }

        public int NumChild { get; set; }

        public int NumInfant { get; set; }

        /// <summary>  
        /// Get date for checkin  
        /// </summary>  
        public DateTime? InDateRequested { get; set; }

        /// <summary>  
        /// Get date for checkout     
        /// </summary>  
         public DateTime? OutDateRequested { get; set; }        
    }
}
