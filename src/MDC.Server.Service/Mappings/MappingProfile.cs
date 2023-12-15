using AutoMapper;
using MDC.Server.Domain.Entities.Users;
using MDC.Server.Service.DTOs.UserEvents;

namespace MDC.Server.Service.Mappings;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        // UserEvent
        CreateMap<UserEvent, UserEventForResultDto>().ReverseMap();
        CreateMap<UserEvent, UserEventForUpdateDto>().ReverseMap();
        CreateMap<UserEvent, UserEventForCreationDto>().ReverseMap();

    }
}
