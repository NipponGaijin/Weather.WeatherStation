using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace Weather.WeatherStation.Web
{
    [Dependency(ReplaceServices = true)]
    public class WeatherStationBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "WeatherStation";
    }
}
