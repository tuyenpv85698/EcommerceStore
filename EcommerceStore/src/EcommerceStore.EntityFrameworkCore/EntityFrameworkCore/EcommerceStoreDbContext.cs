using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using EcommerceStore.Authorization.Roles;
using EcommerceStore.Authorization.Users;
using EcommerceStore.MultiTenancy;

namespace EcommerceStore.EntityFrameworkCore
{
    public class EcommerceStoreDbContext : AbpZeroDbContext<Tenant, Role, User, EcommerceStoreDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public EcommerceStoreDbContext(DbContextOptions<EcommerceStoreDbContext> options)
            : base(options)
        {
        }
    }
}
