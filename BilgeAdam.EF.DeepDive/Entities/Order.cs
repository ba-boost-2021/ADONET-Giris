using System.ComponentModel.DataAnnotations.Schema;

namespace BilgeAdam.EF.DeepDive.Entities
{
    [Table("Orders")]
    public class Order
    {
        public int OrderID { get; set; }
        public string CustomerID { get; set; }
        public int EmployeeID { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal Freight { get; set; }

        [ForeignKey(nameof(EmployeeID))]
        public Employee Employee { get; set; }
        [ForeignKey(nameof(CustomerID))]
        public Customer Customer { get; set; }

        public ICollection<OrderDetail> Details { get; set; }
    }
}