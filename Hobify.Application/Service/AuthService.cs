using BCrypt.Net;
using Hobify.Application.Dto;
using Hobify.Core.Entity;
using Hobify.Core.Interface.Repository;
using Hobify.Core.Interface.Services;
using Hobify.Core.Interface.Services.Security;

namespace Hobify.Application.Service
{
    public class AuthService : IAuthService
    {
        private readonly IJwtTokenGenerator _jwtTokenGenerator;
        private readonly IUserRepository _userRepository;

        public AuthService(IJwtTokenGenerator jwtTokenGenerator, IUserRepository userRepository)
        {
            _jwtTokenGenerator = jwtTokenGenerator;
            _userRepository = userRepository;
        }

        public async Task<AuthResult> LoginAsync(LoginDto loginRequest)
        {
            var user = await _userRepository.GetByEmailAsync(loginRequest.Email);
            if (user == null)
            {
                return new AuthResult { Succeeded = false };
            }
            if (!BCrypt.Net.BCrypt.Verify(loginRequest.Password, user.password))
            {
                return new AuthResult { Succeeded = false };
            }
            return new AuthResult { Succeeded = true, Token = _jwtTokenGenerator.GenerateToken(user) };
        }

        public async Task<AuthResult> RegisterAsync(RegisterDto registerRequest)
        {
            var user = new User { email = registerRequest.Email,username=registerRequest.Username, password = BCrypt.Net.BCrypt.HashPassword(registerRequest.Password) , birthDate=registerRequest.birthDate, name=registerRequest.name,surname=registerRequest.surname, phoneNumber=registerRequest.phoneNumber};
            await _userRepository.CreateAsync(user);
            return new AuthResult {Succeeded=true };
        }
    }
}
