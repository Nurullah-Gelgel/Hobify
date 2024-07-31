namespace Hobify.Core.Entity
{
    public class User
    {
        public Guid id { get; set; }
        public string username { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public string? profilePhotoUrl { get; set; }
        public string? bio { get; set; }
        public DateTime? createdAt { get; set; }
        public DateTime? updatedAt { get; set; }
        public ICollection<Post> posts { get; set; }
        public ICollection<Comment> comments { get; set; }
        public ICollection<ChatRoom> chatrooms { get; set; }
        public ICollection<Product> products { get; set; }
        //public List<Message> messages { get; set; }



    }
}
