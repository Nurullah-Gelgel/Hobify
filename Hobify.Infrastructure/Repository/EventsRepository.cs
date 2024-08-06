using Hobify.Core.Entity;
using Hobify.Core.Interface.Repository;
using Hobify.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Hobify.Infrastructure.Repository
{
    public class EventsRepository: IEventRepository
    {
        private readonly ApplicationDbContext _context;

        public EventsRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Events> CreateAsync(Events events)
        {
            await _context.Events.AddAsync(events);
            await _context.SaveChangesAsync();
            return events;
        }

        public async Task<IEnumerable<Events>> GetAllAsync()
        {
            return await _context.Events.ToListAsync();
        }

        public async Task<Events> GetByIdAsync(Guid id)
        {
            return await _context.Events.FindAsync(id);
        }

        public async Task<Events> UpdateAsync(Events events)
        {
            _context.Events.Update(events);
            await _context.SaveChangesAsync();
            return events;

        }

        public async Task<Events> DeleteAsync(Guid id)
        {
            var events = _context.Events.Find(id);
            if (events == null)
            {
                return null;
            }
            _context.Events.Remove(events);
            await _context.SaveChangesAsync();
            return events;
        }

    }
}
