using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Weather.WeatherStation.Devices;
using Weather.WeatherStation.Sensors;

namespace Weather.WeatherStation.Web.Pages
{
    public class IndexModel : WeatherStationPageModel
    {
        public List<DeviceDto> Devices { get; set; }

        private readonly IDeviceAppService _deviceAppService;
        public IndexModel(IDeviceAppService deviceAppService)
        {
            this._deviceAppService = deviceAppService;
        }
        public void OnGet()
        {
            Devices = _deviceAppService.GetListAsync().Result;
        }

        public async Task<List<SensorDto>> GetSensorsAsync(Guid deviceId)
        {
            var res = await _deviceAppService.GetSensorsByDeviceId(deviceId);

            return res;
        }
    }
}