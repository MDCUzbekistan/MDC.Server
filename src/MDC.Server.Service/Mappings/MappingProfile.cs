using AutoMapper;
using MDC.Server.Domain.Entities.Users;
using MDC.Server.Service.DTOs.SpeakerDetails;

namespace MDC.Server.Service.Mappings;

public class MappingProfile : Profile
{
    public MappingProfile()
    {

        //SpeakerDetail

        CreateMap<SpeakerDetail, SpeakerDetailForCreationDto>().ReverseMap();
        CreateMap<SpeakerDetail, SpeakerDetailForResultDto>().ReverseMap();
        CreateMap<SpeakerDetail, SpeakerDetailForUpdateDto>().ReverseMap();
    }
}
