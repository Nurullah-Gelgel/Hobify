using Hobify.Application.Dto;

namespace Hobify.Application.Interface
{
    public interface IChatRoomAppService
    {
        Task<IEnumerable<ChatRoomDto>> GetAllAsync();
        Task<ChatRoomDto> GetByIdAsync(Guid id);
        Task<ChatRoomDto> CreateAsync(ChatRoomDto chatRoomDto);
        Task<ChatRoomDto> UpdateAsync(ChatRoomDto chatRoomDto);
        Task<ChatRoomDto> DeleteAsync(Guid id);
    }
}
