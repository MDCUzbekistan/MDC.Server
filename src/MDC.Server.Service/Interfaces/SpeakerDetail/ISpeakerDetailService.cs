using MDC.Server.Service.DTOs.SpeakerDetails;

namespace MDC.Server.Service.Interfaces.SpeakerDetail
{
    public interface ISpeakerDetailService
    {
        Task<bool> RemoveAsync(long id);
        Task<SpeakerDetailForResultDto> RetrieveByIdAsync (long id);
        Task<IEnumerable<SpeakerDetailForResultDto>> SelectAllAsync();
        Task<SpeakerDetailForResultDto> AddAsync (SpeakerDetailForCreationDto dto);
        Task<SpeakerDetailForResultDto> ModifyAsync (long id, SpeakerDetailForUpdateDto dto);
    }
}
