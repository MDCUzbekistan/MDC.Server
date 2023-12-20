using MDC.Server.Domain.Configurations;
using MDC.Server.Service.DTOs.UserCommunities;

public interface IUserCommunityService
{
    Task<bool> RemoveAsync(long id);
    Task<UserCommunityForResultDto> RetrieveByIdAsync(long id);
    Task<UserCommunityForResultDto> CreateAsync(UserCommunityForCreationDto dto);
    Task<UserCommunityForResultDto> ModifyAsync(long id, UserCommunityForUpdateDto dto);
    Task<IEnumerable<UserCommunityForResultDto>> RetrieveAllAsync(PaginationParams @params);
}