using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;
using Weather.WeatherStation.Sensors;

namespace Weather.WeatherStation.Measures
{
    public class MeasureDto : AuditedEntityDto<Guid>
    {
        public double Temperature { get; set; }

        public SensorDto Sensor { get; set; }
    }
}
