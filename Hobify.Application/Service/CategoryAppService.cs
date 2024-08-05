using AutoMapper;
using Hobify.Application.Dto;
using Hobify.Application.Interface;
using Hobify.Core.Entity;
using Hobify.Core.Interface.Services;

namespace Hobify.Application.Service
{
    public class CategoryAppService : ICategoryAppService
    {
        private readonly ICategoryService _categoryService;
        private readonly IMapper _mapper;

        public CategoryAppService(ICategoryService categoryService, IMapper mapper)
        {
            _categoryService = categoryService;
            _mapper = mapper;
        }
        public async Task<CategoryDto> CreateAsync(CategoryDto category)
        {
           var newCategory = _mapper.Map<Category>(category);
           var result = await _categoryService.CreateAsync(newCategory);
           return _mapper.Map<CategoryDto>(result);
        }

        public async Task<IEnumerable<CategoryDto>> GetAllAsync()
        {
            var result = await _categoryService.GetAllAsync();
            return _mapper.Map<IEnumerable<CategoryDto>>(result);

        }

        public async Task<CategoryDto> GetByIdAsync(Guid id)
        {
            var result = await _categoryService.GetByIdAsync(id);
            return _mapper.Map<CategoryDto>(result);
        }

        public async Task<CategoryDto> UpdateAsync(CategoryDto category)
        {
            var updatedCategory = _mapper.Map<Category>(category);
            var result = await _categoryService.UpdateAsync(updatedCategory);
            return _mapper.Map<CategoryDto>(result);
        }

        public async Task<CategoryDto> DeleteAsync(Guid id)
        {
            var result = await _categoryService.DeleteAsync(id);
            return _mapper.Map<CategoryDto>(result);
        }

    }
}
