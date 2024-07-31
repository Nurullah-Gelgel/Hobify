using Hobify.Core.Entity;
namespace Hobify.Core.Interface.Repository
{
    public interface IForumTopicRepository
    {
     
        Task<IEnumerable<ForumTopic>> GetAllAsync();
        Task<ForumTopic> GetByIdAsync(Guid id);
        Task<ForumTopic> CreateAsync(ForumTopic forumTopic);
        Task<ForumTopic> UpdateAsync(ForumTopic forumTopic);
        Task<ForumTopic> DeleteAsync(Guid id);
    }
}
