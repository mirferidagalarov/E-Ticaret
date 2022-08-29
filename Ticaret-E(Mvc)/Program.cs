using Microsoft.EntityFrameworkCore;
using Ticaret_E_Mvc_.Abstract;
using Ticaret_E_Mvc_.BLL.Abstract;
using Ticaret_E_Mvc_.BLL.Concrete;
using Ticaret_E_Mvc_.Concrete.EfCore;
using Ticaret_E_Mvc_.DAL;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<ShopContext>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("Db")));
builder.Services.AddScoped<IProductRepository, EfCoreProductRepository>();
builder.Services.AddScoped<IProductService, ProductManager>();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
   
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
