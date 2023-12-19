using MDC.Server.Service.DTOs.Community;
using MDC.Server.Service.DTOs.CommunityImage;
using Microsoft.AspNetCore.Http;

namespace MDC.Server.Service.Interfaces.Communities;

public  interface ICommunityService
{
    public Task<bool> DeleteAsync(long Id);
    public Task<CommunityForResultDto> RetruveByIdAsync(long Id);
    public Task<IEnumerable<CommunityForResultDto>> RetruveAllAsync();
    public Task<CommunityForResultDto> CreateAsync(CommunityForCreationDto community);
    public Task<CommunityForResultDto> UpdateAsync(long Id, CommunityForUpdateDto Update);
    public  Task<CommunityForResultDto> UpdateBannerAsync(long communitId, CommunityImageForCreationDto dto);
    public Task<CommunityForResultDto> UpdateLogoAsync(long communitId, CommunityImageForCreationDto dto);
    public Task<CommunityForResultDto> CreateLogoAsync(long communitId, CommunityImageForCreationDto dto);
    public Task<CommunityForResultDto> CreateBannerAsync(long communitId, CommunityImageForCreationDto dto);
}
