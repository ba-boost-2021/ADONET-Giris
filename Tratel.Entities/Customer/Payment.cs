namespace Tratel.Entities.Customer;

[Table("Payments", Schema = "Customer")]
public class Payment : EntityBase
{
    [Required]
    public Guid ReservationId { get; set; }

    [Required]
    public decimal Amount { get; set; }

    [Required]
    public Currency Currency { get; set; }

    public int? PartNumber { get; set; }

    [ForeignKey(nameof(ReservationId))]
    public Reservation Reservation { get; set; }
}