using FreshShop.Business.Abstract;
using FreshShop.Business.Concrete;
using FreshShop.DataAccess.Abstract;
using FreshShop.DataAccess.Concrete;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FreshShop.MvcWebUI
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews().AddRazorRuntimeCompilation();

            //SINGLETION: O concrete sýnýftan bir nesne yaratýr ve talep eden nesneye o bir nesneyi gönderir.
            //TRANSIENT: her requeste o sýnýfýn yeni nesnelerini yaratýp gönderir.
            //SCOPED: Ayný reques içinde 1 nesne yaratýp gönderiri,farklý request için yeni nesne yaratýp gönderir.
            services.AddSingleton<IManagerBs, ManagerBs>();
            services.AddSingleton<IManagerRepository, ManagerRepository>();
            services.AddSingleton<IProductBs, ProductBs>();
            services.AddSingleton<IProductRepository, ProductRepository>();
            services.AddSingleton<IProductPhotoBs, ProductPhotoBs>();
            services.AddSingleton<IProductPhotoRepository, ProductPhotoRepository>();
            services.AddSingleton<ICategoryBs, CategoryBs>();
            services.AddSingleton<ICategoryRepository, CategoryRepository>();

            services.AddSession();


        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStaticFiles();

            app.UseRouting();

            app.UseSession();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {

                endpoints.MapAreaControllerRoute(
                    name: "adminLogIn",
                    areaName: "AdminPanel",
                    pattern: "admin",
                    defaults: new { controller = "Manager", action = "LogIn" });

                endpoints.MapAreaControllerRoute(
                   name: "adminDashBoard",
                   areaName: "AdminPanel",
                   pattern: "admin-dashboard",
                   defaults: new { controller = "DashBoard", action = "Index" });

                endpoints.MapAreaControllerRoute(
                  name: "adminForgotPassword",
                  areaName: "AdminPanel",
                  pattern: "forgot-password",
                  defaults: new { controller = "Manager", action = "ForgotPassword" });

                endpoints.MapAreaControllerRoute(
                  name: "adminManagers",
                  areaName: "AdminPanel",
                  pattern: "managers",
                  defaults: new { controller = "Manager", action = "Index" });

                endpoints.MapAreaControllerRoute(
                 name: "adminNewManager",
                 areaName: "AdminPanel",
                 pattern: "new-manager",
                 defaults: new { controller = "Manager", action = "New" });

                endpoints.MapAreaControllerRoute(
                name: "adminManagerPhotoUpload",
                areaName: "AdminPanel",
                pattern: "manager-photo-upload",
                defaults: new { controller = "Manager", action = "PhotoUpload" });

                endpoints.MapAreaControllerRoute(
                name: "adminProducts",
                areaName: "AdminPanel",
                pattern: "products",
                defaults: new { controller = "Product", action = "Index" });

                endpoints.MapAreaControllerRoute(
                name: "adminNewProduct",
                areaName: "AdminPanel",
                pattern: "new-product",
                defaults: new { controller = "Product", action = "New" });

                endpoints.MapAreaControllerRoute(
              name: "adminProductPhotoUpload",
              areaName: "AdminPanel",
              pattern: "Product-photo-upload",
              defaults: new { controller = "Product", action = "PhotoUpload" });

                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
