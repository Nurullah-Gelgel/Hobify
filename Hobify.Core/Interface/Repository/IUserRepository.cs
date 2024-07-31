using Hobify.Core.Entity;

namespace Hobify.Core.Interface.Repository
{
    public interface IUserRepository
    {
        
        Task<IEnumerable<User>> GetAllAsync();
        Task<User> GetByIdAsync(Guid id);
        Task<User> CreateAsync(User user);
        Task<User> UpdateAsync(User user);
        Task<User> DeleteAsync(Guid id);
    }
}
