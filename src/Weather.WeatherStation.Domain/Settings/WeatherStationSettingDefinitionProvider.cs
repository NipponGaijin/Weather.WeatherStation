using Volo.Abp.Settings;

namespace Weather.WeatherStation.Settings
{
    public class WeatherStationSettingDefinitionProvider : SettingDefinitionProvider
    {
        public override void Define(ISettingDefinitionContext context)
        {
            //Define your own settings here. Example:
            //context.Add(new SettingDefinition(WeatherStationSettings.MySetting1));
        }
    }
}
