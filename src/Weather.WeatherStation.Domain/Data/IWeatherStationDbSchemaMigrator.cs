using System.Threading.Tasks;

namespace Weather.WeatherStation.Data
{
    public interface IWeatherStationDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
