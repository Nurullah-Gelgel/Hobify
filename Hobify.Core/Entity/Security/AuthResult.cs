namespace Hobify.Application.Dto
{
    public class AuthResult
    {
        public string Token { get; set; }

        public bool Succeeded { get; set; }
        public string[]? Errors { get; set; } 

    }
}
