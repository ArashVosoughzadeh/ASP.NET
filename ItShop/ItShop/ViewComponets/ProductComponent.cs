using ItShop.Data;
using ItShop.Data.Repositories;
using ItShop.Models;
using Microsoft.AspNetCore.Mvc;

namespace ItShop.ViewComponets
{
    public class ProductComponent : ViewComponent
    {
        private IProductRepository _productRepository;

        public ProductComponent(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var productList = _productRepository.GetProductsForShow();


            return await Task.FromResult ((IViewComponentResult)View("ProductComponent", productList));
        }
    }
}
