using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;
using Weather.WeatherStation.Devices;

namespace Weather.WeatherStation.Sensors
{
    public class Sensor : AuditedAggregateRoot<Guid>
    {
        public string Name { get; set; }

        public Device Device { get; set; }
    }
}
