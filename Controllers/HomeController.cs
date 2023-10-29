using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace ConfigurationExample.Controllers;

[Route("/")]
public class HomeController : Controller
{
    private readonly WeatherApiOptions _options;

    public HomeController(IOptions<WeatherApiOptions> weatherApiOptions)
    {
        _options = weatherApiOptions.Value;
    }

    public IActionResult Index()
    {
        ViewBag.ClientID = _options.ClientId;
        ViewBag.ClientSecret = _options.ClientSecret;
        return View();
    }
}