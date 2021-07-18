using System.Threading.Tasks;
using Abp.Application.Services;
using EcommerceStore.Sessions.Dto;

namespace EcommerceStore.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
