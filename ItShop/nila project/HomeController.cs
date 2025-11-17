using ItShop.Data;
using ItShop.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using System.Linq;

namespace ItShop.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ITShopContext _context;
        private static Cart _cart=new Cart();

        public HomeController(ILogger<HomeController> logger,ITShopContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            var products = _context.products
                .ToList();
            return View(products);
        }

        public IActionResult Detail(int id)
        {
            var product = _context.products
                .Include(navigationPropertyPath: p => p.Item)
                .SingleOrDefault(p => p.Id == id);

            if (product == null)
            {
                return NotFound();
            }

            var Categories = _context.products
               .Where(p=>p.Id == id)
               .SelectMany(c => c.CtegoryToProducts)
               .Select(Ca => Ca.Category)
               .ToList();

            var vm = new DetailsViewModel()
            {
                Product = product,  
                Categories = Categories
            };

            return View(vm);
        }

        public IActionResult AddToCard(int itemId)
        {
            var product = _context.products.Include(navigationPropertyPath:p=>p.Item).SingleOrDefault(p => p.ItemId == itemId);
            if (product != null)
            {
                var cartItem = new CartItem()
                {
                    Item = product.Item,
                    Quantity=1,                   
                };
                _cart.addItem(cartItem); 
               
                
            }
            return RedirectToAction("ShowCart");
        }

        public IActionResult ShowCart()
        {
            var CartVM = new CartViewModel()
            {
                CartItems = _cart.CartItems,
                OrderTotal = _cart.CartItems.Sum(c=>c.getTotalPrice())
            };
            return View(CartVM);
        }

        public IActionResult RemoveCart(int itemId)
        {
            _cart.removeItem(itemId);
            return RedirectToAction("ShowCart");
        }

        [Route(template:"ContactUs")]
        public IActionResult ContactUs()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}