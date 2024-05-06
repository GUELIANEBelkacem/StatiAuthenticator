using Microsoft.AspNetCore.Mvc;

namespace StatiAuthenticator.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            return Redirect("portwin:/callback");
        }
    }
}
