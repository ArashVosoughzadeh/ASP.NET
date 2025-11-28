using System.ComponentModel.DataAnnotations;

namespace ItShop.Models
{
    public class Product
    {
        //public Product()
        //{
        //    categories = new List<Category>();
        //}
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string description { get; set; }
		public string Description { get; set; }
		public int ItemId { get; set; }
        //public string Picture { get; set; }

        //public List<Category> categories { get; set; }

        public ICollection<CtegoryToProduct> CtegoryToProducts { get; set; }
        public Item Item { get; set; }


        public List<OrderDetail> OrderDetails { get; set; }
	
	
	}
}
