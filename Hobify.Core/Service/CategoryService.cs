using Hobify.Core.Entity;
using Hobify.Core.Interface.Repository;
using Hobify.Core.Interface.Services;

namespace Hobify.Core.Service
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _repository;

        public CategoryService(ICategoryRepository categoryRepository)
        {
            _repository = categoryRepository;
        }
        public async Task<Category> CreateAsync(Category category)
        {
            return await _repository.CreateAsync(category);
        }

        public async Task<Category> DeleteAsync(Guid id)
        {
            return await _repository.DeleteAsync(id);
        }

        public async Task<IEnumerable<Category>> GetAllAsync()
        {
            return await _repository.GetAllAsync();
        }

        public async Task<Category> GetByIdAsync(Guid id)
        {
            return await _repository.GetByIdAsync(id);
        }

        public async Task<Category> UpdateAsync(Category category)
        {
            return await _repository.UpdateAsync(category);
        }
    }
}
