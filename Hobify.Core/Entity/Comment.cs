namespace Hobify.Core.Entity
{
    public class Comment
    {
        public Guid id { get; set; }
        public string content { get; set; }
        public DateTime createdAt { get; set; }
        public DateTime updatedAt { get; set; }
        public Guid userId { get; set; }
        public Guid postId { get; set; }
        public User user { get; set; }
        public Post post { get; set; }
    }
}
