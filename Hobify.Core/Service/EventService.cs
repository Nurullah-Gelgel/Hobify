using Hobify.Core.Entity;
using Hobify.Core.Interface.Services;

namespace Hobify.Core.Service
{
    public class EventsService : IEventsService
    {
        private readonly IEventsService _eventsService;

        public EventsService(IEventsService eventsService)
        {
            _eventsService = eventsService;
        }
        public async Task<Events> CreateAsync(Events events)
        {
            return await _eventsService.CreateAsync(events);
        }

        public async Task<Events> DeleteAsync(Guid id)
        {
            return await _eventsService.DeleteAsync(id);
        }

        public async Task<IEnumerable<Events>> GetAllAsync()
        {
            return await _eventsService.GetAllAsync();
        }

        public async Task<Events> GetByIdAsync(Guid id)
        {
            return await _eventsService.GetByIdAsync(id);
        }

        public async Task<Events> UpdateAsync(Events events)
        {
            return await _eventsService.UpdateAsync(events);
        }
    }
}
