using Hobify.Application.Dto;
using Hobify.Core.Entity;

namespace Hobify.Application.Interface
{
    public interface ISubCategoryAppService
    {
        Task<IEnumerable<SubCategoryDto>> GetAllAsync();
        Task<SubCategoryDto> GetByIdAsync(Guid id);
        Task<SubCategoryDto> GetByNameAsync(string name);
        Task<Category> GetCategoryBySubCategoryNameAsync(string subCategoryName);
        Task<SubCategoryDto> CreateAsync(SubCategoryDto subCategoryDto);
        Task<SubCategoryDto> UpdateAsync(SubCategoryDto subCategoryDto);
        Task<SubCategoryDto> DeleteAsync(Guid id);
    }
}
