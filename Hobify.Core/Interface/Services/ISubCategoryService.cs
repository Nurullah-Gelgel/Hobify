using Hobify.Core.Entity;

namespace Hobify.Core.Interface.Services
{
    public interface ISubCategoryService
    {

        Task<IEnumerable<SubCategory>> GetAllAsync();
        Task<SubCategory> GetByIdAsync(Guid id);
        Task<SubCategory> GetByNameAsync(string name);
        Task<SubCategory> GetCategoryBySubCategoryAsync(Guid categoryId);
        Task<SubCategory> CreateAsync(SubCategory subCategory);
        Task<SubCategory> UpdateAsync(SubCategory subCategory);
        Task<SubCategory> DeleteAsync(Guid id);
    }
}
