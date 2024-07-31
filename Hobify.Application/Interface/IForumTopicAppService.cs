using Hobify.Application.Dto;

namespace Hobify.Application.Interface
{
    public interface IForumTopicAppService
    {
        Task<ForumTopicDto> CreateForumTopic(ForumTopicDto forumTopicDto);
        Task<ForumTopicDto> UpdateForumTopic(ForumTopicDto forumTopicDto);
        Task<ForumTopicDto> DeleteForumTopic(Guid id);
        Task<ForumTopicDto> GetForumTopic(Guid id);
        Task<IEnumerable<ForumTopicDto>> GetForumTopics();
    }
}
