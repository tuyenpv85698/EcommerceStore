using System.Threading.Tasks;
using EcommerceStore.Configuration.Dto;

namespace EcommerceStore.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
