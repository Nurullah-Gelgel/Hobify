using Hobify.Core.Entity;
using Hobify.Core.Interface.Repository;
using Hobify.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Hobify.Infrastructure.Repository
{
    public class ForumTopicRepository : IForumTopicRepository
    {
        private readonly ApplicationDbContext _context;

        public ForumTopicRepository(ApplicationDbContext applicationDbContext)
        {
            _context = applicationDbContext;
        }
        public async Task<ForumTopic> CreateAsync(ForumTopic forumTopic)
        {
            await _context.ForumTopics.AddAsync(forumTopic);
            await _context.SaveChangesAsync();
            return forumTopic;
        }

        public async Task<IEnumerable<ForumTopic>> GetAllAsync()
        {
            return await _context.ForumTopics.ToListAsync();
        }

        public async Task<ForumTopic> GetByIdAsync(Guid id)
        {
            return await _context.ForumTopics.FindAsync(id);

        }

        public async Task<ForumTopic> UpdateAsync(ForumTopic forumTopic)
        {
            _context.ForumTopics.Update(forumTopic);
            await _context.SaveChangesAsync();
            return forumTopic;

        }
        public async Task<ForumTopic> DeleteAsync(Guid id)
        {
            var forumTopic = _context.ForumTopics.Find(id);
            if (forumTopic == null)
            {
                return null;
            }
            _context.ForumTopics.Remove(forumTopic);
            await _context.SaveChangesAsync();
            return forumTopic;
        }
    }
}
