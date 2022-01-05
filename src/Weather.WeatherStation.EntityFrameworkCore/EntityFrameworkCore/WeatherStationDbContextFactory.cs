using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Weather.WeatherStation.EntityFrameworkCore
{
    /* This class is needed for EF Core console commands
     * (like Add-Migration and Update-Database commands) */
    public class WeatherStationDbContextFactory : IDesignTimeDbContextFactory<WeatherStationDbContext>
    {
        public WeatherStationDbContext CreateDbContext(string[] args)
        {
            WeatherStationEfCoreEntityExtensionMappings.Configure();

            var configuration = BuildConfiguration();

            var builder = new DbContextOptionsBuilder<WeatherStationDbContext>()
                .UseNpgsql(configuration.GetConnectionString("Default"));

            return new WeatherStationDbContext(builder.Options);
        }

        private static IConfigurationRoot BuildConfiguration()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../Weather.WeatherStation.DbMigrator/"))
                .AddJsonFile("appsettings.json", optional: false);

            return builder.Build();
        }
    }
}
