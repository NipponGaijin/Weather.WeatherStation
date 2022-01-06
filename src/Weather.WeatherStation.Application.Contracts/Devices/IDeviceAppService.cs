using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;
using Weather.WeatherStation.Devices.Create;
using Weather.WeatherStation.Sensors;

namespace Weather.WeatherStation.Devices
{
    public interface IDeviceAppService: IApplicationService
    {
        Task<DeviceDto> CreateAsync(CreateDeviceDto input);
        Task<List<DeviceDto>> GetListAsync();

        Task<DeviceDto> GetDeviceByHwid(string hwid);

        Task<List<SensorDto>> GetSensorsByDeviceId(Guid deviceId);
    }
}
