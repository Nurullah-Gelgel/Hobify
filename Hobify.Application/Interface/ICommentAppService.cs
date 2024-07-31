using Hobify.Application.Dto;

namespace Hobify.Application.Interface
{
    public interface ICommentAppService
    {
        Task<IEnumerable<CommentDto>> GetAllAsync();
        Task<CommentDto> GetByIdAsync(Guid id);
        Task<CommentDto> CreateAsync(CommentDto commentDto);
        Task<CommentDto> UpdateAsync(CommentDto commentDto);
        Task<CommentDto> DeleteAsync(Guid id);
    }
}
