
using Hobify.Core.Entity;
namespace Hobify.Core.Interface.Repository
{
    public interface IPostRepository
    {
      
        Task<IEnumerable<Post>> GetAllAsync();
        Task<Post> GetByIdAsync(Guid id);
        Task<Post> CreateAsync(Post post);
        Task<Post> UpdateAsync(Post post);
        Task<Post> DeleteAsync(Guid id);
    }
}
