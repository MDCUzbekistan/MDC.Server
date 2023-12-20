using AutoMapper;
using MDC.Server.Data.IRepositories;
using MDC.Server.Domain.Entities.Events;
using MDC.Server.Service.DTOs.EventAssets;
using MDC.Server.Service.Exceptions;
using MDC.Server.Service.Helpers;
using MDC.Server.Service.Interfaces.Events;
using Microsoft.EntityFrameworkCore;

namespace MDC.Server.Service.Services.Events;

public class EventAssetService : IEventAssetService
{
    private readonly IMapper _mapper;
    private readonly IEventRepository _eventRepository;
    private readonly IEventAssetReposiytory _eventAssetReposiytory;

    public EventAssetService(
        IMapper mapper,
        IEventRepository eventRepository,
        IEventAssetReposiytory eventAssetReposiytory)
    {
        _mapper = mapper;
        _eventRepository = eventRepository;
        _eventAssetReposiytory = eventAssetReposiytory;
    }
    public async Task<EventAssetForResultDto> CreateAsync(EventAssetForCreationDto dto)
    {
        var @event = await _eventRepository.SelectAll()
            .Where(e => e.Id == dto.EventId)
            .AsNoTracking()
            .FirstOrDefaultAsync();

        if (@event is null)
            throw new MDCException(404, "Event is not found");

        var WwwRootPath = Path.Combine(WebHostEnviromentHelper.WebRootPath, "Media", "EventAssets");
        var assetsFolderPath = Path.Combine(WwwRootPath, "Media");
        var ImagesFolderPath = Path.Combine(assetsFolderPath, "EventAssets");

        if (!Directory.Exists(assetsFolderPath))
        {
            Directory.CreateDirectory(assetsFolderPath);
        }

        if (!Directory.Exists(ImagesFolderPath))
        {
            Directory.CreateDirectory(ImagesFolderPath);
        }
        var fileName = Guid.NewGuid().ToString("N") + Path.GetExtension(dto.Image.FileName);

        var fullPath = Path.Combine(WwwRootPath, fileName);

        using (var stream = File.OpenWrite(fullPath))
        {
            await dto.Image.CopyToAsync(stream);
            await stream.FlushAsync();
            stream.Close();
        }

        string resultImage = Path.Combine("Media", "EventAssets", fileName);

        var mapped = _mapper.Map<EventAsset> (dto);
        mapped.Image = resultImage;

        var result = await _eventAssetReposiytory.InsertAsync(mapped);

        return _mapper.Map<EventAssetForResultDto>(result);
       
    }

    public async Task<EventAssetForResultDto> ModifyAsync(long id, EventAssetForUpdateDto dto)
    {
        var @event = await _eventRepository.SelectAll()
            .Where(e => e.Id == dto.EventId)
            .AsNoTracking()
            .FirstOrDefaultAsync();

        if (@event is null)
            throw new MDCException(404, "Event is not found");

        var eventAsset = await _eventAssetReposiytory.SelectAll()
            .Where(ea => ea.Id == id)
            .AsNoTracking()
            .FirstOrDefaultAsync();

        if (eventAsset is null)
            throw new MDCException(404, "Event Asset is not found");

        var fullPath = Path.Combine(WebHostEnviromentHelper.WebRootPath, eventAsset.Image);

        if (File.Exists(fullPath))
        {
            File.Delete(fullPath);
        }


        var fileName = Guid.NewGuid().ToString("N") + Path.GetExtension(dto.Image.FileName);
        var rootPath = Path.Combine(WebHostEnviromentHelper.WebRootPath, "Media", "Events", fileName);
        using (var stream = new FileStream(rootPath, FileMode.Create))
        {
            await dto.Image.CopyToAsync(stream);
            await stream.FlushAsync();
            stream.Close();
        }
        string resultImage = Path.Combine("Media", "Events", fileName);

        var mapped = _mapper.Map(dto, eventAsset);
        mapped.Image = resultImage;
        mapped.UpdatedAt = DateTime.UtcNow;

        var result = await _eventAssetReposiytory.UpdateAsync(mapped);

        return _mapper.Map<EventAssetForResultDto>(result);
    }

    public async Task<bool> RemoveAsync(long id)
    {
        var eventAsset = await _eventAssetReposiytory.SelectAll()
            .Where(ea => ea.Id == id)
            .AsNoTracking()
            .FirstOrDefaultAsync();

        if (eventAsset is null)
            throw new MDCException(404, "Event Asset is not found");

        var fullPath = Path.Combine(WebHostEnviromentHelper.WebRootPath, eventAsset.Image);

        if (File.Exists(fullPath))
        {
            File.Delete(fullPath);
        }

        return await _eventAssetReposiytory.DeleteAsync(id);
    }

    public async Task<IEnumerable<EventAssetForResultDto>> RetrieveAllAsync()
    {
        var assets = await _eventAssetReposiytory.SelectAll()
            .Include(e => e.Event)
            .AsNoTracking()
            .ToListAsync();

        return _mapper.Map<IEnumerable<EventAssetForResultDto>>(assets);
    }

    public async Task<EventAssetForResultDto> RetrieveByIdAsync(long id)
    {
        var eventAsset = await _eventAssetReposiytory.SelectAll()
            .Where(ea => ea.Id == id)
            .Include(e => e.Event)
            .AsNoTracking()
            .FirstOrDefaultAsync();

        if (eventAsset is null)
            throw new MDCException(404, "Event Asset is not found");

        return _mapper.Map<EventAssetForResultDto>(eventAsset);
    }
}


