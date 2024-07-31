using Hobify.Application.Dto;

namespace Hobify.Application.Interface
{
    public interface IProductAppService
    {
        Task<IEnumerable<ProductDto>> GetAllAsync();
        Task<ProductDto> GetByIdAsync(Guid id);
        Task<ProductDto> CreateAsync(ProductDto productDto);
        Task<ProductDto> UpdateAsync(ProductDto productDto);
        Task<ProductDto> DeleteAsync(Guid id);
    }
}
