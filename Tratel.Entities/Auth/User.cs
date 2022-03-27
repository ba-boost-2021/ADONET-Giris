namespace Tratel.Entities.Auth;

[Table("Users", Schema = "Auth")]
public class User : EntityBase
{
    [Required]
    [MaxLength(32)]
    public string UserName { get; set; }

    [Required]
    [MaxLength(64)]
    public string Password { get; set; }

    [Required]
    [MaxLength(64)]
    public string Mail { get; set; }

    [Required]
    public Guid PersonId { get; set; }

    [MaxLength(40)]
    public string VerificationCode { get; set; }

    [ForeignKey(nameof(PersonId))]
    public Person Person { get; set; }
}