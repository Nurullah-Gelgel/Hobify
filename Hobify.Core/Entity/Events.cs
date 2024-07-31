namespace Hobify.Core.Entity
{
    public class Events
    {
        public Guid id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }
        public string location { get; set; }
        public string photoUrl { get; set; }
        public DateTime createdAt { get; set; }
        public DateTime updatedAt { get; set; }
        public Guid subCategoryId { get; set; }
        public SubCategory subCategory { get; set; }
    }
}
