using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Swagger.Sample.Roles.Dto;
using Swagger.Sample.Users.Dto;

namespace Swagger.Sample.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedResultRequestDto, CreateUserDto, UserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();

        Task ChangeLanguage(ChangeUserLanguageDto input);
    }
}
