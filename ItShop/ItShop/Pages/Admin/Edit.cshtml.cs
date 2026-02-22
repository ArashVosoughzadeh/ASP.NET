using ItShop.Data;
using ItShop.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace ItShop.Pages.Admin
{
    public class EditModel : PageModel
    {
        ITShopContext _context;

        public EditModel(ITShopContext context)
        {
            _context = context;
        }

        [BindProperty]
        public AddEditProductViewModel viewmodel { get; set; }
        public void OnGet(int id)
        {
            var product = _context.products.Include(p => p.Item)
                .Where(p => p.Id == id)
                .Select(s => new AddEditProductViewModel
                {
                    Id = s.Id,
                    Name = s.Name,
                    Description = s.Description,
                    QuantityInStock = s.Item.QuantityInStock,
                    Price = s.Item.Price,
                }).FirstOrDefault();
            product = product;
        }
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
                return Page();

            var product = _context.products.Find(viewmodel.Id);
            var item = _context.items.First(p => p.Id == viewmodel.Id);
            product.Name = viewmodel.Name;
            product.Description = viewmodel.Description;
            item.price = viewmodel.Price;
            item.QuantityInStock = viewmodel.QuantityInStock;

            return RedirectToPage("Index");
        }
    }
}
