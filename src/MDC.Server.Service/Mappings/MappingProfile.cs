using MDC.Server.Service.DTOs.UserDetails;
using MDC.Server.Domain.Entities.Users;
using AutoMapper;

namespace MDC.Server.Service.Mappings;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        //UserDetail
        CreateMap<UserDetail, UserDetailForCreationDto>().ReverseMap();
        CreateMap<UserDetail, UserDetailForUpdateDto>().ReverseMap();
        CreateMap<UserDetail, UserDetailForResultDto>().ReverseMap();


    }
}
