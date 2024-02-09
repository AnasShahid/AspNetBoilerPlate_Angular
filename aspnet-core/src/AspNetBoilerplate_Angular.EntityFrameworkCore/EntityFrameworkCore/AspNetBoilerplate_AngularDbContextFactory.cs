using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using AspNetBoilerplate_Angular.Configuration;
using AspNetBoilerplate_Angular.Web;

namespace AspNetBoilerplate_Angular.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class AspNetBoilerplate_AngularDbContextFactory : IDesignTimeDbContextFactory<AspNetBoilerplate_AngularDbContext>
    {
        public AspNetBoilerplate_AngularDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<AspNetBoilerplate_AngularDbContext>();
            
            /*
             You can provide an environmentName parameter to the AppConfigurations.Get method. 
             In this case, AppConfigurations will try to read appsettings.{environmentName}.json.
             Use Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") method or from string[] args to get environment if necessary.
             https://docs.microsoft.com/en-us/ef/core/cli/dbcontext-creation?tabs=dotnet-core-cli#args
             */
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            AspNetBoilerplate_AngularDbContextConfigurer.Configure(builder, configuration.GetConnectionString(AspNetBoilerplate_AngularConsts.ConnectionStringName));

            return new AspNetBoilerplate_AngularDbContext(builder.Options);
        }
    }
}
