using AutoMapper;
using MDC.Server.Domain.Entities.Events;
using MDC.Server.Service.DTOs.Events;

namespace MDC.Server.Service.Mappers;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<Event, EventForUpdateDto>().ReverseMap();
        CreateMap<Event, EventForResultDto>().ReverseMap();
        CreateMap<Event, EventForCreationDto>().ReverseMap();
    }
}
