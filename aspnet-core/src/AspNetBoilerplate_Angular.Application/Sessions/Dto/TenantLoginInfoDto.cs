using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using AspNetBoilerplate_Angular.MultiTenancy;

namespace AspNetBoilerplate_Angular.Sessions.Dto
{
    [AutoMapFrom(typeof(Tenant))]
    public class TenantLoginInfoDto : EntityDto
    {
        public string TenancyName { get; set; }

        public string Name { get; set; }
    }
}
