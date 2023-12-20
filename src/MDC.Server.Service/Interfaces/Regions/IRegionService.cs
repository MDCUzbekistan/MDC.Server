using MDC.Server.Domain.Configurations;
using MDC.Server.Service.DTOs.Regions;

namespace MDC.Server.Service.Interfaces.Regions;

public interface IRegionService
{
    Task<bool> RemoveAsync(int id);
    Task<RegionForResultDto> RetrieveByIdAsync(int id);
    Task<RegionForResultDto> RetrieveByCountryAsync(string country);
    Task<RegionForResultDto> CreateAsync(RegionForCreationDto dto);
    Task<RegionForResultDto> ModifyAsync(int id, RegionForUpdateDto dto);
    Task<IEnumerable<RegionForResultDto>> RetrieveAllAsync(PaginationParams @params);
}