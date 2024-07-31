using Hobify.Application.Dto;

namespace Hobify.Application.Interface
{
    public interface ISubCategoryAppService
    {
        Task<IEnumerable<SubCategoryDto>> GetAllAsync();
        Task<SubCategoryDto> GetByIdAsync(Guid id);
        Task<SubCategoryDto> CreateAsync(SubCategoryDto subCategoryDto);
        Task<SubCategoryDto> UpdateAsync(SubCategoryDto subCategoryDto);
        Task<SubCategoryDto> DeleteAsync(Guid id);
    }
}
