using AutoMapper;
using Weather.WeatherStation.Devices;
using Weather.WeatherStation.Measures;
using Weather.WeatherStation.Sensors;

namespace Weather.WeatherStation
{
    public class WeatherStationApplicationAutoMapperProfile : Profile
    {
        public WeatherStationApplicationAutoMapperProfile()
        {
            /* You can configure your AutoMapper mapping configuration here.
             * Alternatively, you can split your mapping configurations
             * into multiple profile classes for a better organization. */

            CreateMap<Device, DeviceDto>();
            CreateMap<Sensor, SensorDto>();
            CreateMap<Measure, MeasureDto>();
        }
    }
}
