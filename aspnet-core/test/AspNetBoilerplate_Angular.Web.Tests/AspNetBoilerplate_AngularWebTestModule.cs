using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using AspNetBoilerplate_Angular.EntityFrameworkCore;
using AspNetBoilerplate_Angular.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace AspNetBoilerplate_Angular.Web.Tests
{
    [DependsOn(
        typeof(AspNetBoilerplate_AngularWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class AspNetBoilerplate_AngularWebTestModule : AbpModule
    {
        public AspNetBoilerplate_AngularWebTestModule(AspNetBoilerplate_AngularEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(AspNetBoilerplate_AngularWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(AspNetBoilerplate_AngularWebMvcModule).Assembly);
        }
    }
}