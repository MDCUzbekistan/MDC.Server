using MDC.Server.Service.DTOs.Community;
using MDC.Server.Service.DTOs.CommunityRoles;
using MDC.Server.Service.DTOs.Users;

namespace MDC.Server.Service.DTOs.UserCommunities;

public class UserCommunityForResultDto
{
    public long Id { get; set; }
    public UserForResultDto User { get; set; }
    public CommunityRoleForResultDto Role { get; set; }
    public CommunityForResultDto Community { get; set; }
}
