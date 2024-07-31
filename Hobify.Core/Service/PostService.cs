using Hobify.Core.Entity;
using Hobify.Core.Interface.Services;

namespace Hobify.Core.Service
{
    public class PostService : IPostService
    {
        private readonly IPostService _postService;

        public PostService(IPostService postService)
        {
            _postService = postService;
        }
        public async Task<Post> CreateAsync(Post post)
        {
            return await _postService.CreateAsync(post);
       }

        public async Task<Post> DeleteAsync(Guid id)
        {
            return await _postService.DeleteAsync(id);
        }

        public async Task<IEnumerable<Post>> GetAllAsync()
        {
            return await _postService.GetAllAsync();
        }

        public async Task<Post> GetByIdAsync(Guid id)
        {
            return await _postService.GetByIdAsync(id);
        }

        public async Task<Post> UpdateAsync(Post post)
        {
            return await _postService.UpdateAsync(post);
        }
    }
}
