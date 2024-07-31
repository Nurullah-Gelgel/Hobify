using Hobify.Core.Entity;
using Hobify.Core.Interface.Services;

namespace Hobify.Core.Service
{
    public class ForumTopicService : IForumTopicService
    {
        private readonly IForumTopicService _forumTopicService;

        public ForumTopicService(IForumTopicService forumTopicService)
        {
            _forumTopicService = forumTopicService;
        }
        public async Task<ForumTopic> CreateAsync(ForumTopic forumTopic)
        {
            return await _forumTopicService.CreateAsync(forumTopic);
        }

        public async Task<ForumTopic> DeleteAsync(Guid id)
        {
            return await _forumTopicService.DeleteAsync(id);
        }

        public async Task<IEnumerable<ForumTopic>> GetAllAsync()
        {
            return await _forumTopicService.GetAllAsync();
        }

        public async Task<ForumTopic> GetByIdAsync(Guid id)
        {
            return await _forumTopicService.GetByIdAsync(id);
        }

        public async Task<ForumTopic> UpdateAsync(ForumTopic forumTopic)
        {
            return await _forumTopicService.UpdateAsync(forumTopic);
        }
    }
}
