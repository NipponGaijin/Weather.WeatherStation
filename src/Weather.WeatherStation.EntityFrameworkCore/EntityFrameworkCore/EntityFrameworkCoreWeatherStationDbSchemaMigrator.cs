using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Weather.WeatherStation.Data;
using Volo.Abp.DependencyInjection;

namespace Weather.WeatherStation.EntityFrameworkCore
{
    public class EntityFrameworkCoreWeatherStationDbSchemaMigrator
        : IWeatherStationDbSchemaMigrator, ITransientDependency
    {
        private readonly IServiceProvider _serviceProvider;

        public EntityFrameworkCoreWeatherStationDbSchemaMigrator(
            IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public async Task MigrateAsync()
        {
            /* We intentionally resolving the WeatherStationDbContext
             * from IServiceProvider (instead of directly injecting it)
             * to properly get the connection string of the current tenant in the
             * current scope.
             */

            await _serviceProvider
                .GetRequiredService<WeatherStationDbContext>()
                .Database
                .MigrateAsync();
        }
    }
}
