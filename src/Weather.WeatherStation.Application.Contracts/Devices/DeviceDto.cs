using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace Weather.WeatherStation.Devices
{
    public class DeviceDto : AuditedEntityDto<Guid>
    {
        public string Name { get; set; }
        public string HWID{ get; set; }
    }
}
