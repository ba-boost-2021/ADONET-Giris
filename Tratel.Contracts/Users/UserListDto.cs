using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tratel.Contracts.Users
{
    public class UserListDto
    {
        public Guid Id { get; set; }
        public string UserName { get; set; }
        public string Mail { get; set; }
        public string FullName { get; set; }
        public string Country { get; set; }
    }
}
