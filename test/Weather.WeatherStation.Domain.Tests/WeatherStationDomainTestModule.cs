using Weather.WeatherStation.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Weather.WeatherStation
{
    [DependsOn(
        typeof(WeatherStationEntityFrameworkCoreTestModule)
        )]
    public class WeatherStationDomainTestModule : AbpModule
    {

    }
}