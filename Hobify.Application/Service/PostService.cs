using AutoMapper;
using Hobify.Application.Dto;
using Hobify.Application.Interface;
using Hobify.Core.Entity;
using Hobify.Core.Interface.Services;

namespace Hobify.Application.Service
{
    public class PostService : IPostAppService
    {
        private readonly IPostService _postService;
        private readonly IMapper _mapper;

        public PostService(IPostService postService, IMapper mapper)
        {
            _postService = postService;
            _mapper = mapper;
        }
        public async Task<PostDto> CreatePostAsync(PostDto postDto)
        {
            var post = _mapper.Map<Post>(postDto);
            await _postService.CreateAsync(post);
            return _mapper.Map<PostDto>(post);
        }

        public async Task<PostDto> GetPostByIdAsync(Guid id)
        {
            var post = _postService.GetByIdAsync(id);
            return _mapper.Map<PostDto>(post);
        }

        public async Task<IEnumerable<PostDto>> GetPostsAsync()
        {
            var posts = _postService.GetAllAsync();
            return _mapper.Map<IEnumerable<PostDto>>(posts);
        }

        public async Task<PostDto> UpdatePostAsync(PostDto postDto)
        {
            var updatedPost = _mapper.Map<Post>(postDto);
            var post = _postService.UpdateAsync(updatedPost);
            return _mapper.Map<PostDto>(post);
        }

        public async Task<PostDto> DeletePostAsync(Guid id)
        {
             var post = _postService.DeleteAsync(id);
             return _mapper.Map<PostDto>(post);
        }
    }
}
