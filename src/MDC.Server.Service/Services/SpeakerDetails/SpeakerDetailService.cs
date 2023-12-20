using AutoMapper;
using MDC.Server.Service.Helpers;
using Microsoft.EntityFrameworkCore;
using MDC.Server.Service.Exceptions;
using MDC.Server.Domain.Configurations;
using MDC.Server.Domain.Entities.Users;
using MDC.Server.Service.Commons.Extensions;
using MDC.Server.Service.DTOs.SpeakerDetails;
using MDC.Server.Data.IRepositories.SpeakerDetails;
using MDC.Server.Service.Interfaces.SpeakerDetails;

namespace MDC.Server.Service.Services.SpeakerDetails
{
    public class SpeakerDetailService : ISpeakerDetailService
    {
        #region
        private readonly IMapper _mapper;
        private readonly ISpeakerDetailRepository _speakerDetailRepository;

        public SpeakerDetailService(IMapper mapper, ISpeakerDetailRepository speakerDetailRepository)
        {
            _mapper = mapper;
            _speakerDetailRepository = speakerDetailRepository;
        }

        public async Task<SpeakerDetailForResultDto> AddAsync(SpeakerDetailForCreationDto dto)
        {
            var addSpeaker = await _speakerDetailRepository.SelectAll()
                 .Where(sd => sd.UserId == dto.UserId)
                 .AsNoTracking()
                 .FirstOrDefaultAsync();

            if (addSpeaker is not null)
                throw new MDCException(409, "Speaker is already exist! ");

            var fileName = Guid.NewGuid().ToString("N") + Path.GetExtension(dto.SpeechImage.FileName);
            var rootPath = Path.Combine(WebHostEnviromentHelper.WebRootPath, "Media","SpeakerDetails", "SpeechImages", fileName);
            using (var stream = new FileStream(rootPath, FileMode.Create))
            {
                await dto.SpeechImage.CopyToAsync(stream);
                await stream.FlushAsync();
                stream.Close();
            }
            string resultImage = Path.Combine("Media","SpeakerDetails", "SpeechImages", fileName);

            var mapped = _mapper.Map<SpeakerDetail>(dto);
            mapped.SpeechImage = resultImage;
            var addSpeker = await _speakerDetailRepository.InsertAsync(mapped);

            return _mapper.Map<SpeakerDetailForResultDto>(addSpeker);
        }


        public async Task<IEnumerable<SpeakerDetailForResultDto>> RetrieveAllAsync(PaginationParams @params)
        {
            var allSpeaker = await _speakerDetailRepository.SelectAll()
                .Include(sd => sd.UserId)
                .AsNoTracking()
                .ToPagedList<SpeakerDetail, long> (@params)
                .ToListAsync();

            return _mapper.Map<IEnumerable<SpeakerDetailForResultDto>>(allSpeaker);
        }


        public async Task<SpeakerDetailForResultDto> RetrieveByIdAsync(long id)
        {
            var byIdSpeaker = await _speakerDetailRepository.SelectAll()
                 .Where(sd => sd.Id == id)
                 .AsNoTracking()
                 .FirstOrDefaultAsync() ??
                     throw new MDCException(404, "Speaker is not found!");

            return _mapper.Map<SpeakerDetailForResultDto>(byIdSpeaker);
        }


        public async Task<SpeakerDetailForResultDto> ModifyAsync(long id, SpeakerDetailForUpdateDto dto)
        {
            var updateSpeaker = await _speakerDetailRepository.SelectAll()
                 .Where(sd => sd.Id == id)
                 .FirstOrDefaultAsync() ??
                    throw new MDCException(404, "Speaker not faund! ");

            var speechImageFullPath = Path.Combine(WebHostEnviromentHelper.WebRootPath, updateSpeaker.SpeechImage);

            if (File.Exists(speechImageFullPath))
                File.Delete(speechImageFullPath);


            var fileName = Guid.NewGuid().ToString("N") + Path.GetExtension(dto.SpeechImage.FileName);
            var rootPath = Path.Combine(WebHostEnviromentHelper.WebRootPath, "Media", "SpeakerDetails", "SpeechImages", fileName);
            using (var stream = new FileStream(rootPath, FileMode.Create))
            {
                await dto.SpeechImage.CopyToAsync(stream);
                await stream.FlushAsync();
                stream.Close();
            }
            string resultSpeechImage = Path.Combine("Media", "SpeakerDetails", "SpeechImages", fileName);

            var mappedSpeakerDetail = this._mapper.Map(dto, updateSpeaker);
            mappedSpeakerDetail.UpdatedAt = DateTime.UtcNow;

            mappedSpeakerDetail.SpeechImage = resultSpeechImage;

            await this._speakerDetailRepository.UpdateAsync(mappedSpeakerDetail);

            return _mapper.Map<SpeakerDetailForResultDto>(mappedSpeakerDetail);

        }


        public async Task<bool> RemoveAsync(long id)
        {
            var removeSpeaker = _speakerDetailRepository.SelectAll()
                 .Where(sd => sd.Id == id)
                 .FirstOrDefaultAsync() ??
                    throw new MDCException(404, "Speaker is not found! ");

            var speechImageFullPath = Path.Combine(WebHostEnviromentHelper.WebRootPath, removeSpeaker.Result.SpeechImage);

            if (File.Exists(speechImageFullPath))
                File.Delete(speechImageFullPath);

            await _speakerDetailRepository.DeleteAsync(id);

            return true;
        }

        #endregion
    }
}
