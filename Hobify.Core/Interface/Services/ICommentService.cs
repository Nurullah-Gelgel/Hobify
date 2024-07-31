using Hobify.Core.Entity;

namespace Hobify.Core.Interface.Services
{
    public interface ICommentService
    {
        Task<IEnumerable<Comment>> GetAllAsync();
        Task<Comment> GetByIdAsync(Guid id);
        Task<Comment> CreateAsync(Comment comment);
        Task<Comment> UpdateAsync(Comment comment);
        Task<Comment> DeleteAsync(Guid id);
    }
}
