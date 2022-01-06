using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Weather.WeatherStation.Devices.Create
{
    public class CreateDeviceDto
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string HWID { get; set; }
    }
}
