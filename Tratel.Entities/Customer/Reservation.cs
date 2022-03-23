using System.ComponentModel.DataAnnotations.Schema;

namespace Tratel.Entities.Customer
{
    [Table("Reservations", Schema = "Customer")]
    public class Reservation : EntityBase
    {
        public Guid UserId { get; set; }
        public Guid PlaceId { get; set; }
        public DateTime From { get; set; }
        public DateTime To { get; set; }
        public int AmountOfPople { get; set; }
        public int ChildrenCount { get; set; }
    }
}
