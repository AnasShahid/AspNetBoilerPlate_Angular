using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using AspNetBoilerplate_Angular.Configuration;

namespace AspNetBoilerplate_Angular.Web.Host.Startup
{
    [DependsOn(
       typeof(AspNetBoilerplate_AngularWebCoreModule))]
    public class AspNetBoilerplate_AngularWebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public AspNetBoilerplate_AngularWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(AspNetBoilerplate_AngularWebHostModule).GetAssembly());
        }
    }
}
