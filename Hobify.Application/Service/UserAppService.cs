using AutoMapper;
using Hobify.Application.Dto;
using Hobify.Application.Interface;
using Hobify.Core.Entity;
using Hobify.Core.Interface.Services;

namespace Hobify.Application.Service
{
    public class UserAppService : IUserAppService
    {
        private readonly IUserService _userService;
        private readonly IMapper mapper;

        public UserAppService(IUserService userService, IMapper mapper)
        {
            _userService = userService;
            this.mapper = mapper;
        }
        public async Task<UserDto> CreateAsync(UserDto userdto)
        {
            var newUser = mapper.Map<User>(userdto);
            await _userService.CreateAsync(newUser);
            return mapper.Map<UserDto>(newUser);
        }

        public async Task<IEnumerable<UserDto>> GetAllAsync()
        {
            var users = await _userService.GetAllAsync();
            return mapper.Map<IEnumerable<UserDto>>(users);    
        }

        public async Task<UserDto> GetByIdAsync(Guid id)
        {
            var user = _userService.GetByIdAsync(id);
            return mapper.Map<UserDto>(user);
        }

        public async Task<UserDto> UpdateAsync(UserDto userUpdate)
        {
            var updatedUser = mapper.Map<User>(userUpdate);
           
            await _userService.UpdateAsync(updatedUser);
            return mapper.Map<UserDto>(updatedUser);
        }

        public async Task<UserDto> DeleteAsync(Guid id)
        {
            var user = await _userService.DeleteAsync(id);
            return mapper.Map<UserDto>(user);
        }
    }
}
