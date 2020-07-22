using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using ShopHome.Repository.Abstract;
using ShopHome.Repository.Concrete.EntityFramework;

namespace ShopHome
{
    public class Startup
    {
        public IConfiguration Configuration { get; }
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<ShopHomeContext>(options => options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

            services.AddTransient<IProductRepository, EfProductRepository>();
            services.AddTransient<ICategoryRepository, EfCategoryRepository>();
            services.AddTransient<ISubCategoryRepository, EfSubCategoryRepository>();
            services.AddTransient<IDiscount_of_the_dayRepository, EfDiscount_of_dayRepository>();
            services.AddTransient<IFixed_photoRepository, EfFixed_photoRepository>();
            services.AddTransient<ILast_15_soldRepository, EfLast_15_soldRepository>();
            services.AddTransient<IOfferRepository, EfOfferRepository>();
            services.AddTransient<ISliderRepository, EfSliderRepository>();
            services.AddTransient<ISlidersRepository, EfSlidersRepository>();
            services.AddTransient<IToday_is_offerRepository, EfToday_is_offerRepository>();


            services.AddTransient<IUnitOfWork, EfUnitOfWork>();


            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseStaticFiles();
            app.UseStatusCodePages();
            app.UseRouting();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(name: "default",
              pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
