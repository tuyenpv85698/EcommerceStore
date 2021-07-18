using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace EcommerceStore.Localization
{
    public static class EcommerceStoreLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(EcommerceStoreConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(EcommerceStoreLocalizationConfigurer).GetAssembly(),
                        "EcommerceStore.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
