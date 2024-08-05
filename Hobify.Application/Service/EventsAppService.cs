using AutoMapper;
using Hobify.Application.Dto;
using Hobify.Application.Interface;
using Hobify.Core.Entity;
using Hobify.Core.Interface.Services;

namespace Hobify.Application.Service
{
    public class EventsAppService : IEventsAppService
    {
        private readonly IEventsService _eventsService;
        private readonly IMapper _mapper;

        public EventsAppService(IEventsService eventsService, IMapper mapper)
        {
            _eventsService = eventsService;
            _mapper = mapper;
        }
        public async Task<EventsDto> CreateAsync(EventsDto eventDto)
        {
            var eventEntity = _mapper.Map<Events>(eventDto);
            var result = await _eventsService.CreateAsync(eventEntity);
            return _mapper.Map<EventsDto>(result);
        }

        public async Task<IEnumerable<EventsDto>> GetAllAsync()
        {
            var result = await _eventsService.GetAllAsync();
            return _mapper.Map<IEnumerable<EventsDto>>(result);
        }

        public async Task<EventsDto> GetByIdAsync(Guid id)
        {
            
            var result = await _eventsService.GetByIdAsync(id);
            return _mapper.Map<EventsDto>(result);
        }

        public async Task<EventsDto> UpdateAsync(EventsDto eventDto)
        {
            var eventEntity = _mapper.Map<Events>(eventDto);
            var result = _eventsService.UpdateAsync(eventEntity);
            return _mapper.Map<EventsDto>(result);
        }

        public async Task<EventsDto> DeleteAsync(Guid id)
        {
            var result = await _eventsService.DeleteAsync(id);
            return _mapper.Map<EventsDto>(result);
        }

    }
}
