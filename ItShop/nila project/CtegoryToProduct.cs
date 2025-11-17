using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ItShop.Models
{
    public class CtegoryToProduct
    {
        [Key]
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public int ProductId { get; set; }

        //Vavigaion propertis
        [ForeignKey("CategoryId")]
        public Category Category { get; set; }

        [ForeignKey("ProductId")]
        public Product Product { get; set; }
		public int CatgoryId { get; internal set; }
	}
}
