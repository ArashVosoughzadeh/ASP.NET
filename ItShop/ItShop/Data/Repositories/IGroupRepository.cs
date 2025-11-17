using ItShop.Models;
using System.Collections.Generic;

namespace ItShop.Data.Repositories
{
    public interface IGroupRepository
    {
        IEnumerable<Category> GetAllCategories();
        IEnumerable<ShowGroupViewModel> GetGroupForShow();
    }

    public class GroupRepository : IGroupRepository
    {
        private ITShopContext _context;

        public GroupRepository(ITShopContext context)
        {
            _context = context;
        }

        public IEnumerable<Category> GetAllCategories()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ShowGroupViewModel> GetGroupForShow()
        {
           return _context.Categories
                .Select(c => new ShowGroupViewModel()
                {
                    GroupId = c.Id,
                    GroupName = c.Name,
                    ProductCount = _context.CtegoryToProducts.Count(g => g.CategoryId == c.Id)
                }).ToList();
        }
    }


}
