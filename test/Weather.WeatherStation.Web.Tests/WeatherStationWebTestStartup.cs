using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Volo.Abp;

namespace Weather.WeatherStation
{
    public class WeatherStationWebTestStartup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddApplication<WeatherStationWebTestModule>();
        }

        public void Configure(IApplicationBuilder app, ILoggerFactory loggerFactory)
        {
            app.InitializeApplication();
        }
    }
}