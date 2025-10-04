using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Week3App.Models;

namespace Week3App.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }
    public IActionResult Index()
    {
        ViewBag.Name = "Volkan";
        ViewData["Message"] = "We are learning ASP.NET Core!";
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    public IActionResult About()
    {
        return View();
    }

   
}
