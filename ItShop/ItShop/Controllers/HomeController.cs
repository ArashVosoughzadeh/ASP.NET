using ItShop.Data;
using ItShop.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using System.Linq;
using System.Security.Claims;

namespace ItShop.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ITShopContext _context;

        public HomeController(ILogger<HomeController> logger, ITShopContext context)
        {
            _logger = logger;
            _context = context;
        }
        [Route("/")]
        public IActionResult Index()
        {          
            return View();
        }

        public IActionResult Detail(int id)
        {
            var product = _context.products                
                .SingleOrDefault(p => p.Id == id);

            if (product == null)
            {
                return NotFound();
            }

            var Categories = _context.products
               .Where(p => p.Id == id)
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

        [Authorize]

        public IActionResult AddToCard(int itemId)
        {
            var product = _context.products.SingleOrDefault(p => p.Id == itemId);
            if (product != null)
            {
                int userId = int.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier).ToString());
                var order = _context.orders.FirstOrDefault(o => o.UserId == userId &&!o.IsFinaly);
                if (order != null)
                {
                    var OrderDetail = _context.OrderDetails.FirstOrDefault(d => d.OrderId == order.OrderId && d.ProductId == product.Id);
                    if (OrderDetail != null)
                    {
                        OrderDetail.count += 1;
                    }
                    else
                    {
                        _context.OrderDetails.Add(new OrderDetail()
                        {
                            OrderId = order.OrderId,
                            ProductId = product.Id,
                            Price = product.Price,
                            count = 1
                        });
                    }
                }
                else
                {
                    order = new Order
                    {
                        IsFinaly = false,
                        CreateDate = DateTime.Now,
                        UserId = userId
                    };
                    _context.orders.Add(order);
                    _context.SaveChanges();
                    _context.OrderDetails.Add(new OrderDetail()
                    {
                        OrderId = order.OrderId,
                        ProductId = product.Id,
                        Price = product.Price,
                        count = 1,
                        
                    });
                    _context.SaveChanges();
                }
            };

            //_cart.addItem(cartItem);

            return RedirectToAction("ShowCart");
        }

        [Authorize]
        public IActionResult ShowCart()
        {
            int userId = int.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier).ToString());
            var order = _context.orders.Where(o => o.UserId == userId)
                .Include(o => o.OrderDetails)
                .ThenInclude(c => c.Product).FirstOrDefault();
            return View(order);
        }
        [Authorize]
        public IActionResult RemoveCart(int detailId)
        {
            var orderDetail = _context.OrderDetails.Find(detailId);
            _context.Remove(orderDetail);
            _context.SaveChanges();
            
            return RedirectToAction("ShowCart");
        }

        [Route(template: "ContactUs")]
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