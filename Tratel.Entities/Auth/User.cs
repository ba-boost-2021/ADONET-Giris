using System.ComponentModel.DataAnnotations.Schema;

namespace Tratel.Entities.Auth
{
    [Table("Users", Schema = "Auth")]
    public class User : EntityBase
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Phone { get; set; }
        public string VerificationCode { get; set; }
    }
}
