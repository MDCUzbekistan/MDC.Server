using MDC.Server.Service.DTOs.SpeakerDetails;

namespace MDC.Server.Service.Interfaces.SpeakerDetail
{
    public interface ISpeakerDetailService
    {
        Task<bool> RemoveAsync(long id);
        IQueryable<SpeakerDetailForResultDto> GetAll();
        Task<SpeakerDetailForResultDto> RetrieveByIdAsync (long id);
        Task<SpeakerDetailForResultDto> AddAsync (SpeakerDetailForResultDto dto);
        Task<SpeakerDetailForResultDto> ModifyAsync (SpeakerDetailForUpdateDto dto);


    }
}
