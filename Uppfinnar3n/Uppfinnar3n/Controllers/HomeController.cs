using Microsoft.AspNetCore.Mvc;
using Uppfinnar3n.Models;
using Uppfinnar3n.ViewModels;

namespace Uppfinnar3n.Controllers
{
   
    public class HomeController : Controller
    {
        

       
        public IActionResult Index()
        {
            
            return View();
        }
    }
}
