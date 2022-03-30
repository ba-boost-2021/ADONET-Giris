namespace Tratel.Entities.Main;

[Table("LookUps", Schema = "Main")]
public class LookUp : EntityBase
{
    [Required]
    [MaxLength(32)]
    public string Name { get; set; }

    [Required]
    public Guid TypeId { get; set; }

    public Guid? ParentId { get; set; }

    [MaxLength(16)]
    public string Code { get; set; }

    [ForeignKey(nameof(TypeId))]
    public LookUpType Type { get; set; }

    [ForeignKey(nameof(ParentId))]
    public LookUp Parent { get; set; }

    public override string ToString()
    {
        return Name;
    }
}
