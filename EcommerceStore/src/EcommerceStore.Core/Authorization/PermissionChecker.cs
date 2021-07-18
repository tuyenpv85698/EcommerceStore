using Abp.Authorization;
using EcommerceStore.Authorization.Roles;
using EcommerceStore.Authorization.Users;

namespace EcommerceStore.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
