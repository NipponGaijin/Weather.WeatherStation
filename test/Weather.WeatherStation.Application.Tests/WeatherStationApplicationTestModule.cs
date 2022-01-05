using Volo.Abp.Modularity;

namespace Weather.WeatherStation
{
    [DependsOn(
        typeof(WeatherStationApplicationModule),
        typeof(WeatherStationDomainTestModule)
        )]
    public class WeatherStationApplicationTestModule : AbpModule
    {

    }
}