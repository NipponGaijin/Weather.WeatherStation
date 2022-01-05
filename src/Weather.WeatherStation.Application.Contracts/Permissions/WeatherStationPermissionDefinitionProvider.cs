using Weather.WeatherStation.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Weather.WeatherStation.Permissions
{
    public class WeatherStationPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(WeatherStationPermissions.GroupName);
            //Define your own permissions here. Example:
            //myGroup.AddPermission(WeatherStationPermissions.MyPermission1, L("Permission:MyPermission1"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<WeatherStationResource>(name);
        }
    }
}
