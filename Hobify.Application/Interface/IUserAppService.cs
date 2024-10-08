﻿using Hobify.Application.Dto;

namespace Hobify.Application.Interface
{
    public interface IUserAppService
    {
        Task<IEnumerable<UserDto>> GetAllAsync();
        Task<UserDto> GetByIdAsync(Guid id);
        Task<UserDto> GetByEmailAsync(string email);
        Task<UserDto> GetByUserNameAsync(string userName);
        Task<UserDto> CreateAsync(UserDto user);
        Task<UserDto> UpdateAsync(UserDto user);
        Task<UserDto> DeleteAsync(Guid id);
    }
}
