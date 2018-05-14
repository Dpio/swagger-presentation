using System.Threading.Tasks;
using Abp.Application.Services;
using Swagger.Sample.Authorization.Accounts.Dto;

namespace Swagger.Sample.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
