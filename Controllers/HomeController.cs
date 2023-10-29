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
        //  ViewBag.ClientID = _configuration["weatherapi:ClientID"];
        //  ViewBag.ClientSecret = _configuration.GetValue("weatherapi:ClientSecret", "The default client secret");

        var weatherapiSection = _configuration.GetSection("weatherapi");
        ViewBag.ClientID = weatherapiSection["ClientID"];
        ViewBag.ClientSecret = weatherapiSection["ClientSecret"];
        return View();
    }
}