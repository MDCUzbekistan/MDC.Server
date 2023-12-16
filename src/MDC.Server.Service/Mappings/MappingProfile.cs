﻿using AutoMapper;
using MDC.Server.Domain.Entities.Users;
using MDC.Server.Service.DTOs.SpeakerDetails;
using MDC.Server.Service.DTOs.Users;


namespace MDC.Server.Service.Mappings;

public class MappingProfile : Profile
{
    public MappingProfile()
    {

        #region
        CreateMap<User, UserForCreationDto>().ReverseMap();
        CreateMap<User, UserForUpdateDto>().ReverseMap();
        CreateMap<User, UserForResultDto>().ReverseMap();
        #endregion

        // SpeakerDetail
        CreateMap<SpeakerDetail, SpeakerDetailForCreationDto>().ReverseMap();
        CreateMap<SpeakerDetail, SpeakerDetailForUpdateDto>().ReverseMap();
        CreateMap<SpeakerDetail, SpeakerDetailForResultDto>().ReverseMap();


    }
}
