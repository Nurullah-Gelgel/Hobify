namespace Hobify.Application.Dto
{
    public class PostDto
    {
        public Guid id { get; set; }
        public string title { get; set; }
        public string? content { get; set; }
        public string? mediaType { get; set; }
        public string? mediaUrl { get; set; }
        public DateTime createdAt { get; set; }
        public DateTime? updatedAt { get; set; }
        public Guid userId { get; set; }
        public Guid? subCategoryId { get; set; }

    }
}
