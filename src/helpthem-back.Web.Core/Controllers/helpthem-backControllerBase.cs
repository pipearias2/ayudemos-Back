using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace helpthem-back.Controllers
{
    public abstract class helpthem-backControllerBase: AbpController
    {
        protected helpthem-backControllerBase()
        {
            LocalizationSourceName = helpthem-backConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
