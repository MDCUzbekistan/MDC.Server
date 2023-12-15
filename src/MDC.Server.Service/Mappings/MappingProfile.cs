using AutoMapper;
using MDC.Server.Domain.Entities.Users;
<<<<<<< HEAD
using MDC.Server.Service.DTOs.SpeakerDetails;
=======
using MDC.Server.Service.DTOs.Users;
>>>>>>> 15ba56d1649424411ce562f27f2d01944890147d

namespace MDC.Server.Service.Mappings;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
<<<<<<< HEAD
=======
        #region
        CreateMap<User, UserForCreationDto>().ReverseMap();
        CreateMap<User, UserForUpdateDto>().ReverseMap();
        CreateMap<User, UserForResultDto>().ReverseMap();
        #endregion
>>>>>>> 15ba56d1649424411ce562f27f2d01944890147d
    }
}
