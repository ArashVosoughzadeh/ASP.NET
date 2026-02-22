using ItShop.Data;
using ItShop.Data.Repositories;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using System;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
    .AddCookie(option =>
    {
        option.LoginPath = "/login";
        option.LogoutPath = "/logout";
        option.ExpireTimeSpan = TimeSpan.FromDays(30);
    });

builder.Services.AddAuthorization();
builder.Services.AddMvc();
builder.Services.AddRazorPages();


// Add services to the container.

builder.Services.AddDbContext<ITShopContext>(options =>

    options.UseSqlServer("Server=.;Database=ITShop;Trusted_Connection=True;MultipleActiveResultSets=true;TrustServerCertificate=True"));

// Other service configurations...
builder.Services.AddScoped<IGroupRepository, GroupRepository>();
builder.Services.AddScoped<IProductRepository, ProductRepository>();
builder.Services.AddScoped<IUserRepository, UserRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline...



// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseAuthentication();

//app.Map("/Admin", myHandler);

app.UseStaticFiles();

app.UseRouting();

app.UseRouting();
//app.Map("/admin",myhandler);
app.UseAuthorization();

//app.Use(async (ctx, next) =>
//{
//    if (!ctx.User.Identity!.IsAuthenticated)
//    {
//        ctx.Response.Redirect("login");
//    }
//    else
//    {
//        await next();
//    }
//});
//private static void myHandler(IApplicationBuilder app)
//{
//    app.Use(async (Convert, next) =>
//    {
//        if (!context.User.Identity.IsAuthenticated)
//        {
//            context.Response.Redirect("/Accont/login");
//        }
//        else
//        {
//            await next.Invoke(next);
//        }
//    });
//}



app.UseEndpoints(endpoints =>
{
    endpoints.MapRazorPages();
    endpoints.MapControllerRoute(
name: "default",
pattern: "{controller=Home}/{action=Index}/{id?}");

});

app.Run();


