using AutoMapper;
using MDC.Server.Service.DTOs.Users;
using MDC.Server.Domain.Entities.Users;
using MDC.Server.Domain.Entities.Events;
using MDC.Server.Service.DTOs.EventRoles;
using MDC.Server.Service.DTOs.UserEvents;
using MDC.Server.Domain.Entities.Communities;
using MDC.Server.Domain.Entities.References;
using MDC.Server.Domain.Entities.Users;
using MDC.Server.Service.DTOs.Community;
using MDC.Server.Service.DTOs.Languages;
using MDC.Server.Service.DTOs.Users;

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
        
        CreateMap<CommunityRole, CommunityRoleForCreationDto>().ReverseMap();
        CreateMap<CommunityRole, CommunityRoleForUpdateDto>().ReverseMap();
        CreateMap<CommunityRole, CommunityRoleForResultDto>().ReverseMap();
        
        #region
        //Users
        CreateMap<User, UserForCreationDto>().ReverseMap();
        CreateMap<User, UserForUpdateDto>().ReverseMap();
        CreateMap<User, UserForResultDto>().ReverseMap();

        //Languages
        CreateMap<Language, LanguageForCreationDto>().ReverseMap();
        CreateMap<Language, LanguageForUpdateDto>().ReverseMap();
        CreateMap<Language, LanguageForResultDto>().ReverseMap();

        ///Communities
        CreateMap<Community,CommunityForResultDto>().ReverseMap();
        CreateMap<Community, CommunityForUpdateDto>().ReverseMap();
        CreateMap<Community,CommunityForCreationDto>().ReverseMap();
        // Event
        CreateMap<Event, EventForCreationDto>().ReverseMap();
        CreateMap<Event, EventForUpdateDto>().ReverseMap();
        CreateMap<Event, EventForResultDto>().ReverseMap();


        #endregion
        
    }
}
 