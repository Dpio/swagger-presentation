using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace Swagger.Sample.Controllers
{
    public abstract class SampleControllerBase: AbpController
    {
        protected SampleControllerBase()
        {
            LocalizationSourceName = SampleConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
