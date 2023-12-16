using MDC.Server.Service.DTOs.Community;

namespace MDC.Server.Service.Interfaces.Communities;

public  interface ICommunityService
{
    public Task<bool> DeleteAsync(long Id);
    public Task<CommunityForResultDto> RetruveByIdAsync(long Id);
    public Task<IEnumerable<CommunityForResultDto>> RetruveAllAsync();
    public Task<CommunityForResultDto> UpdateAsync(CommunityForUpdateDto Update);
    public Task<CommunityForResultDto> CreateAsync(CommunityForCreationDto community);
}
