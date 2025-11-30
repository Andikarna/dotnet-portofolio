using System;
using System.Collections.Generic;

namespace AdidataDbContext.Models.MySql.Hrm
{
    public partial class GroupLeader
    {
        public ulong Id { get; set; }
        public ulong EmployeeId { get; set; }
        public string Status { get; set; } = null!;
        public long UpdatedByUserId { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
    }
}
