using Weather.WeatherStation.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace Weather.WeatherStation.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(WeatherStationEntityFrameworkCoreModule),
        typeof(WeatherStationApplicationContractsModule)
        )]
    public class WeatherStationDbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
        }
    }
}
