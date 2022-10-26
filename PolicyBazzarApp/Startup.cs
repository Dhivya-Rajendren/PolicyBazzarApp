using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PolicyBazzarApp
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            // Used for registering the services needed in the application.
            services.AddRazorPages();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

           // app.UseDefaultFiles(); // For setting the default file of the application technically the start up file of the application.

            // It has to look for index.html or index.htm or default.html or default.htm


            app.UseHttpsRedirection();//Redirects some request came in as http to https

            app.UseStaticFiles(); // UseStatic Files is a Middleware - Helps in handling the incoming request.
            app.UseRouting();
            app.UseEndpoints(ep => { ep.MapRazorPages(); });
        
        
        }
    }
}
