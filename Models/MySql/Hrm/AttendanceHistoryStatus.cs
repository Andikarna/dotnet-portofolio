using System;
using System.Collections.Generic;

namespace AdidataDbContext.Models.MySql.Hrm
{
    public partial class AttendanceHistoryStatus
    {
        public AttendanceHistoryStatus()
        {
            AttendanceHistories = new HashSet<AttendanceHistory>();
        }

        public ulong Id { get; set; }
        public string Name { get; set; } = null!;
        public string? HistoryName { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }

        public virtual ICollection<AttendanceHistory> AttendanceHistories { get; set; }
    }
}
