namespace Hobify.Core.Entity
{
    public class SubCategory
    {
        public Guid id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public DateTime createdAt { get; set; }
        public DateTime updatedAt { get; set; }
        public Guid categoryId { get; set; }
        public List<Product> products { get; set; }
        public List<ForumTopic> forumTopics { get; set; }
        public List<Post> posts { get; set; }
        public List<Events> events { get; set; }
        public Category category { get; set; }
    }
}
