using AutoMapper;
using MDC.Server.Data.IRepositories;
using MDC.Server.Data.IRepositories.Languages;
using MDC.Server.Domain.Configurations;
using MDC.Server.Domain.Entities.Users;
using MDC.Server.Service.Commons.Extensions;
using MDC.Server.Service.DTOs.UserLanguages;
using MDC.Server.Service.Exceptions;
using MDC.Server.Service.Interfaces.Languages;
using MDC.Server.Service.Interfaces.UserLanguages;
using MDC.Server.Service.Interfaces.Users;
using Microsoft.EntityFrameworkCore;

namespace MDC.Server.Service.Services.UserLanguages;

public class UserLanguageService : IUserLanguageService
{
    private readonly IMapper _mapper;
    private readonly IUserService _userService;
    private readonly ILanguageService _languageService;
    private readonly IUserLanguageRepository _userLanguageRepository;

    public UserLanguageService(
        IMapper mapper,
        IUserService userService,
        IUserLanguageRepository userLanguageRepository,
        ILanguageService languageService)
    {
        _mapper = mapper;
        _userService = userService;
        _languageService = languageService;
        _userLanguageRepository = userLanguageRepository;
    }
    public async Task<UserLanguageForResultDto> AddAsync(UserLanguageForCreationDto dto)
    {
        var user = await _userService.RetrieveByIdAsync(dto.UserId);
        var language = await _languageService.RetrieveByIdAsync(dto.LanguageId);

        var userLanguage = _mapper.Map<UserLanguage>(dto);
        userLanguage.CreatedAt = DateTime.UtcNow;

        var result = await _userLanguageRepository.InsertAsync(userLanguage);

        return _mapper.Map<UserLanguageForResultDto>(result);
    }

    public async Task<UserLanguageForResultDto> ModifyAsync(long id, UserLanguageForUpdateDto dto)
    {
        var userLanguage = await _userLanguageRepository.SelectAll()
            .Where(u => u.Id == id)
            .AsNoTracking()
            .FirstOrDefaultAsync();
        if (userLanguage is null)
            throw new MDCException(404, "UserLanguage is not found");

        var user = await _userService.RetrieveByIdAsync(dto.UserId);
        var language = await _languageService.RetrieveByIdAsync(dto.LanguageId);

        var mappedUserLanguage = _mapper.Map(dto, userLanguage);
        mappedUserLanguage.UpdatedAt = DateTime.UtcNow;
        await _userLanguageRepository.UpdateAsync(mappedUserLanguage);

        return _mapper.Map<UserLanguageForResultDto>(mappedUserLanguage);
    }

    public async Task<bool> RemoveAsync(long id)
    {
        var userlanguage = await _userLanguageRepository.SelectAll()
            .Where(u => u.Id == id)
            .FirstOrDefaultAsync();
        if (userlanguage is null)
            throw new MDCException(404, "UserLanguage is not found");

        await _userLanguageRepository.DeleteAsync(id);

        return true;
    }

    public async Task<IEnumerable<UserLanguageForResultDto>> RetrieveAllAsync(PaginationParams @params)
    {
        var userLanguages = await _userLanguageRepository.SelectAll()
            .Include(u => u.User)
            .Include(ul => ul.Language)
            .AsNoTracking()
            .ToPagedList<UserLanguage, long>(@params)
            .ToListAsync();

        return _mapper.Map<IEnumerable<UserLanguageForResultDto>>(userLanguages);
    }

    public async Task<UserLanguageForResultDto> RetrieveByIdAsync(long id)
    {
        var userLanguage = await _userLanguageRepository.SelectAll()
            .Where(u => u.Id == id)
            .Include(uu => uu.User)
            .Include(ul => ul.Language)
            .AsNoTracking()
            .FirstOrDefaultAsync();

        if (userLanguage is null)
            throw new MDCException(404, "UserLanguage is not found");

        return _mapper.Map<UserLanguageForResultDto>(userLanguage);
    }
}
