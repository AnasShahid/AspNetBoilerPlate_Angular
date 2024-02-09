using System.Collections.Generic;

namespace AspNetBoilerplate_Angular.Authentication.External
{
    public interface IExternalAuthConfiguration
    {
        List<ExternalLoginProviderInfo> Providers { get; }
    }
}
