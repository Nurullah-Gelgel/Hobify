using Hobify.Application.Dto;
using Microsoft.AspNetCore.Identity.Data;

namespace Hobify.Core.Interface.Services.Security
{
    public interface IAuthService
    {
        Task<AuthResult> RegisterAsync(RegisterDto registerRequest);
        Task<AuthResult> LoginAsync(LoginDto loginRequest);
    }
}
