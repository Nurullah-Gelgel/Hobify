using Hobify.Core.Entity;
using Hobify.Core.Interface.Repository;
using Hobify.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Hobify.Infrastructure.Repository
{
    public class UserRepository : IUserRepository 
    {
        private readonly ApplicationDbContext _context;

        public UserRepository(ApplicationDbContext context)
        {
               _context = context;
        }
        public async Task<User> CreateAsync(User user)
        {
            await _context.Users.AddAsync(user);
            await _context.SaveChangesAsync();
            return user;
        }

       

        public async Task<IEnumerable<User>> GetAllAsync()
        {
            await _context.Users.ToListAsync();
            return _context.Users;

        }

        public async Task<User> GetByIdAsync(Guid id)
        {
            return await _context.Users.FindAsync(id);

        }

        public async Task<User> UpdateAsync(User user)
        {
            _context.Users.Update(user);
            await _context.SaveChangesAsync();
            return user;
        }

        public async Task<User> DeleteAsync(Guid id)
        {
           var user = await _context.Users.FindAsync(id);
            _context.Users.Remove(user);
            await _context.SaveChangesAsync();
            return user;
            
        }
    }
}
