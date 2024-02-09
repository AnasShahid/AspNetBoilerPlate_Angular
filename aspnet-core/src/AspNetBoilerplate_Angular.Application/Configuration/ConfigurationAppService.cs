using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using AspNetBoilerplate_Angular.Configuration.Dto;

namespace AspNetBoilerplate_Angular.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : AspNetBoilerplate_AngularAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
