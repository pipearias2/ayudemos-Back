using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace helpthem-back.Localization
{
    public static class helpthem-backLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(helpthem-backConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(helpthem-backLocalizationConfigurer).GetAssembly(),
                        "helpthem-back.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
