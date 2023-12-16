using AutoMapper;
using System.Data;
using MDC.Server.Data.IRepositories;
using MDC.Server.Service.Exceptions;
using Microsoft.EntityFrameworkCore;
using MDC.Server.Domain.Entities.Users;
using MDC.Server.Service.DTOs.SpeakerDetails;
using MDC.Server.Service.Interfaces.SpeakerDetails;

namespace MDC.Server.Service.Services.SpeakerDetailServices
{
    public class SpeakerDetailService : ISpeakerDetailService
    {
        #region
        private readonly IMapper _mapper;
        private readonly IRepository<SpeakerDetail, long> _speakerDetailRepository;

        public SpeakerDetailService(IMapper mapper,IRepository<SpeakerDetail, long> speakerDetailRepository)
        {
            _mapper = mapper;
            _speakerDetailRepository = speakerDetailRepository;
        }

        public async Task<bool> RemoveAsync(long id)
        {
            var removeSpeaker = _speakerDetailRepository.SelectAll()
                 .Where(s => s.Id == id)
                 .FirstOrDefaultAsync() ??
                    throw new MDCException(404, "Speaker is not found! ");

            await _speakerDetailRepository.DeleteAsync(id);
            return true;
        }

        public async Task<SpeakerDetailForResultDto> RetrieveByIdAsync(long id)
        {
            var byIdSpeaker = await _speakerDetailRepository.SelectAll()
                 .Where(s => s.Id == id)
                 .FirstOrDefaultAsync() ??
                     throw new MDCException(404, "Speaker is not found!");

            return _mapper.Map<SpeakerDetailForResultDto>(byIdSpeaker);
        }


        public async Task<IEnumerable<SpeakerDetailForResultDto>> RetrieveAllAsync()
        {
           var allSpeaker = await _speakerDetailRepository.SelectAll()
                .ToListAsync();
            return _mapper.Map <IEnumerable<SpeakerDetailForResultDto>> (allSpeaker);
        }


        public async Task<SpeakerDetailForResultDto> AddAsync(SpeakerDetailForCreationDto dto)
        {
            var speaker = await _speakerDetailRepository.SelectAll()
                 .Where(s => s.ExperienceYear == dto.ExperienceYear && s.ExperienceYear >= 5)
                 .FirstOrDefaultAsync();

            if(speaker != null)
               throw new MDCException(409, "Speaker is alrady exist! ");

            var mappedSpeaker = _mapper.Map<SpeakerDetail>(dto);
            mappedSpeaker.CreatedAt = DateTime.UtcNow;

            var addSpeker = await _speakerDetailRepository.InsertAsync(mappedSpeaker);
            return _mapper.Map<SpeakerDetailForResultDto>(mappedSpeaker);
        }


        public async Task<SpeakerDetailForResultDto> ModifyAsync(long id,SpeakerDetailForUpdateDto dto)
        {
            var updateSpeaker = await _speakerDetailRepository.SelectAll()
                 .Where(s => s.Id == id)
                 .FirstOrDefaultAsync()??
                    throw new MDCException(404, "Speaker not faund! ");

            updateSpeaker.UpdatedAt = DateTime.UtcNow;
            var upSpeaker = _mapper.Map(dto, updateSpeaker);

            await _speakerDetailRepository.UpdateAsync(upSpeaker);
            return _mapper.Map<SpeakerDetailForResultDto>(upSpeaker);
        }
        #endregion
    }
}
