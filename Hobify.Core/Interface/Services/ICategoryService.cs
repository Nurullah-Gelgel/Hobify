using Hobify.Core.Entity;

namespace Hobify.Core.Interface.Services
{
    public interface ICategoryService
    {
        Task<IEnumerable<Category>> GetAllAsync();
        Task<Category> GetByIdAsync(Guid id);
        Task<Category> CreateAsync(Category category);
        Task<Category> UpdateAsync(Category category);
        Task<Category> DeleteAsync(Guid id);
    }
}
