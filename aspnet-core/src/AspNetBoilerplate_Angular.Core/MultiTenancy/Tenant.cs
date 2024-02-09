using Abp.MultiTenancy;
using AspNetBoilerplate_Angular.Authorization.Users;

namespace AspNetBoilerplate_Angular.MultiTenancy
{
    public class Tenant : AbpTenant<User>
    {
        public Tenant()
        {            
        }

        public Tenant(string tenancyName, string name)
            : base(tenancyName, name)
        {
        }
    }
}
