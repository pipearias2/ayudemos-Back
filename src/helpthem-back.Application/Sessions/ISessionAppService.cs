using System.Threading.Tasks;
using Abp.Application.Services;
using helpthem-back.Sessions.Dto;

namespace helpthem-back.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
