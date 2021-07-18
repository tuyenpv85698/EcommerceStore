using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace EcommerceStore.Controllers
{
    public abstract class EcommerceStoreControllerBase: AbpController
    {
        protected EcommerceStoreControllerBase()
        {
            LocalizationSourceName = EcommerceStoreConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
