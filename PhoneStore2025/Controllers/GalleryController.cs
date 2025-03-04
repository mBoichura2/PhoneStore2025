using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PhoneStore2025.Data;
using PhoneStore2025.Models;

namespace PhoneStore2025.Controllers
{
    public class GalleryController : Controller
    {
        ApplicationDbContext _context;
        public GalleryController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var phones = _context.Phones.ToList();
            return View(phones);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Phone phone)
        {
            _context.Phones.Add(phone);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            var phone = _context.Phones.Find(id);
            return View(phone);
        }
        [HttpPost]
        public IActionResult Update(Phone phone)
        {
            _context.Phones.Update(phone);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            var phone = _context.Phones.Find(id);
            _context.Phones.Remove(phone);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
