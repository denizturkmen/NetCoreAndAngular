using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BackendApi.Business.Abstract;
using BackendApi.Business.Concrete;
using BackendApi.DataAccessLayer.Abstract;
using BackendApi.DataAccessLayer.Concrete;
using Microsoft.OpenApi.Models;

namespace BackendApi.SwaggerUI
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
            services.AddControllers();

            services.AddSwaggerGen();

            services.AddSwaggerGen(i =>
            {
                i.SwaggerDoc("v1", new OpenApiInfo
                {
                    Title = "Swagger Net Core",
                    Description = "Net core 3.1",
                    Version = "2.0.0",
                    Contact = new OpenApiContact()
                    {
                        Name = "Swagger Implementation Deniz",
                        Email = "deneme@hotmail.com",
                        Url = new Uri("http://denizturkmen.com.tr")
                    },
                    TermsOfService = new Uri("http://swagger.io/terms/")
                });
            });

            //Dependecy Injection sonra folder alcam
            services.AddTransient<IPersonService, PersonManager>();
            services.AddTransient<IPersonDal, EfCorePersonDal>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseSwagger();

            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "My_Api_V1");
            });

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
