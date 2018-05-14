using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Swagger.Sample.MultiTenancy.Dto;

namespace Swagger.Sample.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}
