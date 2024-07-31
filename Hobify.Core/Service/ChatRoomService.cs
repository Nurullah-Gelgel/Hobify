using Hobify.Core.Entity;
using Hobify.Core.Interface.Services;

namespace Hobify.Core.Service
{
    public class ChatRoomService : IChatRoomService
    {
        private readonly IChatRoomService _chatRoomService;

        public ChatRoomService(IChatRoomService chatRoomService)
        {
            _chatRoomService = chatRoomService;
        }
        public async Task<ChatRoom> CreateAsync(ChatRoom chatRoom)
        {
            return await _chatRoomService.CreateAsync(chatRoom);
        }

        public async Task<ChatRoom> DeleteAsync(Guid id)
        {
            return await _chatRoomService.DeleteAsync(id);
        }

        public async Task<IEnumerable<ChatRoom>> GetAllAsync()
        {
            return await _chatRoomService.GetAllAsync();
        }

        public async Task<ChatRoom> GetByIdAsync(Guid id)
        {
            return await _chatRoomService.GetByIdAsync(id);
        }

        public async Task<ChatRoom> UpdateAsync(ChatRoom chatRoom)
        {
            return await _chatRoomService.UpdateAsync(chatRoom);
        }
    }
}
