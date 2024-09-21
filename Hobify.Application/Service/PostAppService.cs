using AutoMapper;
using Hobify.Application.Dto;
using Hobify.Application.Interface;
using Hobify.Core.Entity;
using Hobify.Core.Interface.Services;

namespace Hobify.Application.Service
{
    public class PostAppService : IPostAppService
    {
        private readonly IPostService _postService;
        private readonly IMapper _mapper;

        public PostAppService(IPostService postService, IMapper mapper)
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
            var post = await _postService.GetByIdAsync(id);
            return _mapper.Map<PostDto>(post);
        }

        public async Task<IEnumerable<PostDto>> GetPostsAsync()
        {
            var posts =await _postService.GetAllAsync();
            return _mapper.Map<IEnumerable<PostDto>>(posts);
        }

        public async Task<PostDto> UpdatePostAsync(PostDto postDto)
        {
            var updatedPost = _mapper.Map<Post>(postDto);
           await _postService.UpdateAsync(updatedPost);
            return _mapper.Map<PostDto>(updatedPost);
        }

        public async Task<PostDto> DeletePostAsync(Guid id)
        {
             var post =await _postService.DeleteAsync(id);
             return _mapper.Map<PostDto>(post);
        }

        public async Task<PostDto> GetByTitleAsync(string title)
        {
            var post = await _postService.GetByTitleAsync(title);
            return _mapper.Map<PostDto>(post);
        }

        public async Task<IEnumerable<PostDto>> GetBySubCategoryAsync(Guid subCategoryId)
        {
            var posts = await _postService.GetBySubCategoryAsync(subCategoryId);
            return _mapper.Map<IEnumerable<PostDto>>(posts);
        }
    }
}
