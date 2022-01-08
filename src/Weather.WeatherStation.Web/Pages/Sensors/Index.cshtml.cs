using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using Volo.Abp;
using Weather.WeatherStation.Devices;
using Weather.WeatherStation.Measures;
using Weather.WeatherStation.Sensors;

namespace Weather.WeatherStation.Web.Pages.Sensors
{
    public class IndexModel : WeatherStationPageModel
    {
        public Guid DeviceId { get; set; }
        public List<SensorDto> Sensors { get; set; }

        private readonly ISensorAppService _sensorsAppService;
        private readonly IDeviceAppService _deviceAppService;

        public IndexModel(ISensorAppService sensorsAppService, IDeviceAppService deviceAppService)
        {
            this._sensorsAppService = sensorsAppService;
            this._deviceAppService = deviceAppService;
        }
        public void OnGet()
        {
            DeviceId = Guid.Parse(Request.Query["deviceId"].ToString());

            Sensors = _deviceAppService.GetSensorsByDeviceId(DeviceId).Result;
        }

        public async Task<List<MeasureDto>> GetMeasuresAsync(Guid sensorId)
        {
            try
            {
                var res = await _sensorsAppService.GetMeasuresBySensorId(sensorId);

                return res;
            }
            catch(UserFriendlyException e)
            {
                if(e.Code == HttpStatusCode.NotFound.ToString())
                {
                    return new List<MeasureDto>();
                }
                else
                {
                    throw e;
                }
            }
        }
    }
}
