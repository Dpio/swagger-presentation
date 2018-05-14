using System.Threading.Tasks;
using Abp.Application.Services;
using Swagger.Sample.Sessions.Dto;

namespace Swagger.Sample.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
