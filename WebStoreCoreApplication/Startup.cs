using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.CodeAnalysis.Options;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using WebStoreCoreApplicatioc.DAL;
using WebStoreCoreApplication.Controllers.Infrastructure;
using WebStoreCoreApplication.Controllers.Infrastructure.Interfaces;
using WebStoreCoreApplication.Controllers.Infrastructure.Services;

namespace WebStoreCoreApplication
{
    public class Startup
    {
        private readonly IConfiguration _configuration;
        public Startup(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            services.AddMvc(option =>
            {
                option.Filters.Add(typeof(SimpleActionFilter));
            });

            services.AddSingleton<IEmployeeService, InMemoryEmployeeServices>();
            services.AddSingleton<IProductServices, InMemoryProductServices>();
            services.AddDbContext<WebStoreContext>(options => options.UseSqlServer(_configuration.GetConnectionString("DefaultConnection")));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseStaticFiles();

            var hello = _configuration["CustomeHelloWorld"];

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Base}/{action=Index}/{id?}");
                /*
                 * endpoints.MapGet("/", async context =>
                {
                    await context.Response.WriteAsync(hello);
                });
                */
            });
        }
    }
}

