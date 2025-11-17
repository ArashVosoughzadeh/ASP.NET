using ItShop.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ItShop.Pages.Admin
{
    public class AddModel : PageModel
    {
        [BindProperty]
        public AddEditProductViewModel Product { get; set; }
        public void OnGet()
        {
        }



    }
}
