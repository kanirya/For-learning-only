using Microsoft.AspNetCore.Mvc;

namespace Learning.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        } 
     public ContentResult Not()
        {
            return Content("Hey this is danish");
        } 
   
    }
}