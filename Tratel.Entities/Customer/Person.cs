namespace Tratel.Entities.Customer;

[Table("Persons", Schema = "Customer")]
public class Person : EntityBase
{
    [Required]
    [MaxLength(128)]
    public string FullName { get; set; }
    [Required]
    [MaxLength(32)]
    public string PassportNumber { get; set; }
    [Required]
    public Guid NationalityId { get; set; }

    [ForeignKey(nameof(NationalityId))]
    public LookUp Nationality { get; set; }
}