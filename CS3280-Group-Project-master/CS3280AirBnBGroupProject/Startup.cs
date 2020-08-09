using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using CS3280AirBnBGroupProject.Repositories;
using CS3280AirBnBGroupProject.Models;
using CS3280AirBnBGroupProject.Services.Interfaces;
using CS3280AirBnBGroupProject.Services;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.AspNetCore.Http;
using Blazored.Modal;
using CS3280AirBnBGroupProject.Models.Interfaces;
using System.Diagnostics.CodeAnalysis;

namespace CS3280AirBnBGroupProject
{
    [ExcludeFromCodeCoverage]
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddRazorPages();
            services.AddServerSideBlazor();
            //services.AddSingleton<IResultRepository, ResultRepository>();
            services.AddSingleton<IResultRepository, MockResultRepository>();
            services.AddSingleton<IResultService, ResultService>();
            services.AddSingleton<IResult, Result>();
            services.AddSingleton<Amenities>();
            services.AddControllersWithViews();
            services.AddHttpContextAccessor();
            services.AddBlazoredModal();
            services.AddSingleton<IBilling, Billing>();
            services.AddSingleton<IPayment, Payment>();
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
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapBlazorHub();
                endpoints.MapFallbackToPage("/_Host");
            });
        }
    }
}
