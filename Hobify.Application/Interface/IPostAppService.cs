using Hobify.Application.Dto;

namespace Hobify.Application.Interface
{
    public interface IPostAppService
    {
        Task<IEnumerable<PostDto>> GetPostsAsync();
        Task<PostDto> GetPostByIdAsync(Guid id);
        Task<PostDto> CreatePostAsync(PostDto postDto);
        Task<PostDto> UpdatePostAsync(PostDto postDto);
        Task<PostDto> DeletePostAsync(Guid id);

    }
}
