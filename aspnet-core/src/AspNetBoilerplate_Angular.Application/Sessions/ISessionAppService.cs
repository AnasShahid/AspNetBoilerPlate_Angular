using System.Threading.Tasks;
using Abp.Application.Services;
using AspNetBoilerplate_Angular.Sessions.Dto;

namespace AspNetBoilerplate_Angular.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
