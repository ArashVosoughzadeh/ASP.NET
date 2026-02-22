using ItShop.Data;
using ItShop.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ItShop.Controllers
{
    public class ProductAdminController : Controller
    {

        private readonly ITShopContext _context;

        public ProductAdminController(ITShopContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var products = _context.products.ToList();
            return View(products);
        }


        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(AddEditProductViewModel viewmdoel)
        {
            if (!ModelState.IsValid)
                return View(viewmdoel);
                   

            var pro = new Product()
            {
                Name = viewmdoel.Name,               
                Description = viewmdoel.Description,
                Price = viewmdoel.Price,
                Quantity = viewmdoel.QuantityInStock

            };
            _context.Add(pro);
            _context.SaveChanges();


            if (viewmdoel.Picture?.Length > 0)
            {
                string filePath = Path.Combine(Directory.GetCurrentDirectory(),
                    "wwwroot",
                    "images",
                    pro.Id + Path.GetExtension(viewmdoel.Picture.FileName));
                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    viewmdoel.Picture.CopyTo(stream);
                }
            }


            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            IEnumerable<Product> productList = _context.products.Where(p => p.Id == id);

            Product product = productList.First();


            AddEditProductViewModel viewModel = new AddEditProductViewModel()
            {
                Id = product.Id,
                Name = product.Name,
                Description = product.Description,
                QuantityInStock = product.Quantity,
                Price = product.Price,
            };
            return View(viewModel);
        }

        [HttpPost]
        public IActionResult Edit(AddEditProductViewModel viewModel)
        {

            if (!ModelState.IsValid)
                return View(viewModel);

            var product = _context.products.Find(viewModel.Id);

            product.Name = viewModel.Name;
            product.Description = viewModel.Description;
            product.Price = viewModel.Price;
            product.Quantity = viewModel.QuantityInStock;

            _context.products.Update(product); 
            _context.SaveChanges();

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            IEnumerable<Product> productList = _context.products.Where(p => p.Id == id);

            Product product = productList.First();

            //remove


            return RedirectToAction("Index");
        }

    }
}
