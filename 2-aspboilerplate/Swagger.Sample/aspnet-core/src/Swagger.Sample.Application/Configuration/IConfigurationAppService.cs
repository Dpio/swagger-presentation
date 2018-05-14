using System.Threading.Tasks;
using Swagger.Sample.Configuration.Dto;

namespace Swagger.Sample.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
