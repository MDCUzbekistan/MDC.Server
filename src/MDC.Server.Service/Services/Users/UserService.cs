using AutoMapper;
using MDC.Server.Data.IRepositories;
using MDC.Server.Domain.Entities.Users;
using MDC.Server.Service.DTOs.Users;
using MDC.Server.Service.Exceptions;
using MDC.Server.Service.Interfaces.Users;
using Microsoft.EntityFrameworkCore;
using System.Runtime.Serialization;

namespace MDC.Server.Service.Services.Users;
public class UserService : IUserService
{
    private readonly IUserRepository _userRepository;
    private readonly IMapper _mapper;

    public UserService(IUserRepository repository, IMapper mapper)
    {
        _userRepository = repository;
        _mapper = mapper;
    }


    public async Task<UserForResultDto> AddAsync(UserForCreationDto dto)
    {
        var user = await _userRepository.SelectAll()
                .Where(u => u.Email.ToLower() == dto.Email.ToLower())
                .AsNoTracking()
                .FirstOrDefaultAsync();

        if (user is not null)
            throw new MDCException(409,"User already exists!");

        var mapped = _mapper.Map<User>(dto);
        mapped.CreatedAt = DateTime.UtcNow;

        var result = await _userRepository.InsertAsync(mapped);
       return _mapper.Map<UserForResultDto>(result);
    }

    public async Task<bool> DeleteAsync(long id)
    {
        var user = await _userRepository.SelectAll()
            .Where(u => u.Id==id)
            .AsNoTracking()
            .FirstOrDefaultAsync();

        if (user is null)
            throw new MDCException(404, "User is not found!");

        await _userRepository.DeleteAsync(id);

        return true;
    }

    public async Task<UserForResultDto> ModifyAsync(long id, UserForUpdateDto dto)
    {
        var user = await _userRepository.SelectAll()
            .Where(u => u.Id == id)
            .AsNoTracking()
            .FirstOrDefaultAsync();

        if (user is null)
            throw new MDCException(404, "User is not found!");

        var mapped = _mapper.Map(dto, user);
        mapped.UpdatedAt = DateTime.UtcNow;

        await _userRepository.UpdateAsync(mapped);

        return _mapper.Map<UserForResultDto>(mapped);
    }

    public async Task<IEnumerable<UserForResultDto>> RetrieveAllAsync()
    {
        var users = await _userRepository.SelectAll()
             .ToListAsync();

        return _mapper.Map<IEnumerable<UserForResultDto>>(users);
    }

    public async Task<UserForResultDto> RetrieveByEmailAsync(string email)
    {
       var user = await _userRepository.SelectAll()
           .Where(u => u.Email.ToLower() == email.ToLower())
           .AsNoTracking()
           .FirstOrDefaultAsync();

        if (user is null)
            throw new MDCException(404, "User is not found!");

        return _mapper.Map<UserForResultDto>(user);
    }

    public async Task<UserForResultDto> RetrieveByIdAsync(long id)
    {
        var user = await _userRepository.SelectAll()
            .Where(u => u.Id == id)
            .AsNoTracking()
            .FirstOrDefaultAsync();

        if (user is null)
            throw new MDCException(404, "User is not found!");

        return _mapper.Map<UserForResultDto>(user);
    }
}
