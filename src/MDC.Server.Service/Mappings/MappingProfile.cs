using AutoMapper;
using MDC.Server.Domain.Entities.Communities;
using MDC.Server.Domain.Entities.Events;
using MDC.Server.Domain.Entities.References;
using MDC.Server.Domain.Entities.Users;
using MDC.Server.Service.DTOs.Community;
using MDC.Server.Service.DTOs.CommunityRoles;
using MDC.Server.Service.DTOs.EventRoles;
using MDC.Server.Service.DTOs.Events;
using MDC.Server.Service.DTOs.Languages;
using MDC.Server.Service.DTOs.UserEvents;
using MDC.Server.Service.DTOs.Users;
using MDC.Server.Service.DTOs.CommunityRoles;
using MDC.Server.Service.DTOs.Events;

using MDC.Server.Service.DTOs.EventAssets;

namespace MDC.Server.Service.Mappings;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        #region
        //Users
        CreateMap<User, UserForUpdateDto>().ReverseMap();
        CreateMap<User, UserForResultDto>().ReverseMap();
        CreateMap<User, UserForCreationDto>().ReverseMap();

        // Event
        CreateMap<Event, EventForUpdateDto>().ReverseMap();
        CreateMap<Event, EventForResultDto>().ReverseMap();
        CreateMap<Event, EventForCreationDto>().ReverseMap();

        //EventRole
        CreateMap<EventRole, EventRoleForResultDto>().ReverseMap();
        CreateMap<EventRole, EventRoleForUpdateDto>().ReverseMap();
        CreateMap<EventRole, EventRoleForCreationDto>().ReverseMap();

        // UserEvent
        CreateMap<UserEvent, UserEventForResultDto>().ReverseMap();
        CreateMap<UserEvent, UserEventForUpdateDto>().ReverseMap();
        CreateMap<UserEvent, UserEventForCreationDto>().ReverseMap();

        //Languages
        CreateMap<Language, LanguageForUpdateDto>().ReverseMap();
        CreateMap<Language, LanguageForResultDto>().ReverseMap();
        CreateMap<Language, LanguageForCreationDto>().ReverseMap();

        ///Communities
        CreateMap<Community, CommunityForResultDto>().ReverseMap();
        CreateMap<Community, CommunityForUpdateDto>().ReverseMap();
        CreateMap<Community,CommunityForCreationDto>().ReverseMap();
        CreateMap<CommunityImage, CommunityImageForResultDto>().ReverseMap();
        // Event
        CreateMap<Event, EventForCreationDto>().ReverseMap();
        CreateMap<Event, EventForUpdateDto>().ReverseMap();
        CreateMap<Event, EventForResultDto>().ReverseMap();
        // EventAsset
        CreateMap<EventAsset, EventAssetForCreationDto>().ReverseMap();
        CreateMap<EventAsset, EventAssetForUpdateDto>().ReverseMap();
        CreateMap<EventAsset, EventAssetForResultDto>().ReverseMap();
        #endregion

    }
}
