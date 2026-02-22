//using Microsoft.AspNetCore.Authorization;
//using Microsoft.AspNetCore.Identity;
//using Microsoft.AspNetCore.Mvc;

//[Authorize]
//public class OrdersController : Controller
//{
//    private readonly ApplicationDbContext _context;
//    private readonly UserManager<ApplicationUser> _userManager;

//    public OrdersController(ApplicationDbContext context,
//                            UserManager<ApplicationUser> userManager)
//    {
//        _context = context;
//        _userManager = userManager;
//    }

//    // /Orders/MyOrders
//    public async Task<IActionResult> MyOrders()
//    {
//        var userId = _userManager.GetUserId(User);

//        var orders = await _context.Orders
//            .Where(o => o.UserId == userId)
//            .OrderByDescending(o => o.CreateDate)
//            .ToListAsync();

//        return View(orders);
//    }

//    // /Orders/Details/5
//    public async Task<IActionResult> Details(int id)
//    {
//        var userId = _userManager.GetUserId(User);

//        var order = await _context.Orders
//            .Include(o => o.OrderItems)
//                .ThenInclude(oi => oi.Product)
//            .FirstOrDefaultAsync(o => o.Id == id && o.UserId == userId);

//        if (order == null)
//            return NotFound();

//        return View(order);
//    }
//}