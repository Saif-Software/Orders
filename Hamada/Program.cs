using Hamada.Models.appContext;
using Hamada.Models.Entity;
using Hamada.Repos.Implemntion;
using Hamada.Repos.IRepo;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace Hamada
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();


            builder.Services.AddDbContext<AppDBContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DBCONN")));


            builder.Services.AddScoped<Habit, IHabit>();
            builder.Services.AddScoped<users, Iusers>();
            builder.Services.AddScoped<Catgo, catRepoIm>();


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
        }
    }
}
