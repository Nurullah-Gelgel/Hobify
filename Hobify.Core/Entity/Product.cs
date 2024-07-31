namespace Hobify.Core.Entity
{
    public class Product
    {
        public Guid id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public double price { get; set; }
        public string photoUrl { get; set; }
        public DateTime createdAt { get; set; }
        public DateTime updatedAt { get; set; }
        public Guid userId { get; set; }
        public Guid subCategoryId { get; set; }
        public User user { get; set; }
        public SubCategory subCategories { get; set; }
    }
}
