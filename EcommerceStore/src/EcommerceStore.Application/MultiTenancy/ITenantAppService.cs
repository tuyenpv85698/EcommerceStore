using Abp.Application.Services;
using EcommerceStore.MultiTenancy.Dto;

namespace EcommerceStore.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

