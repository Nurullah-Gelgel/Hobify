using Hobify.Core.Entity;

namespace Hobify.Core.Interface.Services
{
    public interface IProductService
    {

        Task<IEnumerable<Product>> GetAllAsync();
        Task<Product> GetByIdAsync(Guid id);
        Task<Product> CreateAsync(Product product);
        Task<Product> UpdateAsync(Product product);
        Task<Product> DeleteAsync(Guid id);
       
    }
}
