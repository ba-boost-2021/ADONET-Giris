namespace Tratel.Entities.Customer;

[Table("Reservations", Schema = "Customer")]
public class Reservation : EntityBase
{
    [Required]
    public Guid UserId { get; set; }

    [Required]
    public Guid PlaceId { get; set; }

    [Required]
    public DateTime From { get; set; }

    public DateTime? Until { get; set; }

    [Required]
    public int AmountOfPople { get; set; }

    public int ChildrenCount { get; set; }

    [ForeignKey(nameof(UserId))]
    public User User { get; set; }

    [ForeignKey(nameof(PlaceId))]
    public Place Place { get; set; }
}