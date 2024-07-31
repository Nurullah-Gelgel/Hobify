namespace Hobify.Core.Entity
{
    public class Category
    {
        public Guid id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public DateTime createdAt { get; set; }
        public DateTime updatedAt { get; set; }
        public ICollection<SubCategory> subCategories { get; set; }
    }
}
