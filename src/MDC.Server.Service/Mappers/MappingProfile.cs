using AutoMapper;
using MDC.Server.Domain.Entities.Communities;
using MDC.Server.Service.DTOs.Community;

namespace MDC.Server.Service.Mappings;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<Community,CommunityForUpdateDto>().ReverseMap();
        CreateMap<Community,CommunityForResultDto>().ReverseMap();
        CreateMap<Community,CommunityForCreationDto>().ReverseMap();
    }
}
