using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;
using Weather.WeatherStation.Devices.Create;
using Weather.WeatherStation.Sensors;

namespace Weather.WeatherStation.Devices
{
    public class DeviceAppService : ApplicationService, IDeviceAppService
    {
        private readonly IRepository<Device, Guid> _deviceRepository;
        private readonly IRepository<Sensor, Guid> _sensorsRepository;
        public DeviceAppService(IRepository<Device, Guid> deviceRepository, IRepository<Sensor, Guid> sensorsRepository)
        {
            this._deviceRepository = deviceRepository;
            this._sensorsRepository = sensorsRepository;
        }

        public async Task<DeviceDto> CreateAsync(CreateDeviceDto input)
        {
            var device = new Device
            {
                Name = input.Name,
                HWID = input.HWID
            };
            try
            {
                var res = await _deviceRepository.InsertAsync(device);
                return ObjectMapper.Map<Device, DeviceDto>(res);
            }
            catch (Exception ex)
            {
                throw new UserFriendlyException(ex.Message, HttpStatusCode.InternalServerError.ToString(), innerException:ex.InnerException);
            }
        }

        public async Task<DeviceDto> GetDeviceByHwid(string hwid)
        {
            var res = await _deviceRepository.FirstOrDefaultAsync(x => x.HWID == hwid);

            if(res == null)
            {
                throw new UserFriendlyException("Not Found", HttpStatusCode.NotFound.ToString());
            }

            return ObjectMapper.Map<Device, DeviceDto>(res);
        }

        public async Task<List<DeviceDto>> GetListAsync()
        {
            var res = await _deviceRepository.GetListAsync();

            if(res.Count <= 0)
            {
                throw new UserFriendlyException("Not Found", HttpStatusCode.NotFound.ToString());
            }

            return ObjectMapper.Map<List<Device>, List<DeviceDto>>(res);
        }

        public async Task<List<SensorDto>> GetSensorsByDeviceId(Guid deviceId)
        {
            var device = await this._deviceRepository.FirstOrDefaultAsync(x => x.Id == deviceId);
            if (device == null)
            {
                throw new UserFriendlyException("Device Not Found", HttpStatusCode.NotFound.ToString());
            }

            var sensors = await _sensorsRepository.GetListAsync(x => x.Device == device);
            if (sensors.Count <= 0)
            {
                throw new UserFriendlyException("Not Found", HttpStatusCode.NotFound.ToString());
            }

            return ObjectMapper.Map<List<Sensor>, List<SensorDto>>(sensors);
        }
    }
}
