using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using lab55.Data;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<lab55Context>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("lab55Context") ?? throw new InvalidOperationException("Connection string 'lab55Context' not found.")));

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddSession(options => { options.IdleTimeout = TimeSpan.FromMinutes(1); });

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();
app.UseSession();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=usersaccounts}/{action=login}/{id?}");

app.Run();
