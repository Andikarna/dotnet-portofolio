using System;
using System.Collections.Generic;

namespace AdidataDbContext.Models.MySql.Hrm
{
    public partial class GroupMember
    {
        public ulong Id { get; set; }
        public ulong EmployeeId { get; set; }
        public ulong GroupLeaderId { get; set; }
        public long UpdatedByUserId { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
    }
}
