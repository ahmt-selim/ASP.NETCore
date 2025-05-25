namespace CodeFirst.Models
{
    public class Order:BaseEntity
    {
        public int AppUserID { get; set; }
        //Relation Property
        public virtual AppUser AppUser { get; set; }
    }
}
