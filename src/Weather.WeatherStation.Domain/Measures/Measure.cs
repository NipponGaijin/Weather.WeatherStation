using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;
using Weather.WeatherStation.Sensors;

namespace Weather.WeatherStation.Measures
{
    public class Measure: AuditedAggregateRoot<Guid>
    {
        public double Temperature { get; set; }

        public Sensor Sensor { get; set; }
    }
}
