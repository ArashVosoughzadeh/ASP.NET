using ItShop.Data;
using ItShop.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace ItShop.Pages.Admin
{
    public class IndexModel : PageModel
    {
        private ITShopContext _context;

        public IndexModel(ITShopContext context)
        {
            _context = context;
        }
        public IEnumerable<Product> Products { get; set; }
        public void OnGet()
        {
            Products = _context.products.Include(p => p.Item);
        }

        public void OnPost()
        {
        }
    }
}
