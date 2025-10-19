using Microsoft.AspNetCore.Mvc;
using Week4App.Models;

namespace Week4App.Controllers
{
    public class MaterialController : Controller
    {
        // Geçici bellek (veritabanı yerine)
        private static readonly List<MaterialModel> _materials = new();
        private static int _nextId = 1;

        [HttpGet]
        public IActionResult Create()
        {
            return View(new MaterialModel { PurchaseDate = DateTime.Today });
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(MaterialModel model)
        {
            if (!ModelState.IsValid)
                return View(model);

            model.Id = _nextId++;
            _materials.Add(model);

            TempData["Success"] = $"Material '{model.Name}' added successfully!";
            return RedirectToAction(nameof(List));
        }

        [HttpGet]
        public IActionResult List()
        {
            ViewBag.Success = TempData["Success"];
            return View(_materials);
        }

        [HttpPost]
        public IActionResult Delete(int id)
        {//LINQ
            var item = _materials.FirstOrDefault(m => m.Id == id);
            if (item != null)
            {
                _materials.Remove(item);
                TempData["Success"] = $"Material '{item.Name}' deleted.";
            }
            return RedirectToAction(nameof(List));
        }
    }
}
