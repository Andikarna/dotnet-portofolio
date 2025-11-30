using System;
using System.Collections.Generic;

namespace AdidataDbContext.Models.MySql.Auth
{
    public partial class ModelHasPermission
    {
        public ulong PermissionId { get; set; }
        public string ModelType { get; set; } = null!;
        public ulong ModelId { get; set; }

        public virtual Permission Permission { get; set; } = null!;
    }
}
