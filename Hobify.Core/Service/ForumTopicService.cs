using Hobify.Core.Entity;
using Hobify.Core.Interface.Repository;
using Hobify.Core.Interface.Services;

namespace Hobify.Core.Service
{
    public class ForumTopicService : IForumTopicService
    {
        private readonly IForumTopicRepository _forumTopicRepository;

        public ForumTopicService(IForumTopicRepository forumTopicRepository)
        {
            _forumTopicRepository = forumTopicRepository;
        }
       
        public async Task<ForumTopic> CreateAsync(ForumTopic forumTopic)
        {
            return await _forumTopicRepository.CreateAsync(forumTopic);
        }

        public async Task<ForumTopic> DeleteAsync(Guid id)
        {
            return await _forumTopicRepository.DeleteAsync(id);
        }

        public async Task<IEnumerable<ForumTopic>> GetAllAsync()
        {
            return await _forumTopicRepository.GetAllAsync();
        }

        public async Task<ForumTopic> GetByIdAsync(Guid id)
        {
            return await _forumTopicRepository.GetByIdAsync(id);
        }

        public async Task<ForumTopic> UpdateAsync(ForumTopic forumTopic)
        {
            return await _forumTopicRepository.UpdateAsync(forumTopic);
        }
    }
}
