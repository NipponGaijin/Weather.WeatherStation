using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;
using Weather.WeatherStation.Devices;

namespace Weather.WeatherStation.Sensors
{
    public class SensorDto : AuditedEntityDto<Guid>
    {
        public string Name { get; set; }

        public DeviceDto Device { get; set; }

        public string HWID { get; set; }
    }
}
