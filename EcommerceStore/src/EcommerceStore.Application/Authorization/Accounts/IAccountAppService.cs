using System.Threading.Tasks;
using Abp.Application.Services;
using EcommerceStore.Authorization.Accounts.Dto;

namespace EcommerceStore.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
