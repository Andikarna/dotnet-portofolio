using System;
using System.Collections.Generic;

namespace AdidataDbContext.Models.MySql.Hrm
{
    public partial class AttendanceDetail
    {
        public long Id { get; set; }
        public long AttdPeriodId { get; set; }
        public DateOnly Date { get; set; }
        public TimeOnly? Arrived { get; set; }
        public TimeOnly? Returns { get; set; }
        public int Attend { get; set; }
        public int Leaves { get; set; }
        public int Late { get; set; }
        public int DailyReport { get; set; }
        public long UserC { get; set; }
        public long? UserM { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
    }
}
