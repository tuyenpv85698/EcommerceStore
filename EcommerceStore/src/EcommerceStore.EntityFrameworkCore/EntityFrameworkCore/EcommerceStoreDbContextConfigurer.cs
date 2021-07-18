using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace EcommerceStore.EntityFrameworkCore
{
    public static class EcommerceStoreDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<EcommerceStoreDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<EcommerceStoreDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
