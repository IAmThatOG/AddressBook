using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook.Core.Models
{
    public class RoleModel
    {
        public int RoleID { get; set; }

        public string Name { get; set; }

        public ICollection<PermissionModel> Permisions { get; set; } = new List<PermissionModel>();
    }
}