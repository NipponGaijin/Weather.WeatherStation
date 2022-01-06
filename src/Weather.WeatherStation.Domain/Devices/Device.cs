using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace Weather.WeatherStation.Devices
{
    public class Device: AuditedAggregateRoot<Guid>
    {
        public string Name { get; set; }

        public string HWID { get; set; }
    }
}
