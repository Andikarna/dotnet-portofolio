using System;
using System.Collections.Generic;

namespace AdidataDbContext.Models.MySql.Auth
{
    public partial class PermissionMenu
    {
        public ulong Id { get; set; }
        public ulong UserId { get; set; }
        public ulong MenuId { get; set; }
        public ulong GrantId { get; set; }
        public ulong FeatureId { get; set; }
        public sbyte? CanCreate { get; set; }
        public sbyte? CanRead { get; set; }
        public sbyte? CanUpdate { get; set; }
        public sbyte? CanDelete { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
    }
}
