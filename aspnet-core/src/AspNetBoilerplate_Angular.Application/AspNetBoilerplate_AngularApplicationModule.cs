using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using AspNetBoilerplate_Angular.Authorization;

namespace AspNetBoilerplate_Angular
{
    [DependsOn(
        typeof(AspNetBoilerplate_AngularCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class AspNetBoilerplate_AngularApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<AspNetBoilerplate_AngularAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(AspNetBoilerplate_AngularApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
