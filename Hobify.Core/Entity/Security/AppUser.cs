namespace Hobify.Core.Entity.Security
{
    public class AppUser
    {
        public Guid AppUserId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public Guid RoleId { get; set; }
        public AppRole AppRole { get; set; }
    }
}
