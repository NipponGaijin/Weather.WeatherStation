using Weather.WeatherStation.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace Weather.WeatherStation.Web.Pages
{
    /* Inherit your PageModel classes from this class.
     */
    public abstract class WeatherStationPageModel : AbpPageModel
    {
        protected WeatherStationPageModel()
        {
            LocalizationResourceType = typeof(WeatherStationResource);
        }
    }
}