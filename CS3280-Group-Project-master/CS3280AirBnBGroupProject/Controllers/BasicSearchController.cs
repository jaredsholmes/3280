using Microsoft.AspNetCore.Mvc;
using System.Diagnostics.CodeAnalysis;

namespace CS3280AirBnBGroupProject.Controllers
{
    [ExcludeFromCodeCoverage]
    public class BasicSearchController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }

    
}
