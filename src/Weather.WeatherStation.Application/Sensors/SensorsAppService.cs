using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;
using Weather.WeatherStation.Devices;
using Weather.WeatherStation.Sensors.Create;

namespace Weather.WeatherStation.Sensors
{
    public class SensorsAppService : ApplicationService, ISensorAppService
    {
        private readonly IRepository<Device, Guid> _deviceRepository;
        private readonly IRepository<Sensor, Guid> _sensorsRepository;
        public SensorsAppService(IRepository<Device, Guid> deviceRepository, IRepository<Sensor, Guid> sensorsRepository)
        {
            this._deviceRepository = deviceRepository;
            this._sensorsRepository = sensorsRepository;
        }

        public async Task<SensorDto> CreateAsync(CreateSensorDto input)
        {
            var device = await _deviceRepository.FirstOrDefaultAsync(x => x.Id == input.DeviceId);
            if(device == null)
            {
                throw new UserFriendlyException("Device not found!", HttpStatusCode.NotFound.ToString());
            }

            var sensor = new Sensor
            {
                Name = input.Name,
                Device = device,
                HWID = input.HWID
            };

            try
            {
                var res = await _sensorsRepository.InsertAsync(sensor);
                return ObjectMapper.Map<Sensor, SensorDto>(res);
            }
            catch (Exception ex)
            {
                throw new UserFriendlyException(ex.Message, HttpStatusCode.InternalServerError.ToString(), innerException: ex.InnerException);
            }
        }

        public async Task<List<SensorDto>> GetListAsync()
        {
            var res = await this._sensorsRepository.GetListAsync();
            if (res.Count <= 0)
            {
                throw new UserFriendlyException("Not Found", HttpStatusCode.NotFound.ToString());
            }

            return ObjectMapper.Map<List<Sensor>, List<SensorDto>>(res);
        }

        public async Task<SensorDto> GetSensorByHwid(string hwid)
        {
            var res = await this._sensorsRepository.FirstOrDefaultAsync(x => x.HWID == hwid);
            if (res == null)
            {
                throw new UserFriendlyException("Not Found", HttpStatusCode.NotFound.ToString());
            }

            return ObjectMapper.Map<Sensor, SensorDto>(res);
        }
    }
}
