using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Weather.WeatherStation.Data
{
    /* This is used if database provider does't define
     * IWeatherStationDbSchemaMigrator implementation.
     */
    public class NullWeatherStationDbSchemaMigrator : IWeatherStationDbSchemaMigrator, ITransientDependency
    {
        public Task MigrateAsync()
        {
            return Task.CompletedTask;
        }
    }
}