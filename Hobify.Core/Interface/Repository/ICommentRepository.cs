using Hobify.Core.Entity;
namespace Hobify.Core.Interface.Repository
{
    public interface ICommentRepository
    {
      
        Task<IEnumerable<Comment>> GetAllAsync();
        Task<Comment> GetByIdAsync(Guid id);
        Task<Comment> CreateAsync(Comment comment);
        Task<Comment> UpdateAsync(Comment comment);
        Task<Comment> DeleteAsync(Guid id);

    }
}
