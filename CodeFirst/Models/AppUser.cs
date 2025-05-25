using CodeFirst.Enums;
using System.Collections.Generic;

namespace CodeFirst.Models
{
    public class AppUser : BaseEntity
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public Role Role { get; set; }

        //Relation Property (İlişkinin nasıl olduğunu ifade eden propertyler)
        public AppUserDetail AppUserDetail { get; set; }
        public virtual List<Order> Orders { get; set; } //virtual anahtar kelimesi eklendiğinde bu tablodan veri getirme işleminde Order verilerinin de getirilmesi sağlanıyor.
    }
}
