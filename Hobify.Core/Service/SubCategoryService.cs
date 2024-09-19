using Hobify.Core.Entity;
using Hobify.Core.Interface.Repository;
using Hobify.Core.Interface.Services;

namespace Hobify.Core.Service
{
    public class SubCategoryService : ISubCategoryService
    {
        private readonly ISubCategoryRepository _subCategoryRepository;

        public SubCategoryService(ISubCategoryRepository subCategoryRepository)
        {
            _subCategoryRepository = subCategoryRepository;
        }
        public async Task<SubCategory> CreateAsync(SubCategory subCategory)
        {
            return await _subCategoryRepository.CreateAsync(subCategory);
        }

        public async Task<IEnumerable<SubCategory>> GetAllAsync()
        {
            return await _subCategoryRepository.GetAllAsync();
        }

        public async Task<SubCategory> GetByIdAsync(Guid id)
        {
            return await _subCategoryRepository.GetByIdAsync(id);
        }

        public async Task<SubCategory> UpdateAsync(SubCategory subCategory)
        {
            return await _subCategoryRepository.UpdateAsync(subCategory);
        }

        public async Task<SubCategory> DeleteAsync(Guid id)
        {
            return await _subCategoryRepository.DeleteAsync(id);
        }

        public async Task<SubCategory> GetByNameAsync(string name)
        {
            return await _subCategoryRepository.GetByNameAsync(name);
        }

        

        public async Task<Category> GetCategoryBySubCategoryNameAsync(string subCategoryName)
        {
            return await _subCategoryRepository.GetCategoryBySubCategoryNameAsync(subCategoryName);
        }
    }
}
