namespace ActivityIRL.Models
{
    public class Comment
    {
        public int CommentId; //Primary key
        public string Comments;
        public DateTime Created;
        public int UserId;
        public int EventId;
    }
}
