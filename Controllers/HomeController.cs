using Microsoft.AspNetCore.Mvc;

namespace ConfigurationExample.Controllers;

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
        // Get: Loads configuration values into a new object
        //  var options = _configuration.GetSection("weatherApi").Get<WeatherApiOptions>();

        // Bind: Loads configuration values into existing object
        var options = new WeatherApiOptions();
        _configuration.GetSection("weatherApi").Bind(options);

        ViewBag.ClientID = options.ClientId;
        ViewBag.ClientSecret = options.ClientSecret;
        return View();
    }
}