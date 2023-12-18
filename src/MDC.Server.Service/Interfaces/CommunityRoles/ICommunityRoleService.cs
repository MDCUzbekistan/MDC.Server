using MDC.Server.Domain.Configurations;
using MDC.Server.Service.DTOs.CommunityRoles;

namespace MDC.Server.Service.Interfaces.CommunityRoles;

public interface ICommunityRoleService
{
    Task<bool> RemoveAsync(short id);
    Task<CommunityRoleForResultDto> RetrieveByIdAsync(short id);
    Task<IEnumerable<CommunityRoleForResultDto>> RetrieveAllAsync();
    Task<CommunityRoleForResultDto> CreateAsync(CommunityRoleForCreationDto dto);
    Task<CommunityRoleForResultDto> ModifyAsync(short id, CommunityRoleForUpdateDto dto);
}
