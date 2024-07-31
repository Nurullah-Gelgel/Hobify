using AutoMapper;
using Hobify.Application.Dto;
using Hobify.Application.Interface;
using Hobify.Core.Entity;
using Hobify.Core.Interface.Services;

namespace Hobify.Application.Service
{
    public class ForumTopicService : IForumTopicAppService
    {
        private readonly IForumTopicService forumTopicService;
        private readonly IMapper mapper;

        public ForumTopicService(IForumTopicService forumTopicService, IMapper mapper)
        {
            this.forumTopicService = forumTopicService;
            this.mapper = mapper;
        }
        public async Task<ForumTopicDto> CreateForumTopic(ForumTopicDto forumTopicDto)
        {
            var forumTopic = mapper.Map<ForumTopic>(forumTopicDto);
            var createdForumTopic = await forumTopicService.CreateAsync(forumTopic);
            return mapper.Map<ForumTopicDto>(createdForumTopic);
        }

        public async Task<ForumTopicDto> GetForumTopic(Guid id)
        {
            var forumTopic = await forumTopicService.GetByIdAsync(id);
            return mapper.Map<ForumTopicDto>(forumTopic);
        }

        public async Task<IEnumerable<ForumTopicDto>> GetForumTopics()
        {
            var forumTopics = await forumTopicService.GetAllAsync();
            return mapper.Map<IEnumerable<ForumTopicDto>>(forumTopics);
        }

        public async Task<ForumTopicDto> UpdateForumTopic(ForumTopicDto forumTopicDto)
        {
            var forumTopic = mapper.Map<ForumTopic>(forumTopicDto);
            var updatedForumTopic = await forumTopicService.UpdateAsync(forumTopic);
            return mapper.Map<ForumTopicDto>(updatedForumTopic);
        }
        public async Task<ForumTopicDto> DeleteForumTopic(Guid id)
        {
            var deletedForumTopic = await forumTopicService.DeleteAsync(id);
            return mapper.Map<ForumTopicDto>(deletedForumTopic);
        }

    }
}
