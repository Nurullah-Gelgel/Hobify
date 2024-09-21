using AutoMapper;
using Hobify.Application.Dto;
using Hobify.Application.Interface;
using Hobify.Core.Entity;
using Hobify.Core.Interface.Services;

namespace Hobify.Application.Service
{
    public class SubCategoryAppService : ISubCategoryAppService
    {
        private readonly ISubCategoryService _subCategoryService;
        private readonly IMapper _mapper;


        public SubCategoryAppService(ISubCategoryService subCategoryService, IMapper mapper)
        {
            _subCategoryService = subCategoryService;
            _mapper = mapper;
        }

        public async Task<SubCategoryDto> CreateAsync(SubCategoryDto subCategoryDto)
        {
            var subCategory = _mapper.Map<SubCategory>(subCategoryDto);
            var result = await _subCategoryService.CreateAsync(subCategory);
            return _mapper.Map<SubCategoryDto>(result);
        }
          public async Task<IEnumerable<SubCategoryDto>> GetAllAsync()
        {
            var result = await _subCategoryService.GetAllAsync();
            return _mapper.Map<IEnumerable<SubCategoryDto>>(result);

        }

        public async Task<SubCategoryDto> GetByIdAsync(Guid id)
        {
            var result = await _subCategoryService.GetByIdAsync(id);
            return _mapper.Map<SubCategoryDto>(result);
        }

        public async Task<SubCategoryDto> UpdateAsync(SubCategoryDto subCategoryDto)
        {
            var subCategory = _mapper.Map<SubCategory>(subCategoryDto);
            var result = await _subCategoryService.UpdateAsync(subCategory);
            return _mapper.Map<SubCategoryDto>(result);
        }

        public async Task<SubCategoryDto> DeleteAsync(Guid id)
        {
            var result = await _subCategoryService.DeleteAsync(id);
            return _mapper.Map<SubCategoryDto>(result);
        }

        public async Task<SubCategoryDto> GetByNameAsync(string name)
        {
            var result = await _subCategoryService.GetByNameAsync(name);
            return _mapper.Map<SubCategoryDto>(result);
        }

       

        public async Task<SubCategoryDto> GetCategoryBySubCategoryAsync(Guid categoryId)
        {
            var result = await _subCategoryService.GetCategoryBySubCategoryAsync(categoryId);
            return _mapper.Map<SubCategoryDto>(result);
        }
    }
}
