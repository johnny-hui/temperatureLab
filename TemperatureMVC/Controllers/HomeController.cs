using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Temperature;
using TemperatureMVC.Models;

namespace TemperatureMVC.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index(string from, string to, double value) {
        Conversion conv = new Conversion();
        Conversion.ConversionMode md = conv.GetConversionMode(from,to);
        ViewData["output"] = conv.Convert(md, value);
        ViewData["input"] = value;
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
