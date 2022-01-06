using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;
using Weather.WeatherStation.Sensors.Create;

namespace Weather.WeatherStation.Sensors
{
    public interface ISensorAppService: IApplicationService
    {
        Task<SensorDto> CreateAsync(CreateSensorDto input);
        Task<List<SensorDto>> GetListAsync();
        Task<SensorDto> GetSensorByHwid(string hwid);
    }
}
