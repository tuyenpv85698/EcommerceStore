using Abp.Application.Services.Dto;

namespace EcommerceStore.Roles.Dto
{
    public class PagedRoleResultRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }
    }
}

