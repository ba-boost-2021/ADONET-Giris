namespace Tratel.Entities.Customer;

[Table("Places", Schema = "Customer")]
public class Place : EntityBase
{
    [Required]
    [MaxLength(128)]
    public string Name { get; set; }

    [MaxLength(30)]
    public string Phone { get; set; }

    [Required]
    public PlaceType Type { get; set; }

    [Required]
    public Guid TownId { get; set; }

    [MaxLength(256)]
    public string Address { get; set; }

    [ForeignKey(nameof(TownId))]
    public LookUp Town { get; set; }
}


/*
 Nullable Foreign Key property'leri Left Join ile sorgu yapar
 Nullable olmayanlar ise Inner Join ile sorgu yapar
 */
// POCO -> Plain Old CLR Objects
// Common Language Runtime
// Migration -> SQL Objects