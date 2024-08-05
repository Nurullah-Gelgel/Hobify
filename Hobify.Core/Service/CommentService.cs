using Hobify.Core.Entity;
using Hobify.Core.Interface.Repository;
using Hobify.Core.Interface.Services;

namespace Hobify.Core.Service
{
    public class CommentService : ICommentService
    {
        private readonly ICommentRepository _comment;

        public CommentService(ICommentRepository commentRepository)
        {
            _comment = commentRepository;
        }
        public async Task<Comment> CreateAsync(Comment comment)
        {
            return await _comment.CreateAsync(comment);
        }

        public async Task<Comment> DeleteAsync(Guid id)
        {
            return await _comment.DeleteAsync(id);
        }

        public async Task<IEnumerable<Comment>> GetAllAsync()
        {
            return await _comment.GetAllAsync();
        }

        public async Task<Comment> GetByIdAsync(Guid id)
        {
            return await _comment.GetByIdAsync(id);
        }

        public async Task<Comment> UpdateAsync(Comment comment)
        {
            return await _comment.UpdateAsync(comment);
        }
    }
}
