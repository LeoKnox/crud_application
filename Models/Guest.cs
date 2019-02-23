namespace BigProject.Models
{
    public class Guest
    {
        public int GuestId {get; set;}
        public int UserId {get; set;}
        public int ActivityId {get; set;}
        public User User {get; set;}
        public Activities Acitivites { get; set; }
    }
}