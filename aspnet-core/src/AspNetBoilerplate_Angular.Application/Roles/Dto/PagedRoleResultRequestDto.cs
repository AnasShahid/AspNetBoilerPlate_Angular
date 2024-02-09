using Abp.Application.Services.Dto;

namespace AspNetBoilerplate_Angular.Roles.Dto
{
    public class PagedRoleResultRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }
    }
}

