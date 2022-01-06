using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Weather.WeatherStation.Sensors;

namespace Weather.WeatherStation.Measures.Create
{
    public class CreateMeasureDto
    {
        [Required]
        public double Temperature { get; set; }

        [Required]
        public Guid SensorId { get; set; }
    }
}
