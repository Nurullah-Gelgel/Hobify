using Hobify.Application.Dto;
using Hobify.Core.Entity;

namespace Hobify.Application.Interface
{
    public interface IPostAppService
    {
        Task<IEnumerable<PostDto>> GetPostsAsync();
        Task<PostDto> GetPostByIdAsync(Guid id);
        Task<PostDto> GetByTitleAsync(string title);
        Task<IEnumerable<PostDto>> GetBySubCategoryAsync(Guid subCategoryId);
        Task<PostDto> CreatePostAsync(PostDto postDto);
        Task<PostDto> UpdatePostAsync(PostDto postDto);
        Task<PostDto> DeletePostAsync(Guid id);

    }
}
