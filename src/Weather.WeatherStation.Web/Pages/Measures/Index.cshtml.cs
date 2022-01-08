using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;

namespace Weather.WeatherStation.Web.Pages.Measures
{
    public class IndexModel : PageModel
    {
        public Guid SensorId { get; set; }
        public void OnGet()
        {
            SensorId = Guid.Parse(Request.Query["sensorId"].ToString());
        }
    }
}
