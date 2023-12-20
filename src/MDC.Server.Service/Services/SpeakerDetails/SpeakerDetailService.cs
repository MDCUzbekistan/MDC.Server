using AutoMapper;
using MDC.Server.Service.Helpers;
using MDC.Server.Data.IRepositories;
using Microsoft.EntityFrameworkCore;
using MDC.Server.Service.Exceptions;
using MDC.Server.Domain.Entities.Users;
using MDC.Server.Service.DTOs.SpeakerDetails;
using MDC.Server.Data.IRepositories.SpeakerDetails;
using MDC.Server.Service.Interfaces.SpeakerDetails;
using MDC.Server.Domain.Configurations;
using MDC.Server.Service.Commons.Extensions;

namespace MDC.Server.Service.Services.SpeakerDetails
{
    public class SpeakerDetailService : ISpeakerDetailService
    {
        #region
        private readonly IMapper _mapper;
        private readonly ISpeakerDetailRepository _speakerDetailRepository;

        public SpeakerDetailService(IMapper mapper,
            ISpeakerDetailRepository speakerDetailRepository)

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

            var speechImageFullPath = Path.Combine(WebHostEnviromentHelper.WebRootPath, removeSpeaker.Result.SpeechImage);

            if (File.Exists(speechImageFullPath))
                File.Delete(speechImageFullPath);

            await _speakerDetailRepository.DeleteAsync(id);

            return true;
        }

        public async Task<SpeakerDetailForResultDto> RetrieveByIdAsync(long id)
        {
            var byIdSpeaker = await _speakerDetailRepository.SelectAll()
                 .Where(s => s.Id == id)
                 .AsNoTracking()
                 .FirstOrDefaultAsync() ??
                     throw new MDCException(404, "Speaker is not found!");

            return _mapper.Map<SpeakerDetailForResultDto>(byIdSpeaker);
        }


        public async Task<IEnumerable<SpeakerDetailForResultDto>> RetrieveAllAsync(PaginationParams @params)
        {
            var allSpeaker = await _speakerDetailRepository.SelectAll()
                .Include(s => s.UserId)
                .AsNoTracking()
                .ToPagedList<SpeakerDetail, long> (@params)
                .ToListAsync();

            return _mapper.Map<IEnumerable<SpeakerDetailForResultDto>>(allSpeaker);
        }


        public async Task<SpeakerDetailForResultDto> AddAsync(SpeakerDetailForCreationDto dto)
        {
            var user = await _speakerDetailRepository.SelectAll()
                 .Where(u => u.UserId == dto.UserId)
                 .AsNoTracking()
                 .FirstOrDefaultAsync();

            if (user != null)
                throw new MDCException(409, "User is alrady exist! ");

            var fileName = Guid.NewGuid().ToString() + Path.GetExtension(dto.SpeechImage.FileName);
            var rootPath = Path.Combine(WebHostEnviromentHelper.WebRootPath, "SpeechImage", fileName);
            using (var stream = new FileStream(rootPath, FileMode.Create))
            {
                await dto.SpeechImage.CopyToAsync(stream);
                await stream.FlushAsync();
                stream.Close();
            }

            var mappedSpeaker = new SpeakerDetail()
            {
                UserId = dto.UserId,
                SpeechImage = Path.Combine("SpeechImage", dto.SpeechImage.FileName),
                CreatedAt = DateTime.UtcNow
            };

         
            var addSpeker = await _speakerDetailRepository.InsertAsync(mappedSpeaker);

            return _mapper.Map<SpeakerDetailForResultDto>(mappedSpeaker);
        }


        public async Task<SpeakerDetailForResultDto> ModifyAsync(long id, SpeakerDetailForUpdateDto dto)
        {
            var updateSpeaker = await _speakerDetailRepository.SelectAll()
                 .Where(s => s.Id == id)
                 .FirstOrDefaultAsync() ??
                    throw new MDCException(404, "Speaker not faund! ");

            var speechImageFullPath = Path.Combine(WebHostEnviromentHelper.WebRootPath, updateSpeaker.SpeechImage);

            if (File.Exists(speechImageFullPath))
                File.Delete(speechImageFullPath);

            var fileName = Guid.NewGuid().ToString() + Path.GetExtension(dto.SpeechImage.FileName);
            var rootPath = Path.Combine(WebHostEnviromentHelper.WebRootPath, "SpeechImage", fileName);
            using (var stream = new FileStream(rootPath, FileMode.Create))
            {
                await dto.SpeechImage.CopyToAsync(stream);
                await stream.FlushAsync();
                stream.Close();
            }

            updateSpeaker.UpdatedAt = DateTime.UtcNow;
            var upSpeaker = _mapper.Map(dto, updateSpeaker);

            return _mapper.Map<SpeakerDetailForResultDto>(upSpeaker);

        }
        #endregion
    }
}
