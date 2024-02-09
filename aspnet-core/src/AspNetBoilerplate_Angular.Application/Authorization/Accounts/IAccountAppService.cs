using System.Threading.Tasks;
using Abp.Application.Services;
using AspNetBoilerplate_Angular.Authorization.Accounts.Dto;

namespace AspNetBoilerplate_Angular.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
