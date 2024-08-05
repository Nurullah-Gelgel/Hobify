using AutoMapper;
using Hobify.Application.Dto;
using Hobify.Application.Interface;
using Hobify.Core.Entity;
using Hobify.Core.Interface.Services;

namespace Hobify.Application.Service
{
    public class ChatRoomAppService : IChatRoomAppService
    {
        private readonly IChatRoomService _chatRoomService;
        private readonly IMapper _mapper;

        public ChatRoomAppService(IChatRoomService chatRoomService, IMapper mapper)
        {
            _chatRoomService = chatRoomService;
            _mapper = mapper;
        }
        public async Task<ChatRoomDto> CreateAsync(ChatRoomDto chatRoomDto)
        {
            var chatRoom = _mapper.Map<ChatRoom>(chatRoomDto);
            var result = await _chatRoomService.CreateAsync(chatRoom);
            return _mapper.Map<ChatRoomDto>(result);
        }

   
        public async Task<IEnumerable<ChatRoomDto>> GetAllAsync()
        {
            var result = await _chatRoomService.GetAllAsync();
            return _mapper.Map<IEnumerable<ChatRoomDto>>(result);
        }

        public async Task<ChatRoomDto> GetByIdAsync(Guid id)
        {
            var result = await _chatRoomService.GetByIdAsync(id);
            return _mapper.Map<ChatRoomDto>(result);
        }

        public async Task<ChatRoomDto> UpdateAsync(ChatRoomDto chatRoomDto)
        {
            var chatRoom = _mapper.Map<ChatRoom>(chatRoomDto);
            var result = await _chatRoomService.UpdateAsync(chatRoom);
            return _mapper.Map<ChatRoomDto>(result);
        }
        public async Task<ChatRoomDto> DeleteAsync(Guid id)
        {
            var result = await _chatRoomService.DeleteAsync(id);
            return _mapper.Map<ChatRoomDto>(result);
        }

    }
}
