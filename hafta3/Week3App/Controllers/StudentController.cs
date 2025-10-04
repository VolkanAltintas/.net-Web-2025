using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Week3App.Models;

namespace Week3App.Controllers;

public class StudentController : Controller
{
    private readonly ILogger<StudentController> _logger;

    public StudentController(ILogger<StudentController> logger)
    {
        _logger = logger;
    }
    public IActionResult Index()
    {
        return View();
    }


   
}