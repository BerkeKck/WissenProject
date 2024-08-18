using eTickets.BL.Managers.Abstract;
using eTickets.BL.Managers.Concrete;
using eTickets.Entities.DbContexts;
using eTickets.Entities.Model.Concrete;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.Globalization;

namespace eTickets
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            // Configure DbContext with MySQL
            builder.Services.AddDbContext<AppDbContext>(options =>
                options.UseMySQL(builder.Configuration.GetConnectionString("DefaultConnection")));

            builder.Services.AddIdentity<IdentityUser, IdentityRole>().AddEntityFrameworkStores<AppDbContext>().AddDefaultTokenProviders();
            builder.Services.ConfigureApplicationCookie(options => {
                options.LoginPath = $"/Identity/Account/Login";
                options.LogoutPath = $"/Identity/Account/Logout";
                options.AccessDeniedPath = $"/Identity/Account/AccessDenied";
            });
            builder.Services.AddRazorPages();


            

            //Identity
            //builder.Services.AddIdentity<IdentityUser, IdentityRole>()
            //.AddEntityFrameworkStores<AppDbContext>()
            //.AddDefaultTokenProviders();    

            builder.Services.AddScoped<IMovieManager, MovieManager>();  

            builder.Services.AddScoped<IEmailSender,EmailSender>();
            builder.Services.AddScoped<IActorManager, ActorManager>();
            builder.Services.AddScoped<IMovieActorManager, MovieActorManager>();


            builder.Services.AddScoped<ICategoryManager, CategoryManager>();
            builder.Services.AddScoped<IMovieCategoryManager, MovieCategoryManager>();


            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }
            else
            {

            }
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();
            app.UseAuthentication(); // Kimlik do�rulama middleware'i
            app.UseAuthorization(); // Yetkilendirme middleware'i
            app.MapRazorPages();
            // Admin routes
            /* app.MapControllerRoute(
             name: "admin",
             pattern: "Admin/{controller=AdminPanel}/{action=MovieList}/{id?}");*/

            // Viewer routes
            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            // Set the culture to English
            var cultureInfo = new CultureInfo("en-US");
            CultureInfo.DefaultThreadCurrentCulture = cultureInfo;
            CultureInfo.DefaultThreadCurrentUICulture = cultureInfo;

            app.Run();
        }
    }
}