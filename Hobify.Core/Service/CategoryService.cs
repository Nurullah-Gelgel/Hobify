using Hobify.Core.Entity;
using Hobify.Core.Interface.Services;

namespace Hobify.Core.Service
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryService _categoryService;

        public CategoryService(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }
        public async Task<Category> CreateAsync(Category category)
        {
            return await _categoryService.CreateAsync(category);
        }

        public async Task<Category> DeleteAsync(Guid id)
        {
            return await _categoryService.DeleteAsync(id);
        }

        public async Task<IEnumerable<Category>> GetAllAsync()
        {
            return await _categoryService.GetAllAsync();
        }

        public async Task<Category> GetByIdAsync(Guid id)
        {
            return await _categoryService.GetByIdAsync(id);
        }

        public async Task<Category> UpdateAsync(Category category)
        {
            return await _categoryService.UpdateAsync(category);
        }
    }
}
