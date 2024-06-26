using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

using fahrenheitIn;
using fahrenheit;
using celcius;
using celciusIn;
using SoapCore;
using Microsoft.Extensions.DependencyInjection.Extensions;

namespace csharp_vacio
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSoapCore();
            services.TryAddSingleton<FahrenheitIn, fahrenheit.Fahrenheit>();
            services.TryAddSingleton<CelciusIn, celcius.Celcius>();
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

			app.UseEndpoints(endpoints => {
                endpoints.UseSoapEndpoint<FahrenheitIn>("/fahrenheitACelcius.jl", new SoapEncoderOptions(), SoapSerializer.DataContractSerializer);
                endpoints.UseSoapEndpoint<CelciusIn>("/celciusAfahrenheit.jl", new SoapEncoderOptions(), SoapSerializer.XmlSerializer);
            });
        }
    }
}
