using System;
using System.Collections.Generic;

namespace AdidataDbContext.Models.MySql.Auth
{
    public partial class ApprovalHistory
    {
        public ulong Id { get; set; }
        public long ApprovalId { get; set; }
        public int? OldApprovalStatusId { get; set; }
        public int? NewRequestStatusId { get; set; }
        public long UpdatedByUserId { get; set; }
        public string? UpdatedByUserName { get; set; }
        public string? UpdatedByUserRole { get; set; }
        public string? Remarks { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
    }
}
