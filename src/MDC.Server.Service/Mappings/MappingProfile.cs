using AutoMapper;
using MDC.Server.Service.DTOs.Users;
using MDC.Server.Domain.Entities.Users;
using MDC.Server.Domain.Entities.Events;
using MDC.Server.Service.DTOs.EventRoles;
using MDC.Server.Service.DTOs.UserEvents;
<<<<<<< HEAD
=======
using MDC.Server.Service.DTOs.Users;
>>>>>>> 7a8b8f7a8fa32bbba40309856932631eab124657

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
<<<<<<< HEAD

=======
>>>>>>> 7a8b8f7a8fa32bbba40309856932631eab124657
        #region
        CreateMap<User, UserForCreationDto>().ReverseMap();
        CreateMap<User, UserForUpdateDto>().ReverseMap();
        CreateMap<User, UserForResultDto>().ReverseMap();
        #endregion
    }
}
