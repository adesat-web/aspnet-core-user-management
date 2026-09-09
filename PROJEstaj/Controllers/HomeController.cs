using Microsoft.AspNetCore.Mvc;
using PROJEstaj.Models;
using System.Linq;

namespace PROJEstaj.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var kisiler = _context.KisilerTablosu.ToList();
            return View(kisiler);
        }

        [HttpGet]
        public IActionResult Ekle()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Ekle(KisilerTablosu model)
        {
            if (ModelState.IsValid)
            {
                _context.KisilerTablosu.Add(model);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(model);
        }

        public IActionResult Sil(int id)
        {
            var kisi = _context.KisilerTablosu.Find(id);
            if (kisi != null)
            {
                _context.KisilerTablosu.Remove(kisi);
                _context.SaveChanges();
            }
            return RedirectToAction("Index");
        }
    }
}
