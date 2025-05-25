namespace CodeFirst.Models
{
    public class AppUserDetail:BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public int AppUserID { get; set; } //Relation property'nin sonuna ID konulduğu zaman bu EF tarafından bu kolon foreign key olarak kabul edilir

        //Relation Property

        public AppUser AppUser { get; set; }
    }
}
