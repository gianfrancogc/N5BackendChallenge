using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N5.Challenge.Domain.Entities
{
    public class PermissionType : BaseEntity
    {
        public int Id { get; set; }
        public string Description { get; set; }

        public List<Permission> Permissions { get; set; }
    }
}
