using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using PhoneStore2025.Models;

namespace PhoneStore2025.Controllers
{
    public class GalleryController : Controller
    {
        public IActionResult Index()
        {
            Phone phone = new Phone();
            phone.Manufacturer = "iPhone";
            phone.PhoneModel = "12 Pro Max";
            phone.Price = 305;

            return View(phone);
        }

        public class Phone
        {
            public string Manufacturer { get; set; }
            public string PhoneModel { get; set; }
            public double Price { get; set; }

        }
    }
}
