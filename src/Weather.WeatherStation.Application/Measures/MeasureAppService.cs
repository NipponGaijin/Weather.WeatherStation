using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;
using Weather.WeatherStation.Measures.Create;
using Weather.WeatherStation.Sensors;

namespace Weather.WeatherStation.Measures
{
    public class MeasureAppService : ApplicationService, IMeasureAppService
    {

        private readonly IRepository<Sensor, Guid> _sensorsRepository;
        private readonly IRepository<Measure, Guid> _measuresRepository;
        public MeasureAppService(IRepository<Sensor, Guid> sensorsRepository, IRepository<Measure, Guid> _measuresRepository)
        {
            this._sensorsRepository = sensorsRepository;
            this._measuresRepository = _measuresRepository;
        }

        public async Task<MeasureDto> CreateAsync(CreateMeasureDto input)
        {
            var sensor = await this._sensorsRepository.FirstOrDefaultAsync(x => x.Id == input.SensorId);
            if (sensor == null)
            {
                throw new UserFriendlyException("Sensor not found", code: HttpStatusCode.NotFound.ToString());
            }

            var measure = new Measure
            {
                Temperature = input.Temperature,
                Sensor = sensor
            };

            try
            {
                var res = await _measuresRepository.InsertAsync(measure);
                return ObjectMapper.Map<Measure, MeasureDto>(res);
            }
            catch (Exception ex)
            {
                throw new UserFriendlyException(ex.Message, HttpStatusCode.InternalServerError.ToString(), innerException: ex.InnerException);
            }

            
        }

        public async Task<List<MeasureDto>> GetListAsync()
        {
            var res = await this._measuresRepository.GetListAsync();

            if (res.Count <= 0)
            {
                throw new UserFriendlyException("Not Found", HttpStatusCode.NotFound.ToString());
            }

            return ObjectMapper.Map<List<Measure>, List<MeasureDto>>(res);
        }
    }
}
