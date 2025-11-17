using System.ComponentModel.DataAnnotations;

namespace ItShop.Models
{
    public class Category   
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(200)]
        [Required]
        public string Name { get; set; } 
        public string Description { get; set; }

        public string ExtraDescription { get; set; }
        
        public ICollection<CtegoryToProduct> CtegoryToProducts{ get; set;}
    }
}
