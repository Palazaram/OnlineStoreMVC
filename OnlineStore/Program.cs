using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Localization;
using Microsoft.EntityFrameworkCore;
using OnlineStore.Data;
using OnlineStore.Repositories;
using System.Globalization;

namespace OnlineStore
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            var connectionString = builder.Configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");
            builder.Services.AddDbContext<ApplicationDbContext>(options =>
                options.UseLazyLoadingProxies()
                .UseSqlServer(connectionString));
            builder.Services.AddDatabaseDeveloperPageExceptionFilter();

            builder.Services.AddIdentity<IdentityUser, IdentityRole>(options => options.SignIn.RequireConfirmedAccount = true)
                .AddEntityFrameworkStores<ApplicationDbContext>()
                .AddDefaultUI()
                .AddDefaultTokenProviders();

            builder.Services.AddControllersWithViews();

            //Add DIs
            builder.Services.AddTransient<IHomeRepository, HomeRepository>();
            builder.Services.AddTransient<ICartRepository, CartRepository>();
            builder.Services.AddTransient<IUserOrderRepository, UserOrderRepository>();
            
            var app = builder.Build();

            //Add admin to database
            InitializeRolesAndAdminUser(app.Services).Wait();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseMigrationsEndPoint();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseRequestLocalization(new RequestLocalizationOptions
            {
                DefaultRequestCulture = new RequestCulture("en-US"),
                SupportedCultures = new[]
                {
                 new CultureInfo("en-US"),
                 new CultureInfo("de"),
                },
                SupportedUICultures = new[]
                {
                 new CultureInfo("en-US"),
                 new CultureInfo("de"),
                }
            });

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");
            app.MapRazorPages();

            app.Run();
        }

        private static async Task InitializeRolesAndAdminUser(IServiceProvider serviceProvider)
        {
            using (var scope = serviceProvider.CreateScope())
            {
                await DbSeeder.SeedDefaultData(scope.ServiceProvider);
            }
        }
    }
}