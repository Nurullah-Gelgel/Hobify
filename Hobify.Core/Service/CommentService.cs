using Hobify.Core.Entity;
using Hobify.Core.Interface.Services;

namespace Hobify.Core.Service
{
    public class CommentService : ICommentService
    {
        private readonly ICommentService _commentService;

        public CommentService(ICommentService commentService)
        {
            _commentService = commentService;
        }
        public async Task<Comment> CreateAsync(Comment comment)
        {
            return await _commentService.CreateAsync(comment);
        }

        public async Task<Comment> DeleteAsync(Guid id)
        {
            return await _commentService.DeleteAsync(id);
        }

        public async Task<IEnumerable<Comment>> GetAllAsync()
        {
            return await _commentService.GetAllAsync();
        }

        public async Task<Comment> GetByIdAsync(Guid id)
        {
            return await _commentService.GetByIdAsync(id);
        }

        public async Task<Comment> UpdateAsync(Comment comment)
        {
            return await _commentService.UpdateAsync(comment);
        }
    }
}
