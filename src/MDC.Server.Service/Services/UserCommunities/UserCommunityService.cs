using AutoMapper;
using Microsoft.EntityFrameworkCore;
using MDC.Server.Data.IRepositories;
using MDC.Server.Service.Exceptions;
using MDC.Server.Domain.Configurations;
using MDC.Server.Service.Commons.Extensions;
using MDC.Server.Domain.Entities.Communities;
using MDC.Server.Service.DTOs.UserCommunities;

namespace MDC.Server.Service.Services.UserCommunities;

public class UserCommunityService : IUserCommunityService
{
    private readonly IMapper _mapper;
    private readonly IUserRepository _userRepository;
    private readonly ICommunityRepository _communityRepository;
    private readonly ICommunityRoleRepository _communityRoleRepository;
    private readonly IUserCommunityRepository _userCommunityRepository;
    public UserCommunityService(
        IMapper mapper,
        IUserRepository userRepository,
        ICommunityRepository communityRepository,
        ICommunityRoleRepository communityRoleRepository,
        IUserCommunityRepository userCommunityRepository)
    {
        _mapper = mapper;
        _userRepository = userRepository;
        _communityRepository = communityRepository;
        _communityRoleRepository = communityRoleRepository;
        _userCommunityRepository = userCommunityRepository;
    }

    public async Task<UserCommunityForResultDto> CreateAsync(UserCommunityForCreationDto dto)
    {
        var user = _userRepository.SelectAll()
            .Where(u => u.Id == dto.UserId)
            .AsNoTracking()
            .FirstOrDefaultAsync();
        if (user is null)
            throw new MDCException(404, "User is not found");

        var community = _communityRepository.SelectAll()
            .Where(c => c.Id == dto.CommunityId)
            .AsNoTracking()
            .FirstOrDefaultAsync();
        if (community is null)
            throw new MDCException(404, "Community is not found");

        var communityRole = _communityRoleRepository.SelectAll()
            .Where(cr => cr.Id == dto.RoleId)
            .AsNoTracking()
            .FirstOrDefaultAsync();
        if (communityRole is null)
            throw new MDCException(404, "CommunityRole is not found");

        var mapped = _mapper.Map<UserCommunity>(dto);
        mapped.CreatedAt = DateTime.UtcNow;
        var result = await _userCommunityRepository.InsertAsync(mapped);

        return _mapper.Map<UserCommunityForResultDto>(result);
    }

    public async Task<UserCommunityForResultDto> ModifyAsync(long id, UserCommunityForUpdateDto dto)
    {
        var user = _userRepository.SelectAll()
            .Where(u => u.Id == dto.UserId)
            .AsNoTracking()
            .FirstOrDefaultAsync();
        if (user is null)
            throw new MDCException(404, "User is not found");

        var community = _communityRepository.SelectAll()
            .Where(c => c.Id == dto.CommunityId)
            .AsNoTracking()
            .FirstOrDefaultAsync();
        if (community is null)
            throw new MDCException(404, "Community is not found");

        var communityRole = _communityRoleRepository.SelectAll()
            .Where(cr => cr.Id == dto.RoleId)
            .AsNoTracking()
            .FirstOrDefaultAsync();
        if (communityRole is null)
            throw new MDCException(404, "CommunityRole is not found");

        var userCommunity = await _userCommunityRepository.SelectAll()
            .Where(uc => uc.Id == id)
            .AsNoTracking()
            .FirstOrDefaultAsync();
        if (userCommunity is null)
            throw new MDCException(404, "UserCommunity is not found");


        var mappedUserCommunity = _mapper.Map(dto, userCommunity);
        mappedUserCommunity.UpdatedAt = DateTime.UtcNow;
        await _userCommunityRepository.UpdateAsync(mappedUserCommunity);

        return _mapper.Map<UserCommunityForResultDto>(mappedUserCommunity);
    }

    public async Task<bool> RemoveAsync(long id)
    {
        var userCommunity = _userCommunityRepository.SelectAll()
            .Where(uc => uc.Id == id)
            .AsNoTracking()
            .FirstOrDefaultAsync();
        if (userCommunity is null)
            throw new MDCException(404, "UserCommunity is not found");

        return await _userCommunityRepository.DeleteAsync(id);
    }

    public async Task<IEnumerable<UserCommunityForResultDto>> RetrieveAllAsync(PaginationParams @params)
    {
        var userCommunity = _userCommunityRepository.SelectAll()
            .Include(uc => uc.User)
            .Include(uc => uc.Community)
            .Include(uc => uc.Role)
            .AsNoTracking()
            .ToPagedList<UserCommunity,long>(@params);

        return _mapper.Map<IEnumerable<UserCommunityForResultDto>>(userCommunity);
    }

    public async Task<UserCommunityForResultDto> RetrieveByIdAsync(long id)
    {
        var userCommunity =  await _userCommunityRepository.SelectAll()
            .Where(uc => uc.Id == id)
            .Include(uc => uc.User)
            .Include(uc => uc.Community)
            .Include(uc => uc.Role)
            .FirstOrDefaultAsync();
        if (userCommunity is null)
            throw new MDCException(404, "UserCommunity is not found");

        return _mapper.Map<UserCommunityForResultDto>(userCommunity);
    }
}
