using System.ComponentModel.DataAnnotations.Schema;

namespace BilgeAdam.EF.Common.Entities
{
    [Table("Products")]
    public class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public short? UnitsInStock { get; set; }
        public decimal? UnitPrice { get; set; }
        public int? CategoryId { get; set; }
        public int? SupplierId { get; set; }
    }
}