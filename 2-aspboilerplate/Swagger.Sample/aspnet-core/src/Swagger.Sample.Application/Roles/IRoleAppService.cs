using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Swagger.Sample.Roles.Dto;

namespace Swagger.Sample.Roles
{
    public interface IRoleAppService : IAsyncCrudAppService<RoleDto, int, PagedResultRequestDto, CreateRoleDto, RoleDto>
    {
        Task<ListResultDto<PermissionDto>> GetAllPermissions();
    }
}
