using ItShop.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ItShop.Controllers
{
	public class ProductController : Controller
	{
		
		private readonly ITShopContext _context;

        public ProductController(ITShopContext context)
        {
            _context = context;
        }

        public IActionResult Index()
		{
			var products = _context.products
				.ToList();
			return View(products);
		}

		[Route(template:"Group/{Id}/{name}")]
		public IActionResult showProductByGroup(int Id,string name)
		{
			ViewData["GroupName"] = name;
			var Products = _context.CtegoryToProducts.Where(c=>c.CategoryId== Id)
				.Include(c=>c.Product)
				.Select(c=>c.Product)
				.ToList();
			return View(Products);
		}
	}
}
