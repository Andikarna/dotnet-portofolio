using System;
using System.Collections.Generic;

namespace AdidataDbContext.Models.MySql.Hrm
{
    public partial class AttendanceHistory
    {
        public ulong Id { get; set; }
        public long EmployeeId { get; set; }
        public DateOnly Period { get; set; }
        public DateTime Arrived { get; set; }
        public DateTime? Returns { get; set; }
        public int Attend { get; set; }
        public int? Leaves { get; set; }
        public int? Late { get; set; }
        public int? DailyReport { get; set; }
        public ulong AttendanceHistoryStatusId { get; set; }
        public int ViaZkteco { get; set; }
        public string Notes { get; set; } = null!;
        public int? UpdatedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }

        public virtual AttendanceHistoryStatus AttendanceHistoryStatus { get; set; } = null!;
    }
}
