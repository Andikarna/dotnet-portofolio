using System;
using System.Collections.Generic;

namespace AdidataDbContext.Models.MySql.Auth
{
    public partial class Approval
    {
        public ulong Id { get; set; }
        public string RequestableType { get; set; } = null!;
        public ulong RequestableId { get; set; }
        public long? RequesterUserId { get; set; }
        public int? ApprovalTypeId { get; set; }
        public ulong ApprovalStatusId { get; set; }
        public long? ApprovalByUserId { get; set; }
        public DateTime? ApprovalDate { get; set; }
        public string? Remarks { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public ulong UpdatedByUserId { get; set; }
        public DateTime? DeletedAt { get; set; }

        public virtual ApprovalStatus ApprovalStatus { get; set; } = null!;
    }
}
