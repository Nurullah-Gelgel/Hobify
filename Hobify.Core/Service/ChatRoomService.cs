using Hobify.Core.Entity;
using Hobify.Core.Interface.Repository;
using Hobify.Core.Interface.Services;

namespace Hobify.Core.Service
{
    public class ChatRoomService : IChatRoomService
    {
        private readonly IChatRoomRepository _chatRoomRepository;

        public ChatRoomService(IChatRoomRepository chatRoomRepository)
        {
            _chatRoomRepository = chatRoomRepository;
        }
        public async Task<ChatRoom> CreateAsync(ChatRoom chatRoom)
        {
            return await _chatRoomRepository.CreateAsync(chatRoom);
        }

        public async Task<ChatRoom> DeleteAsync(Guid id)
        {
            return await _chatRoomRepository.DeleteAsync(id);
        }

        public async Task<IEnumerable<ChatRoom>> GetAllAsync()
        {
            return await _chatRoomRepository.GetAllAsync();
        }

        public async Task<ChatRoom> GetByIdAsync(Guid id)
        {
            return await _chatRoomRepository.GetByIdAsync(id);
        }

        public async Task<ChatRoom> UpdateAsync(ChatRoom chatRoom)
        {
            return await _chatRoomRepository.UpdateAsync(chatRoom);
        }
    }
}
