using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using EcommerceStore.Configuration;
using EcommerceStore.Web;

namespace EcommerceStore.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class EcommerceStoreDbContextFactory : IDesignTimeDbContextFactory<EcommerceStoreDbContext>
    {
        public EcommerceStoreDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<EcommerceStoreDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            EcommerceStoreDbContextConfigurer.Configure(builder, configuration.GetConnectionString(EcommerceStoreConsts.ConnectionStringName));

            return new EcommerceStoreDbContext(builder.Options);
        }
    }
}
