using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using helpthem-back.Roles.Dto;
using helpthem-back.Users.Dto;

namespace helpthem-back.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedUserResultRequestDto, CreateUserDto, UserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();

        Task ChangeLanguage(ChangeUserLanguageDto input);
    }
}
