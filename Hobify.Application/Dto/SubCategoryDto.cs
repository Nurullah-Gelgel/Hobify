namespace Hobify.Application.Dto
{
    public class SubCategoryDto
    {
        public Guid id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public DateTime createdAt { get; set; }
        public DateTime updatedAt { get; set; }
        public Guid categoryId { get; set; }
      
    }
}
