using ItShop.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ItShop.Controllers
{
	public class ProductController : Controller
	{
		private ITShopContext _Context;

		public ProductController(ITShopContext context)
		{
			_Context = context;
		}

		[Route(template:"Group/{Id}/{name}")]
		public IActionResult showProductByGroup(int Id,string name)
		{
			ViewData["GroupName"] = name;
			var Products = _Context.CtegoryToProducts
				.Where(c=>c.CatgoryId == Id)
				.Include(c=>c.Product)
				.Select(c => c.Product)
				.ToList();
			return View();
		}
	}
}
