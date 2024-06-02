using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using SS.BLL.Manager.Concrete;
using SS.DAL.DataContext;
using SS.DAL.Repository.Concrete;
using SS.DAL.Services.Concrete;
using SS.ENTITIES.Concrete;

namespace SS.Admin
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            builder.Services.AddDbContext<SSDbContext>(opt =>
            {
                opt.UseSqlServer(builder.Configuration.GetConnectionString("SSWebAppDbStr"));
            },ServiceLifetime.Scoped);

            builder.Services.AddIdentityCore<AppUser>()
                            .AddDefaultTokenProviders()
                            .AddEntityFrameworkStores<SSDbContext>();

            builder.Services.AddScoped<CategoryRepo>();
            builder.Services.AddScoped<CategoryService>();
            builder.Services.AddScoped<CategoryManager>();


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
