using Microsoft.AspNetCore.Http;
using MDC.Server.Service.DTOs.Community;

namespace MDC.Server.Service.Interfaces.Communities;

public  interface ICommunityService
{
    public Task<bool> DeleteAsync(long Id);
    public Task<CommunityForResultDto> RetruveByIdAsync(long Id);
    public Task<IEnumerable<CommunityForResultDto>> RetruveAllAsync();
    public Task<CommunityForResultDto> CreateAsync(CommunityForCreationDto community);
    public Task<CommunityForResultDto> UpdateAsync(long Id , CommunityForUpdateDto Update);
    public Task<CommunityImageForResultDto> UpdateCommunityLogoAsync(long CommunityId,IFormFile file);
    public Task<CommunityImageForResultDto> CreateCommunityLogoAsync(long CommunityId, IFormFile formFile);
    public Task<CommunityImageForResultDto> UpdateCommunityBannerAsync(long CommunityId, IFormFile file);
    public Task<CommunityImageForResultDto>CreateCommunityBannerAsync(long  CommunityId, IFormFile formFile);
}
