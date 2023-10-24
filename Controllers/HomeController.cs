using Microsoft.AspNetCore.Mvc;

namespace ConfigurationExample.Controllers
{
    [Route("/")]
    public class HomeController : Controller
    {
        private readonly IConfiguration _configuration;

        public HomeController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public IActionResult Index()
        {
            ViewBag.MyKey = _configuration["MyKey"];
            ViewBag.MyAPIKey = _configuration.GetValue("MyAPIKey", "The default key");
            return View();
        }
    }
}