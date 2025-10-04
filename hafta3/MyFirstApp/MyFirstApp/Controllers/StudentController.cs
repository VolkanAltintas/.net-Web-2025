using Microsoft.AspNetCore.Mvc;

namespace MyFirstApp.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Title = "Öğrenci Sistemi Ana Sayfa";
            return View();
        }

        public IActionResult List()
        {
            ViewBag.Students = new List<string>
            {
                "Ayşe Yılmaz",
                "Mehmet Demir",
                "Zeynep Kaya"
            };
            return View();
        }

        public IActionResult Detail(string name)
        {
            ViewBag.Name = string.IsNullOrWhiteSpace(name) ? "Bilinmiyor" : name;
            return View();
        }
    }
}