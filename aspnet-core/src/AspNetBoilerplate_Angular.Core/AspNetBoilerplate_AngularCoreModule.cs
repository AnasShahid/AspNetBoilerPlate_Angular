using Abp.Localization;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Abp.Runtime.Security;
using Abp.Timing;
using Abp.Zero;
using Abp.Zero.Configuration;
using AspNetBoilerplate_Angular.Authorization.Roles;
using AspNetBoilerplate_Angular.Authorization.Users;
using AspNetBoilerplate_Angular.Configuration;
using AspNetBoilerplate_Angular.Localization;
using AspNetBoilerplate_Angular.MultiTenancy;
using AspNetBoilerplate_Angular.Timing;

namespace AspNetBoilerplate_Angular
{
    [DependsOn(typeof(AbpZeroCoreModule))]
    public class AspNetBoilerplate_AngularCoreModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Auditing.IsEnabledForAnonymousUsers = true;

            // Declare entity types
            Configuration.Modules.Zero().EntityTypes.Tenant = typeof(Tenant);
            Configuration.Modules.Zero().EntityTypes.Role = typeof(Role);
            Configuration.Modules.Zero().EntityTypes.User = typeof(User);

            AspNetBoilerplate_AngularLocalizationConfigurer.Configure(Configuration.Localization);

            // Enable this line to create a multi-tenant application.
            Configuration.MultiTenancy.IsEnabled = AspNetBoilerplate_AngularConsts.MultiTenancyEnabled;

            // Configure roles
            AppRoleConfig.Configure(Configuration.Modules.Zero().RoleManagement);

            Configuration.Settings.Providers.Add<AppSettingProvider>();
            
            Configuration.Localization.Languages.Add(new LanguageInfo("fa", "فارسی", "famfamfam-flags ir"));
            
            Configuration.Settings.SettingEncryptionConfiguration.DefaultPassPhrase = AspNetBoilerplate_AngularConsts.DefaultPassPhrase;
            SimpleStringCipher.DefaultPassPhrase = AspNetBoilerplate_AngularConsts.DefaultPassPhrase;
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(AspNetBoilerplate_AngularCoreModule).GetAssembly());
        }

        public override void PostInitialize()
        {
            IocManager.Resolve<AppTimes>().StartupTime = Clock.Now;
        }
    }
}
