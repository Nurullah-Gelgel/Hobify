namespace Hobify.Core.Entity
{
    public class ChatRoom
    {
        public Guid id { get; set; }
        public string name { get; set; }
        public string nickname { get; set; } = string.Empty;
        public string description { get; set; }
        public DateTime createdAt { get; set; }
        public DateTime updatedAt { get; set; }

       
        //public List<Message> messages { get; set; }
    }
}
