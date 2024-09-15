namespace Hobify.Core.Entity.Security
{
    public class AppRole
    {
        public Guid AppRoleID { get; set; }
        public string RoleName { get; set; }
        public string RoleDescription { get; set; } = string.Empty;

        public List<AppUser> AppUsers { get; set; }

    }
}