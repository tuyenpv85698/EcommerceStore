using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using EcommerceStore.Configuration;

namespace EcommerceStore.Web.Host.Startup
{
    [DependsOn(
       typeof(EcommerceStoreWebCoreModule))]
    public class EcommerceStoreWebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public EcommerceStoreWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(EcommerceStoreWebHostModule).GetAssembly());
        }
    }
}
