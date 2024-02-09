using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace AspNetBoilerplate_Angular.Controllers
{
    public abstract class AspNetBoilerplate_AngularControllerBase: AbpController
    {
        protected AspNetBoilerplate_AngularControllerBase()
        {
            LocalizationSourceName = AspNetBoilerplate_AngularConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
