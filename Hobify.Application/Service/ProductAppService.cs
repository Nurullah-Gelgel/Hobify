using AutoMapper;
using Hobify.Application.Dto;
using Hobify.Application.Interface;
using Hobify.Core.Entity;
using Hobify.Core.Interface.Services;

namespace Hobify.Application.Service
{
    public class ProductAppService : IProductAppService
    {
        private readonly IProductService productService;
        private readonly IMapper _mapper;

        public ProductAppService(IProductService productService, IMapper mapper)
        {
            this.productService = productService;
            _mapper = mapper;
        }
        public async Task<ProductDto> CreateAsync(ProductDto productDto)
        {
            var product = _mapper.Map<Product>(productDto);
            var productCreated = await productService.CreateAsync(product);
            return _mapper.Map<ProductDto>(productCreated);
        }

        public async Task<IEnumerable<ProductDto>> GetAllAsync()
        {
            var products = await productService.GetAllAsync();
            return _mapper.Map<IEnumerable<ProductDto>>(products);

        }

        public async Task<ProductDto> GetByIdAsync(Guid id)
        {
            var product = await productService.GetByIdAsync(id);
            return _mapper.Map<ProductDto>(product);
        }

        public async Task<ProductDto> UpdateAsync(ProductDto productDto)
        {
            var product = _mapper.Map<Product>(productDto);
            var productUpdated = await productService.UpdateAsync(product);
            return _mapper.Map<ProductDto>(productUpdated);
        }

        public async Task<ProductDto> DeleteAsync(Guid id)
        {
            var productDeleted =await productService.DeleteAsync(id);
            return _mapper.Map<ProductDto>(productDeleted);
        }

    }
}
