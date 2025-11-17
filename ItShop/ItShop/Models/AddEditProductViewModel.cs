using System.ComponentModel.DataAnnotations;

namespace ItShop.Models
{
    public class AddEditProductViewModel
    {
               public int Id { get; set; }

        [Display(Name="Name")]
        public string Name { get; set; }
        [Display(Name = "Description")]
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int QuantityInStock { get; set; }
        public IFormFile Picture { get; set; }
    }
}
