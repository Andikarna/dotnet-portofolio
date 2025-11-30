using System;
using System.Collections.Generic;

namespace AdidataDbContext.Models.MySql.Auth
{
    public partial class ApprovalStatus
    {
        public ApprovalStatus()
        {
            Approvals = new HashSet<Approval>();
        }

        public ulong Id { get; set; }
        public string Name { get; set; } = null!;
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public ulong UpdatedByUserId { get; set; }
        public DateTime? DeletedAt { get; set; }

        public virtual ICollection<Approval> Approvals { get; set; }
    }
}
