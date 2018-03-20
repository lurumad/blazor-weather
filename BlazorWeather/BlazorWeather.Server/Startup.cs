// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using BlazorWeather.Server.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.ResponseCompression;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json.Serialization;
using System.Linq;
using System.Net.Mime;

namespace BlazorWeather.Server
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services
                .AddSingleton<IWeatherClient, WeatherClient>()
                .AddResponseCompression(options =>
                {
                    options.MimeTypes = ResponseCompressionDefaults.MimeTypes
                        .Concat(new[] { MediaTypeNames.Application.Octet });
                })
                .AddMvc()
                .AddJsonOptions(options =>
                {
                    options.SerializerSettings.ContractResolver = new DefaultContractResolver();
                });
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.UseResponseCompression();

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc(routes =>
            {
                routes.MapRoute(name: "default", template: "{controller}/{action}/{id?}");
            });

            app.UseBlazor<Client.Program>();
        }
    }
}
