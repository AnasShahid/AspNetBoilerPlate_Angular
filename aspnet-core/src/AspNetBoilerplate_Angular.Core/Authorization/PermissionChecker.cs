using Abp.Authorization;
using AspNetBoilerplate_Angular.Authorization.Roles;
using AspNetBoilerplate_Angular.Authorization.Users;

namespace AspNetBoilerplate_Angular.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
