using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using helpthem-back.Authorization;

namespace helpthem-back
{
    [DependsOn(
        typeof(helpthem-backCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class helpthem-backApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<helpthem-backAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(helpthem-backApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
