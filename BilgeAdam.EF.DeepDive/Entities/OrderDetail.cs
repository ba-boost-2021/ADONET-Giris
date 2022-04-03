using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BilgeAdam.EF.DeepDive.Entities
{
    [Table("Order Details")]
    public class OrderDetail
    {
        public int OrderID { get; set; }
        public int ProductID { get; set; }
        public short Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public float Discount { get; set; }

        [ForeignKey(nameof(OrderID))]
        public Order Order { get; set; } // Navigation Property (INNER JOIN)
        [ForeignKey(nameof(ProductID))]
        public Product Product { get; set; }
    }
}