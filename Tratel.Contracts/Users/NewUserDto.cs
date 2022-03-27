using System;

namespace Tratel.Contracts.Users;

public class NewUserDto
{
    public string Mail { get; set; }
    public string FullName { get; set; }
    public string PassportNumber { get; set; }
    public string UserName { get; set; }
    public string Password { get; set; }
    public Guid NationalityId { get; set; }
}
