using Hobify.Core.Entity;

namespace Hobify.Core.Interface.Services
{
    public interface IPostService
    {
        Task<IEnumerable<Post>> GetAllAsync();
        Task<Post> GetByIdAsync(Guid id);
        Task<Post> GetByTitleAsync(string title);
        Task<IEnumerable<Post>> GetBySubCategoryAsync(Guid subCategoryId);
        Task<Post> CreateAsync(Post post);
        Task<Post> UpdateAsync(Post post);
        Task<Post> DeleteAsync(Guid id);
    }
}
