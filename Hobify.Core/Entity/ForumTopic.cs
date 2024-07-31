namespace Hobify.Core.Entity
{
    public class ForumTopic
    {
        public Guid id { get; set; }
        public string title { get; set; }
        public string content { get; set; }
        public DateTime createdAt { get; set; }
        public DateTime updatedAt { get; set; }
        public Guid userId { get; set; }
        public Guid subCategoryId { get; set; }
        public User user { get; set; }
        public SubCategory subCategory { get; set; }
    }
}
