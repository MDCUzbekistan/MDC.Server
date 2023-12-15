using AutoMapper;
using MDC.Server.Domain.Entities.Users;
using MDC.Server.Domain.Entities.Events;
using MDC.Server.Service.DTOs.EventRoles;
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

        //EventRole
        CreateMap<EventRole, EventRoleForResultDto>().ReverseMap();
        CreateMap<EventRole, EventRoleForUpdateDto>().ReverseMap();
        CreateMap<EventRole, EventRoleForCreationDto>().ReverseMap();
    }
}
