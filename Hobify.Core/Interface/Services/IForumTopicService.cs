using Hobify.Core.Entity;

namespace Hobify.Core.Interface.Services
{
    public interface IForumTopicService
    {
        Task<IEnumerable<ForumTopic>> GetAllAsync();
        Task<ForumTopic> GetByIdAsync(Guid id);
        Task<ForumTopic> CreateAsync(ForumTopic forumTopic);
        Task<ForumTopic> UpdateAsync(ForumTopic forumTopic);
        Task<ForumTopic> DeleteAsync(Guid id);
    }
}
