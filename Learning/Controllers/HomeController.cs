using Microsoft.AspNetCore.Mvc;

namespace Learning.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        } 
        public IActionResult Category()
        {
            return View();
        } 
    
   
    }
}