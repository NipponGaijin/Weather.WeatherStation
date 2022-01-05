using Weather.WeatherStation.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Weather.WeatherStation.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class WeatherStationController : AbpControllerBase
    {
        protected WeatherStationController()
        {
            LocalizationResource = typeof(WeatherStationResource);
        }
    }
}