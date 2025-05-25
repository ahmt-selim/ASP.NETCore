namespace CodeFirst.Models
{
    public class OrderDetail:BaseEntity
    {
        public int OrderID { get; set; }
        public int ProductID { get; set; }
        public int Quantity { get; set; }
        public decimal? TotalPrice { get; set; }

        //Relation Property

        public virtual Order Order { get; set; }
        public virtual Product Product { get; set; }
    }
}
