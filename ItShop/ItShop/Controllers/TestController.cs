using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ItShop.Controllers
{
    public class TestController : Controller
    {
        [Authorize]
        public string Test1 ()
        {
            return "Test1";
        }

        //[AllowAnonymous]

        public string Test2()
        {
            return "Test2";
        }
    }
}
