using Hobify.Core.Entity;
using Hobify.Core.Interface.Repository;
using Hobify.Core.Interface.Services;

namespace Hobify.Core.Service
{
    public class PostService : IPostService
    {
        private readonly IPostRepository _postRepository;

        public PostService(IPostRepository postRepository)
        {
            _postRepository = postRepository;
        }
        public async Task<Post> CreateAsync(Post post)
        {
            return await _postRepository.CreateAsync(post);
       }

        public async Task<Post> DeleteAsync(Guid id)
        {
            return await _postRepository.DeleteAsync(id);
        }

        public async Task<IEnumerable<Post>> GetAllAsync()
        {
            return await _postRepository.GetAllAsync();
        }

        public async Task<Post> GetByIdAsync(Guid id)
        {
            return await _postRepository.GetByIdAsync(id);
        }

        public async Task<Post> UpdateAsync(Post post)
        {
            return await _postRepository.UpdateAsync(post);
        }
    }
}
