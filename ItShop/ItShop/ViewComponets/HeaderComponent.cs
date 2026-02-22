using ItShop.Data;
using ItShop.Data.Repositories;
using ItShop.Models;
using Microsoft.AspNetCore.Mvc;

namespace ItShop.ViewComponets
{
    public class HeaderComponent : ViewComponent
    {
        private IGroupRepository _groupRepository;
        private readonly ITShopContext _context;

        public HeaderComponent(IGroupRepository groupRepository, ITShopContext context)
        {
            _groupRepository = groupRepository;
            _context = context;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            if(User.Identity!.IsAuthenticated)
            {
                var userName = User.Identity.Name;
                var userList =  _context.Users.Where(i => i.Email == userName);
                var user=userList.First();

                if(user.IsAdmin==true)
                {
                    ViewBag.IsAdmin = true;
                }
                else
                {
                    ViewBag.IsAdmin = false;
                }
               
            }
            return await Task.FromResult ((IViewComponentResult)View("HeaderComponent"));
        }
    }
}
