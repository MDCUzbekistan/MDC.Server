using AutoMapper;
using MDC.Server.Domain.Entities.Events;
using MDC.Server.Domain.Entities.References;
using MDC.Server.Domain.Entities.Users;
using MDC.Server.Service.DTOs.Events;
using MDC.Server.Service.DTOs.Languages;
using MDC.Server.Service.DTOs.Users;

namespace MDC.Server.Service.Mappings;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        #region
        //Users
        CreateMap<User, UserForCreationDto>().ReverseMap();
        CreateMap<User, UserForUpdateDto>().ReverseMap();
        CreateMap<User, UserForResultDto>().ReverseMap();

        //Languages
        CreateMap<Language, LanguageForCreationDto>().ReverseMap();
        CreateMap<Language, LanguageForUpdateDto>().ReverseMap();
        CreateMap<Language, LanguageForResultDto>().ReverseMap();

        // Event
        CreateMap<Event, EventForCreationDto>().ReverseMap();
        CreateMap<Event, EventForUpdateDto>().ReverseMap();
        CreateMap<Event, EventForResultDto>().ReverseMap();


        #endregion
    }
}
