using Hobify.Core.Entity;
using Hobify.Core.Interface.Repository;
using Hobify.Core.Interface.Services;

namespace Hobify.Core.Service
{
    public class EventsService : IEventsService
    {
        private readonly IEventRepository _events;

        public EventsService(IEventRepository eventRepository)
        {
            _events = eventRepository;
        }
        public async Task<Events> CreateAsync(Events events)
        {
            return await _events.CreateAsync(events);
        }

        public async Task<Events> DeleteAsync(Guid id)
        {
            return await _events.DeleteAsync(id);
        }

        public async Task<IEnumerable<Events>> GetAllAsync()
        {
            return await _events.GetAllAsync();
        }

        public async Task<Events> GetByIdAsync(Guid id)
        {
            return await _events.GetByIdAsync(id);
        }

        public async Task<Events> UpdateAsync(Events events)
        {
            return await _events.UpdateAsync(events);
        }
    }
}
