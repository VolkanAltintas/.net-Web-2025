using Microsoft.AspNetCore.Mvc;
using Week4App.Models;

namespace Week4App.Controllers;

public class StudentController : Controller
{
    private static readonly List<StudentModel> _students = new();

    [HttpGet]
    public IActionResult Register()
    {
        return View(new StudentModel { EnrollDate = DateTime.Today });
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Register(StudentModel model)
    {
        if (!ModelState.IsValid) return View(model);

        _students.Add(model); // demo: kalıcı değil
        TempData["Success"] = $"Registration saved for {model.Name}.";
        return RedirectToAction(nameof(List));
    }

    public IActionResult List()
    {
        ViewBag.Success = TempData["Success"];
        return View(_students);
    }
}
