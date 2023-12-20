using MDC.Server.Service.DTOs.SpeakerDetails;

namespace MDC.Server.Service.Interfaces.SpeakerDetails
{
    public interface ISpeakerDetailService
    {
        Task<bool> RemoveAsync(string id);
        Task<SpeakerDetailForResultDto> RetrieveByIdAsync(string id);
        Task<IEnumerable<SpeakerDetailForResultDto>> RetrieveAllAsync();
        Task<SpeakerDetailForResultDto> AddAsync(SpeakerDetailForCreationDto dto);
        Task<SpeakerDetailForResultDto> ModifyAsync(string id, SpeakerDetailForUpdateDto dto);
    }
}
