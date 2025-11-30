using System;
using System.Collections.Generic;

namespace AdidataDbContext.Models.MySql.Hrm
{
    public partial class TimeSheet
    {
        public ulong Id { get; set; }
        public ulong? AttendanceHistoryId { get; set; }
        public ulong? EmployeeId { get; set; }
        public DateOnly? Date { get; set; }
        public int AssignedTc { get; set; }
        public int ExecutedTc { get; set; }
        public string Activity { get; set; } = null!;
        public string Remarks { get; set; } = null!;
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
    }
}
