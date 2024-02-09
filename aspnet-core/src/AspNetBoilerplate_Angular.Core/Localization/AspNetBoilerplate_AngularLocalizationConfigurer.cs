using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace AspNetBoilerplate_Angular.Localization
{
    public static class AspNetBoilerplate_AngularLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(AspNetBoilerplate_AngularConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(AspNetBoilerplate_AngularLocalizationConfigurer).GetAssembly(),
                        "AspNetBoilerplate_Angular.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
