using Hobify.Core.Entity;

namespace Hobify.Core.Interface.Services
{
    public interface IJwtTokenGenerator
    {
        string GenerateToken(User user);
    }
}
