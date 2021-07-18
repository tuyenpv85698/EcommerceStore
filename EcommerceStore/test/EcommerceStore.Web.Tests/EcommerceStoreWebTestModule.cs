using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using EcommerceStore.EntityFrameworkCore;
using EcommerceStore.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace EcommerceStore.Web.Tests
{
    [DependsOn(
        typeof(EcommerceStoreWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class EcommerceStoreWebTestModule : AbpModule
    {
        public EcommerceStoreWebTestModule(EcommerceStoreEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(EcommerceStoreWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(EcommerceStoreWebMvcModule).Assembly);
        }
    }
}