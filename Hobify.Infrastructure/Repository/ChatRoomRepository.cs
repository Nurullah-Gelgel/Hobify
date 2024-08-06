using Hobify.Core.Entity;
using Hobify.Core.Interface.Repository;
using Hobify.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Hobify.Infrastructure.Repository
{
    public class ChatRoomRepository : IChatRoomRepository
    {
        private readonly ApplicationDbContext _context;

        public ChatRoomRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<ChatRoom> CreateAsync(ChatRoom chatRoom)
        {
            await _context.ChatRooms.AddAsync(chatRoom);
            await _context.SaveChangesAsync();
            return chatRoom;

        }
           
        public async Task<IEnumerable<ChatRoom>> GetAllAsync()
        {
            return await _context.ChatRooms.ToListAsync();
        }

        public async Task<ChatRoom> GetByIdAsync(Guid id)
        {
            return await _context.ChatRooms.FindAsync(id);
        }

        public async Task<ChatRoom> UpdateAsync(ChatRoom chatRoom)
        {
            _context.ChatRooms.Update(chatRoom);
             await _context.SaveChangesAsync();
            return chatRoom;
        }

        public async Task<ChatRoom> DeleteAsync(Guid id)
        {
            var chatRoom = _context.ChatRooms.Find(id);
            if (chatRoom == null)
            {
                return null;
            }
            _context.ChatRooms.Remove(chatRoom);
            await _context.SaveChangesAsync();
            return chatRoom;
        }

    }
}
