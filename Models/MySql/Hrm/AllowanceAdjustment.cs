using System;
using System.Collections.Generic;

namespace AdidataDbContext.Models.MySql.Hrm
{
    public partial class AllowanceAdjustment
    {
        public ulong Id { get; set; }
        public ulong EmployeeId { get; set; }
        public ulong AllowanceSettingId { get; set; }
        public DateOnly EffectiveDate { get; set; }
        public string Description { get; set; } = null!;
        public long Nominal { get; set; }
        public long UpdatedByUserId { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
        public string Locked { get; set; } = null!;
    }
}
