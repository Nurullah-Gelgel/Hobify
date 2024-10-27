namespace Hobify.Application.Dto
{
    public class UserDto
    {

        public Guid id { get; set; }
        public string username { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public string? name { get; set; }
        public string? surname { get; set; }
        public DateTime? birthDate { get; set; }

        public string? phoneNumber { get; set; }
        public string? profilePhotoUrl { get; set; }
        public string? bio { get; set; }
        public DateTime? createdAt { get; set; }= DateTime.UtcNow;
        public DateTime? updatedAt { get; set; } = DateTime.UtcNow;
    }
}
