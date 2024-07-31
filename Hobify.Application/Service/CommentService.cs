using AutoMapper;
using Hobify.Application.Dto;
using Hobify.Application.Interface;
using Hobify.Core.Entity;
using Hobify.Core.Interface.Services;

namespace Hobify.Application.Service
{
    public class CommentService : ICommentAppService
    {
        private readonly ICommentService _commentService;
        private readonly IMapper _mapper;

        public CommentService(ICommentService commentService, IMapper mapper)
        {
            _commentService = commentService;
            _mapper = mapper;
        }
        public async Task<CommentDto> CreateAsync(CommentDto commentDto)
        {
            var user = _mapper.Map<Comment>(commentDto);
            await _commentService.CreateAsync(user);
            return _mapper.Map<CommentDto>(user);
        }

        public async Task<IEnumerable<CommentDto>> GetAllAsync()
        {
           var comments = await _commentService.GetAllAsync();
           return _mapper.Map<IEnumerable<CommentDto>>(comments);
        }

        public async Task<CommentDto> GetByIdAsync(Guid id)
        {
            var comment =await _commentService.GetByIdAsync(id);
            return _mapper.Map<CommentDto>(comment);
        }

        public async Task<CommentDto> UpdateAsync(CommentDto commentDto)
        {
            var comment = _mapper.Map<Comment>(commentDto);
            await _commentService.UpdateAsync(comment);
            return _mapper.Map<CommentDto>(comment);
        }

        public async Task<CommentDto> DeleteAsync(Guid id)
        {
            var comment = await _commentService.DeleteAsync(id);
            return _mapper.Map<CommentDto>(comment);
        }
    }
}
