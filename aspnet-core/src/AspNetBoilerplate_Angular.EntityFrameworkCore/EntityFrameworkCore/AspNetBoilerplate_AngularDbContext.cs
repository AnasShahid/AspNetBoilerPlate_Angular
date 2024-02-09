using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using AspNetBoilerplate_Angular.Authorization.Roles;
using AspNetBoilerplate_Angular.Authorization.Users;
using AspNetBoilerplate_Angular.MultiTenancy;

namespace AspNetBoilerplate_Angular.EntityFrameworkCore
{
    public class AspNetBoilerplate_AngularDbContext : AbpZeroDbContext<Tenant, Role, User, AspNetBoilerplate_AngularDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public AspNetBoilerplate_AngularDbContext(DbContextOptions<AspNetBoilerplate_AngularDbContext> options)
            : base(options)
        {
        }
    }
}
