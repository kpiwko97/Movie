using System;
using System.Collections.Generic;
using System.Linq;
using System.Resources;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Movie.Models;
using Movie.Models.RestModels;

namespace Movie
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            services.AddSingleton<UrlPathRequest>(); // na czas testow
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            
            app.UseDeveloperExceptionPage();
            app.UseStatusCodePages();
            app.UseStaticFiles();
            app.UseMvc(route =>
            {
                route.MapRoute(
                    name: null,
                    template: "{type}/{header}/{page}/{genreId}",
                    defaults: new { Controller = "Home", Action = "ShowAll" });
                route.MapRoute(
                    name: null,
                    template: "{action}",
                    defaults: new { Controller = "Home", Action = "Movie" });
                
               
                
            });
            
        }
    }
}
