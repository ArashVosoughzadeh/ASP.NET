using ItShop.Models;
using Microsoft.AspNetCore.Mvc;

namespace ItShop.Controllers
{
    public class AdminProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(Product product)
        {
            return View();
        }
    }
}
