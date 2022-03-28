namespace ActivityIRL.Models
{
    public class Event
    {

        public int EventId;
        public string Title;
        public DateTime Date;
        public string Activity;
        public string Description;
        public int MaxUsers;

        //public int MinUsers; Måske den her?

        public string StreetName;
        public int ApartmentNumber;
        public string City;
        public int ZipCode;
        public string State;
        public string Country;

        public bool Hidden;
        public int MinAge;
        public int MaxAge;
        public DateTime CreatedAt;
        public DateTime RegistrationDeadline;

        public List<User> ListOfUsers; //Kunne ikke lave med UserId

        //picture JPEG

        public List<Comment> Comments; //Foreign key

        public int UserId; // Foreign key

    }
}
