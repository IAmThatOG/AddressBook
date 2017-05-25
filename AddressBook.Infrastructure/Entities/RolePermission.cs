using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook.Infrastructure.Entities
{
    public class RolePermission
    {
        public int RolePermissionID { get; set; }

        public int RoleID { get; set; }

        public int PermissionID { get; set; }

        public virtual Role Role { get; set; }

        public virtual Permission Permission { get; set; }
    }
}