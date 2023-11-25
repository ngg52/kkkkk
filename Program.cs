using Microsoft.EntityFrameworkCore;
using MvcApp.Models;


internal class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        string connection = builder.Configuration.GetConnectionString("DefaultConnection");

        builder.Services.AddDbContext<ApplicationContext>(options => options.UseSqlServer(connection));

        builder.Services.AddControllersWithViews();

        var app = builder.Build();

        app.MapDefaultControllerRoute();

        app.Run();
    }
}