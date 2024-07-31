using Hobify.Application.Dto;

namespace Hobify.Application.Interface
{
    public interface IEventsAppService
    {
        Task<IEnumerable<EventsDto>> GetAllAsync();
        Task<EventsDto> GetByIdAsync(Guid id);
        Task<EventsDto> CreateAsync(EventsDto eventDto);
        Task<EventsDto> UpdateAsync(EventsDto eventDto);
        Task<EventsDto> DeleteAsync(Guid id);
    }
}
