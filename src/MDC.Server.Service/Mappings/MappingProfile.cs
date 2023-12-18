using AutoMapper;
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
 