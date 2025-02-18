using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using PhoneStore2025.Models;

namespace PhoneStore2025.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
    }
}
