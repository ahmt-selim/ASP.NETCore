namespace CodeFirst.Models
{
    public class Product:BaseEntity
    {
        public string ProductName { get; set; }
        public decimal? UnitPrice { get; set; }
        public short UnitsInStock { get; set; }
        public int CategoryID { get; set; }

        //Relation Property
        public virtual Category Catergory { get; set; }
    }
}
