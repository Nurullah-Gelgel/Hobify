namespace Hobify.Application.Dto
{
    public class CommentDto
    {
        public Guid id { get; set; }
        public string content { get; set; }
        public DateTime createdAt { get; set; } = DateTime.Now;
        public DateTime updatedAt { get; set; } = DateTime.Now;
        public Guid userId { get; set; }
        public Guid postId { get; set; }
  
    }
}
