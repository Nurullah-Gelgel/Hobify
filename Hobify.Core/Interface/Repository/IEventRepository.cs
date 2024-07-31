using Hobify.Core.Entity;
namespace Hobify.Core.Interface.Repository
{
    public interface IEventRepository
    {
        
        Task<IEnumerable<Events>> GetAllAsync();
        Task<Events> GetByIdAsync(Guid id);
        Task<Events> CreateAsync(Events events);
        Task<Events> UpdateAsync(Events events);
        Task<Events> DeleteAsync(Guid id);
            
         
    }
}
