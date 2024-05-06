using Microsoft.AspNetCore.Mvc;

namespace StatiAuthenticator.Controllers
{
    //rout to index 
    [Route("/")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            // return empty page with text 
            return Content("Hello, World!");

        }
    }
}
