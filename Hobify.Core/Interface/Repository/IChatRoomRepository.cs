using Hobify.Core.Entity;
namespace Hobify.Core.Interface.Repository
{
    public interface IChatRoomRepository
    {
        
        Task<IEnumerable<ChatRoom>> GetAllAsync();
        Task<ChatRoom> GetByIdAsync(Guid id);
        Task<ChatRoom> CreateAsync(ChatRoom chatRoom);
        Task<ChatRoom> UpdateAsync(ChatRoom chatRoom);
        Task<ChatRoom> DeleteAsync(Guid id);
    }
}
