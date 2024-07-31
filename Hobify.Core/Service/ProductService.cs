using Hobify.Core.Entity;
using Hobify.Core.Interface.Services;

namespace Hobify.Core.Service
{
    public class ProductService : IProductService
    {
        private readonly IProductService _productService;

        public ProductService(IProductService productService)
        {
            _productService = productService;
        }
        public async Task<Product> CreateAsync(Product product)
        {
            return await _productService.CreateAsync(product);
        }

        public async Task<Product> DeleteAsync(Guid id)
        {
            return await _productService.DeleteAsync(id);
        }

        public async Task<IEnumerable<Product>> GetAllAsync()
        {
            return await _productService.GetAllAsync();
        }

        public async Task<Product> GetByIdAsync(Guid id)
        {
            return await _productService.GetByIdAsync(id);
        }

        public async Task<Product> UpdateAsync(Product product)
        {
            return await _productService.UpdateAsync(product);
        }
    }
}
