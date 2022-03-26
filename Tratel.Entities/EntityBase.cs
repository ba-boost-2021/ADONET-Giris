namespace Tratel.Entities;

public class EntityBase
{
    [Required]
    [Key]
    public Guid Id { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime ModifiedAt { get; set; }
}
