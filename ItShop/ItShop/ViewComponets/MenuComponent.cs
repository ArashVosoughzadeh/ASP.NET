using ItShop.Data;
using ItShop.Data.Repositories;
using ItShop.Models;
using Microsoft.AspNetCore.Mvc;

namespace ItShop.ViewComponets
{
    public class MenuComponent : ViewComponent
    {
        private IGroupRepository _groupRepository;

        public MenuComponent(IGroupRepository groupRepository)
        {
            _groupRepository = groupRepository;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var groupList = _groupRepository.GetGroupForShow();
            return await Task.FromResult ((IViewComponentResult)View("MenuComponent", groupList));
        }
    }
}
