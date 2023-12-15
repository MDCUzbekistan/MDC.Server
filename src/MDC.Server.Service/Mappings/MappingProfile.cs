using AutoMapper;
using MDC.Server.Domain.Entities.Communities;
using MDC.Server.Service.DTOs.CommunityRoles;

namespace MDC.Server.Service.Mappings;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<CommunityRole, CommunityRoleForCreationDto>().ReverseMap();
        CreateMap<CommunityRole, CommunityRoleForUpdateDto>().ReverseMap();
        CreateMap<CommunityRole, CommunityRoleForResultDto>().ReverseMap();
    }
}
 