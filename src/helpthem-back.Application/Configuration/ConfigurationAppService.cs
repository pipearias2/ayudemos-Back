using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using helpthem-back.Configuration.Dto;

namespace helpthem-back.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : helpthem-backAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
