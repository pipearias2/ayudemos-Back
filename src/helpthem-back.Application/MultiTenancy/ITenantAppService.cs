using Abp.Application.Services;
using helpthem-back.MultiTenancy.Dto;

namespace helpthem-back.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

