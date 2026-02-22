using ItShop.Models;
using System.Collections.Generic;

namespace ItShop.Data.Repositories
{
    public interface IProductRepository
    {
        IEnumerable<ShowProductViewModel> GetProductsForShow();
      
    }

    public class ProductRepository : IProductRepository
    {
        private ITShopContext _context;

        public ProductRepository(ITShopContext context)
        {
            _context = context;
        }

        public IEnumerable<ShowProductViewModel> GetProductsForShow()
        {
           return _context.products
                .Select(c => new ShowProductViewModel()
                {
                    ProductId = c.Id,
                    ProductName = c.Name,
                }).ToList();
        }
    }


}
