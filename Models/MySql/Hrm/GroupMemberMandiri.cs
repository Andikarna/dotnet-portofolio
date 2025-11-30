using System;
using System.Collections.Generic;

namespace AdidataDbContext.Models.MySql.Hrm
{
    public partial class GroupMemberMandiri
    {
        public ulong Id { get; set; }
        public long UserId { get; set; }
        public ulong EmployeeId { get; set; }
        public long UpdatedByUserId { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
    }
}
