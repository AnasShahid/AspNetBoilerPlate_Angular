using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace AspNetBoilerplate_Angular.EntityFrameworkCore
{
    public static class AspNetBoilerplate_AngularDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<AspNetBoilerplate_AngularDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<AspNetBoilerplate_AngularDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
