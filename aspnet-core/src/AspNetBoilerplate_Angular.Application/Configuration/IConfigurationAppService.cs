using System.Threading.Tasks;
using AspNetBoilerplate_Angular.Configuration.Dto;

namespace AspNetBoilerplate_Angular.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
