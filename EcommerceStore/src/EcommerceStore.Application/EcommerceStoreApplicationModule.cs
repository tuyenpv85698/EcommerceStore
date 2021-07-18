using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using EcommerceStore.Authorization;

namespace EcommerceStore
{
    [DependsOn(
        typeof(EcommerceStoreCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class EcommerceStoreApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<EcommerceStoreAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(EcommerceStoreApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
