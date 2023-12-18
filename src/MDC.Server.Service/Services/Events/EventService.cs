﻿using AutoMapper;
using MDC.Server.Data.IRepositories;
using MDC.Server.Service.Exceptions;
using Microsoft.EntityFrameworkCore;
using MDC.Server.Service.DTOs.Events;
using MDC.Server.Domain.Configurations;
using MDC.Server.Domain.Entities.Events;
using MDC.Server.Service.Interfaces.Events;
using MDC.Server.Service.Commons.Extensions;
using Microsoft.AspNetCore.Http;
using MDC.Server.Service.Helpers;
using MDC.Server.Domain.Entities.Users;

namespace MDC.Server.Service.Services.Events;

public class EventService : IEventService
{
    private readonly IMapper _mapper;
    private readonly IRepository<Event, long> _repository;

    public EventService(IMapper mapper, IRepository<Event,long> repository)
    {
        _mapper = mapper;   
        _repository = repository;
    }
    public async Task<EventForResultDto> CreateAsync(EventForCreationDto dto)
    {
        var @event = await _repository.SelectAll().
            Where(e => e.Description == dto.Description && e.LocationId == dto.LocationId).
            AsNoTracking().
            FirstOrDefaultAsync();

        if (@event is not null)
            throw new MDCException(409, "Event is already exist");

        if(dto.StartAt > dto.EndAt)
        {
            throw new MDCException(404, "Start date is greater than end date ");
        }
       
        var fileName = Guid.NewGuid().ToString("N") + Path.GetExtension(dto.Banner.FileName);
        var rootPath = Path.Combine(WebHostEnviromentHelper.WebRootPath, "Media", "Events", fileName);
        using (var stream = new FileStream(rootPath, FileMode.Create))
        {
            await dto.Banner.CopyToAsync(stream);
            await stream.FlushAsync();
            stream.Close();
        }
        string resultImage = Path.Combine("Media", "Events", fileName);
       
        
        var MappedData = this._mapper.Map<Event>(dto);
        MappedData.Banner = resultImage;
        var result = await _repository.InsertAsync(MappedData);

        return _mapper.Map<EventForResultDto>(result);
    }

    public async Task<EventForResultDto> ModifyAsync(long id, EventForUpdateDto dto)
    {
        var @event = await _repository.SelectAll().
            Where(e => e.Id == id).
            FirstOrDefaultAsync();

        if (@event is null)
            throw new MDCException(404, "Event is not found");

        var fullPath = Path.Combine(WebHostEnviromentHelper.WebRootPath, @event.Banner);

        if (File.Exists(fullPath))
        {
            File.Delete(fullPath);
        }


        var fileName = Guid.NewGuid().ToString("N") + Path.GetExtension(dto.Banner.FileName);
        var rootPath = Path.Combine(WebHostEnviromentHelper.WebRootPath, "Media", "Events", fileName);
        using (var stream = new FileStream(rootPath, FileMode.Create))
        {
            await dto.Banner.CopyToAsync(stream);
            await stream.FlushAsync();
            stream.Close();
        }
        string resultImage = Path.Combine("Media", "Events", fileName);

        var mapped = _mapper.Map(dto, @event);
        mapped.UpdatedAt = DateTime.UtcNow;
        mapped.Banner = resultImage;

        var result = await _repository.UpdateAsync(mapped);

        return _mapper.Map<EventForResultDto>(result);
    }

    public async Task<bool> RemoveAsync(long id)
    {
        var @event = await _repository.SelectAll().
            Where(e => e.Id == id).
            FirstOrDefaultAsync();

        if (@event is null)
            throw new MDCException(404, "Event is not found");

        var fullPath = Path.Combine(WebHostEnviromentHelper.WebRootPath, @event.Banner);

        if (File.Exists(fullPath))
        {
            File.Delete(fullPath);
        }

        return await _repository.DeleteAsync(id);
    }

    public async Task<IEnumerable<EventForResultDto>> RetrieveAllAsync(PaginationParams @params)
    {
        var events = await _repository.SelectAll()
            .ToPagedList(@params)
            .AsNoTracking()
            .ToListAsync();

        return _mapper.Map<IEnumerable<EventForResultDto>>(events);
    }

    public async Task<EventForResultDto> RetrieveByIdAsync(long id)
    {
        var @event = await _repository.SelectAll().
           Where(e => e.Id == id).
           FirstOrDefaultAsync();

        if (@event is null)
            throw new MDCException(404, "Event is not found");

        return _mapper.Map<EventForResultDto>(@event);
    }
}
