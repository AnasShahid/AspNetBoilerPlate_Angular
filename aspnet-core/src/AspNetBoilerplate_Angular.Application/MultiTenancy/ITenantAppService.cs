using Abp.Application.Services;
using AspNetBoilerplate_Angular.MultiTenancy.Dto;

namespace AspNetBoilerplate_Angular.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

