using AutoMapper;
using MDC.Server.Data.IRepositories;
using MDC.Server.Service.Exceptions;
using Microsoft.EntityFrameworkCore;
using MDC.Server.Service.DTOs.Location;
using MDC.Server.Domain.Entities.References;
using MDC.Server.Service.Interfaces.References;

namespace MDC.Server.Service.Services.References;

public class LocationService : ILocationService
{
    private readonly IMapper _mapper;
    private readonly ILocationRepository _locationRepository;

    public LocationService(IMapper mapper, ILocationRepository locationRepository)
    {
        _mapper = mapper;
        _locationRepository = locationRepository;
    }

    public async Task<LocationForResultDto> CreateAsync(LocationForCreationDto dto)
    {
        var mappedLocation = _mapper.Map<Location>(dto);
        mappedLocation.CreatedAt = DateTime.UtcNow;

        var createdLocation = await _locationRepository.InsertAsync(mappedLocation);
        
        return _mapper.Map<LocationForResultDto>(createdLocation);
    }

    public async Task<LocationForResultDto> ModifyAsync(short id, LocationForUpdateDto dto)
    {
        var location = await _locationRepository.SelectAll()
            .Where(l => l.Id == id)
            .AsNoTracking()
            .FirstOrDefaultAsync();
        if (location is null)
            throw new MDCException(404, "Location is not found");

        var mappedLocation = _mapper.Map(dto, location);
        mappedLocation.UpdatedAt = DateTime.UtcNow;

        await _locationRepository.UpdateAsync(mappedLocation);

        return _mapper.Map<LocationForResultDto>(mappedLocation);
    }

    public async Task<bool> RemoveAsync(short id)
    {
        var location = await _locationRepository.SelectAll()
                .Where(l => l.Id == id)
                .AsNoTracking()
                .FirstOrDefaultAsync();
        if (location is null)
            throw new MDCException(404, "Location is not found");

        return await _locationRepository.DeleteAsync(id);
    }

    public async Task<LocationForResultDto> RetrieveByIdAsync(short id)
    {
        var location = await _locationRepository.SelectAll()
                .Where(l => l.Id == id)
                .AsNoTracking()
                .FirstOrDefaultAsync();
        if (location is null)
            throw new MDCException(404, "Location Not Found");

        return _mapper.Map<LocationForResultDto>(location);
    }
}
