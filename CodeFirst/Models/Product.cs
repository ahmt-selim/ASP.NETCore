using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirst.Models
{
    [Table("Ürünler")] //Bu tablo açılırken Ürünler ismi ile açılacak
    public class Product:BaseEntity
    {
        [Column("Ürün İsmi")]//Kolon ismini belirledik.
        [Required] //Zorunlu alan olarak tanımladık.
        public string ProductName { get; set; }
        public decimal? UnitPrice { get; set; }
        public short UnitsInStock { get; set; }
        public int CategoryID { get; set; }

        //Relation Property
        public virtual Category Catergory { get; set; }
        public virtual List<OrderDetail> OrderDetails { get; set; }
    }
}
