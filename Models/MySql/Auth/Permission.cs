using System;
using System.Collections.Generic;

namespace AdidataDbContext.Models.MySql.Auth
{
    public partial class Permission
    {
        public Permission()
        {
            ModelHasPermissions = new HashSet<ModelHasPermission>();
            Roles = new HashSet<Role>();
        }

        public ulong Id { get; set; }
        public string Name { get; set; } = null!;
        public string Group { get; set; } = null!;
        public string GuardName { get; set; } = null!;
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }

        public virtual ICollection<ModelHasPermission> ModelHasPermissions { get; set; }

        public virtual ICollection<Role> Roles { get; set; }
    }
}
