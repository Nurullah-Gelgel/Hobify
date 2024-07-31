using Hobify.Application.Dto;

namespace Hobify.Application.Interface
{
    public interface ICategoryAppService
    {
        Task<IEnumerable<CategoryDto>> GetAllAsync();
        Task<CategoryDto> GetByIdAsync(Guid id);
        Task<CategoryDto> CreateAsync(CategoryDto category);
        Task<CategoryDto> UpdateAsync(CategoryDto category);
        Task<CategoryDto> DeleteAsync(Guid id);
    }
}
