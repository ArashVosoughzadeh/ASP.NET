using ItShop.Data;
using ItShop.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ItShop.Controllers
{
    public class AdminController : Controller
    {

        private readonly ITShopContext _context;

        public AdminController(ITShopContext context)
        {
            _context = context;
        }
        [Route("/admin")]
        public IActionResult Index()
        {            
            return View();
        }
    }
}
