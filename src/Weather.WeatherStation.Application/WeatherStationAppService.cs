using System;
using System.Collections.Generic;
using System.Text;
using Weather.WeatherStation.Localization;
using Volo.Abp.Application.Services;

namespace Weather.WeatherStation
{
    /* Inherit your application services from this class.
     */
    public abstract class WeatherStationAppService : ApplicationService
    {
        protected WeatherStationAppService()
        {
            LocalizationResource = typeof(WeatherStationResource);
        }
    }
}
