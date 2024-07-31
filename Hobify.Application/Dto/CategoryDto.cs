namespace Hobify.Application.Dto
{
    public class CategoryDto
    {
        public Guid id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public DateTime createdAt { get; set; } = DateTime.Now;
        public DateTime updatedAt { get; set; } = DateTime.Now;
   
    }
}
