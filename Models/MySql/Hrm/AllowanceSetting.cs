using System;
using System.Collections.Generic;

namespace AdidataDbContext.Models.MySql.Hrm
{
    public partial class AllowanceSetting
    {
        public ulong Id { get; set; }
        public string? AllowanceSettingCode { get; set; }
        public ulong AllowanceMasterId { get; set; }
        public ulong EmployeePositionId { get; set; }
        public ulong ProjectId { get; set; }
        public ulong ClientId { get; set; }
        public long Nominal { get; set; }
        public long UpdatedByUserId { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
    }
}
