namespace Hobify.Application.Dto
{
    public class UserRequestDto
    {
        public Guid id { get; set; }
        public string username { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public string? profilePhotoUrl { get; set; }
        public string? bio { get; set; }
    }
}
