using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tratel.Contracts.Users;

public class UpdateUserDto
{
    public string Mail { get; set; }
    public string FullName { get; set; }
    public string PassportNumber { get; set; }
    public string UserName { get; set; }
    public string Password { get; set; }
    public Guid NationalityId { get; set; }
    public DateTime ModifiedDate { get; set; }

}
