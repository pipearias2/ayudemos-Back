using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using helpthem-back.Configuration;

namespace helpthem-back.Web.Host.Startup
{
    [DependsOn(
       typeof(helpthem-backWebCoreModule))]
    public class helpthem-backWebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public helpthem-backWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(helpthem-backWebHostModule).GetAssembly());
        }
    }
}
