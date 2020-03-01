using System.Threading.Tasks;
using helpthem-back.Configuration.Dto;

namespace helpthem-back.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
