using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using EcommerceStore.Configuration.Dto;

namespace EcommerceStore.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : EcommerceStoreAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
