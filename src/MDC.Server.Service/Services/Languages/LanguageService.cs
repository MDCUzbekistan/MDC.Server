using AutoMapper;
using MDC.Server.Service.Exceptions;
using Microsoft.EntityFrameworkCore;
using MDC.Server.Service.DTOs.Languages;
using MDC.Server.Domain.Entities.References;
using MDC.Server.Data.IRepositories.Languages;
using MDC.Server.Service.Interfaces.Languages;
using MDC.Server.Domain.Configurations;
using MDC.Server.Service.Commons.Extensions;

namespace MDC.Server.Service.Services.Languages;

public class LanguageService : ILanguageService
{
    private readonly IMapper _mapper;
    private readonly ILanguageRepository _languageRepository;

    public LanguageService(IMapper mapper,ILanguageRepository languageRepository)
    {
        _mapper = mapper;
        _languageRepository = languageRepository;
    }

    public async Task<LanguageForResultDto> CreateAsync(LanguageForCreationDto dto)
    {
        var language = await _languageRepository.SelectAll()
                .Where(l => l.Name.ToLower() == dto.Name.ToLower())
                .AsNoTracking()
                .FirstOrDefaultAsync();

        if (language is not null)
            throw new MDCException(409, "Language is already exist.");

        var mappedLanguage = _mapper.Map<Language>(dto);
        mappedLanguage.CreatedAt = DateTime.UtcNow;

        var createdLanguage = await _languageRepository.InsertAsync(mappedLanguage);

        return _mapper.Map<LanguageForResultDto>(createdLanguage);
    }

    public async Task<LanguageForResultDto> ModifyAsync(short id, LanguageForUpdateDto dto)
    {
        var language = await _languageRepository.SelectAll()
                .Where(l => l.Id == id)
                .AsNoTracking()
                .FirstOrDefaultAsync();
        if (language is null)
            throw new MDCException(404, "Language is not found");

        var mappedLanguage = _mapper.Map(dto, language);
        mappedLanguage.UpdatedAt = DateTime.UtcNow;

        await _languageRepository.UpdateAsync(mappedLanguage);

        return _mapper.Map<LanguageForResultDto>(mappedLanguage);
    }

    public async Task<bool> RemoveAsync(short id)
    {
        var language = await _languageRepository.SelectAll()
                .Where(l => l.Id == id)
                .AsNoTracking()
                .FirstOrDefaultAsync();
        if (language is null)
            throw new MDCException(404, "Language is not found");

        return await _languageRepository.DeleteAsync(id); ;
    }

    public async Task<IEnumerable<LanguageForResultDto>> RetrieveAllAsync(PaginationParams @params)
    {
        var languages = await _languageRepository.SelectAll()
            .AsNoTracking()
            .ToPagedList<Language, short>(@params)
            .ToListAsync();

        return _mapper.Map<IEnumerable<LanguageForResultDto>>(languages);
    }

    public async Task<LanguageForResultDto> RetrieveByIdAsync(short id)
    {
        var language = await _languageRepository.SelectAll()
                .Where(l => l.Id == id)
                .AsNoTracking()
                .FirstOrDefaultAsync();
        if (language is null)
            throw new MDCException(404, "Language Not Found");

        return _mapper.Map<LanguageForResultDto>(language);
    }
}
