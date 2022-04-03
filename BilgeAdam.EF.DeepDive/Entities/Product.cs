using System.ComponentModel.DataAnnotations.Schema;

namespace BilgeAdam.EF.DeepDive.Entities
{
    [Table("Products")]
    public class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public short? UnitsInStock { get; set; }
        public decimal? UnitPrice { get; set; }
        public int? CategoryId { get; set; }
        public int? SupplierID { get; set; }

        [ForeignKey(nameof(CategoryId))]
        public Category Category { get; set; } //Navigation Property (LEFT JOIN)
        [ForeignKey(nameof(SupplierID))]
        public Supplier Supplier { get; set; } //Navigation Property (LEFT JOIN)
    }
}