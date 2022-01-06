using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Weather.WeatherStation.Sensors.Create
{
    public class CreateSensorDto
    {
        [Required]
        public Guid DeviceId { get; set; }

        public string Name { get; set; }

        [Required]
        public string HWID { get; set; }
    }
}
