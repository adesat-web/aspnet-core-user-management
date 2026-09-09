using Microsoft.EntityFrameworkCore;
using PROJEstaj.Models;

var builder = WebApplication.CreateBuilder(args);

// DbContext ekle
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// MVC ekle
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Pipeline ayarları
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();
app.UseAuthorization();

// Default route
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
