using Hobify.Core.Entity;
namespace Hobify.Core.Interface.Repository
{
    public interface ISubCategoryRepository
    {
    
        Task<IEnumerable<SubCategory>> GetAllAsync();
        Task<SubCategory> GetByIdAsync(Guid id);
        Task<SubCategory> GetByNameAsync(string name);
        Task<Category> GetCategoryBySubCategoryNameAsync(string subCategoryName);
        Task<SubCategory> CreateAsync(SubCategory subCategory);
        Task<SubCategory> UpdateAsync(SubCategory subCategory);
        Task<SubCategory> DeleteAsync(Guid id);
    }
}
