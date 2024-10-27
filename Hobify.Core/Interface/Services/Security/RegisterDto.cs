namespace Hobify.Core.Interface.Services.Security
{
    public class RegisterDto
    {
        public string Email { get; set; }

        public string Username { get; set; }
        public string Password { get; set; }

        public string name { get; set; }
        public string surname { get; set; }
        public DateTime? birthDate { get; set; }

        public string phoneNumber { get; set; }
    }
}
