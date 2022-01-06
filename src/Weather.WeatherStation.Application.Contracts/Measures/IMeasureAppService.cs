using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;
using Weather.WeatherStation.Measures.Create;

namespace Weather.WeatherStation.Measures
{
    public interface IMeasureAppService : IApplicationService
    {
        Task<MeasureDto> CreateAsync(CreateMeasureDto input);
        Task<List<MeasureDto>> GetListAsync();
    }
}
