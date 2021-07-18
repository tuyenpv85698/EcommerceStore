using Microsoft.Extensions.Configuration;
using Castle.MicroKernel.Registration;
using Abp.Events.Bus;
using Abp.Modules;
using Abp.Reflection.Extensions;
using EcommerceStore.Configuration;
using EcommerceStore.EntityFrameworkCore;
using EcommerceStore.Migrator.DependencyInjection;

namespace EcommerceStore.Migrator
{
    [DependsOn(typeof(EcommerceStoreEntityFrameworkModule))]
    public class EcommerceStoreMigratorModule : AbpModule
    {
        private readonly IConfigurationRoot _appConfiguration;

        public EcommerceStoreMigratorModule(EcommerceStoreEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbSeed = true;

            _appConfiguration = AppConfigurations.Get(
                typeof(EcommerceStoreMigratorModule).GetAssembly().GetDirectoryPathOrNull()
            );
        }

        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = _appConfiguration.GetConnectionString(
                EcommerceStoreConsts.ConnectionStringName
            );

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
            Configuration.ReplaceService(
                typeof(IEventBus), 
                () => IocManager.IocContainer.Register(
                    Component.For<IEventBus>().Instance(NullEventBus.Instance)
                )
            );
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(EcommerceStoreMigratorModule).GetAssembly());
            ServiceCollectionRegistrar.Register(IocManager);
        }
    }
}
