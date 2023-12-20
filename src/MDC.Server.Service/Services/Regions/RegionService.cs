using AutoMapper;
using MDC.Server.Data.IRepositories;
using MDC.Server.Domain.Configurations;
using MDC.Server.Domain.Entities.References;
using MDC.Server.Service.Commons.Extensions;
using MDC.Server.Service.DTOs.Languages;
using MDC.Server.Service.DTOs.Regions;
using MDC.Server.Service.Exceptions;
using MDC.Server.Service.Interfaces.Regions;
using Microsoft.EntityFrameworkCore;

namespace MDC.Server.Service.Services.Regions;

public class RegionService : IRegionService
{
    private readonly IMapper _mapper;
    private readonly IRegionRepository _regionRepository;

    public RegionService(IMapper mapper, IRegionRepository regionRepository)
    {
        _mapper = mapper;
        _regionRepository = regionRepository;
    }
    public async Task<RegionForResultDto> CreateAsync(RegionForCreationDto dto)
    {
        var region = await _regionRepository.SelectAll()
                .Where(r => (r.Country.ToLower().Equals(r.Country.ToLower())) 
                 && (r.City.ToLower().Equals(r.City.ToLower())))
                .AsNoTracking()
                .FirstOrDefaultAsync();

        if (region is not null)
            throw new MDCException(409, "Region is already exist.");

        var mappedRegion = _mapper.Map<Region>(dto);
        mappedRegion.CreatedAt = DateTime.UtcNow;

        var createdRegion = await _regionRepository.InsertAsync(mappedRegion);

        return _mapper.Map<RegionForResultDto>(createdRegion);
    }

    public async Task<RegionForResultDto> ModifyAsync(int id, RegionForUpdateDto dto)
    {
        var region = await _regionRepository.SelectAll()
                .Where(r => r.Id == id)
                .AsNoTracking()
                .FirstOrDefaultAsync();

        if (region is null)
            throw new MDCException(404, "Region is not found");

        var mappedRegion = _mapper.Map(dto, region);
        mappedRegion.UpdatedAt = DateTime.UtcNow;

        await _regionRepository.UpdateAsync(mappedRegion);

        return _mapper.Map<RegionForResultDto>(mappedRegion);
    }

    public async Task<bool> RemoveAsync(int id)
    {
        var region = await _regionRepository.SelectAll()
                .Where(r => r.Id == id)
                .AsNoTracking()
                .FirstOrDefaultAsync();

        if (region is null)
            throw new MDCException(404, "Region is not found");

        return await _regionRepository.DeleteAsync(id);
    }

    public async Task<IEnumerable<RegionForResultDto>> RetrieveAllAsync(PaginationParams @params)
    {
        var region = await _regionRepository.SelectAll()
                .AsNoTracking()
                .ToPagedList<Region, int>(@params)
                .ToListAsync();

        return _mapper.Map<IEnumerable<RegionForResultDto>>(region);
    }

    public async Task<RegionForResultDto> RetrieveByCountryAsync(string country)
    {
        var region = await _regionRepository.SelectAll()
                .Where(r => r.Country.ToLower().Equals(r.Country.ToLower()))
                .AsNoTracking()
                .FirstOrDefaultAsync();

        if (region is null)
            throw new MDCException(404, "Region with this country is not found");

        return _mapper.Map<RegionForResultDto>(region);
    }

    public async Task<RegionForResultDto> RetrieveByIdAsync(int id)
    {
        var region = await _regionRepository.SelectAll()
                .Where(r => r.Id == id)
                .AsNoTracking()
                .FirstOrDefaultAsync();

        if (region is null)
            throw new MDCException(404, "Region is not found");

        return _mapper.Map<RegionForResultDto>(region);
    }

}
