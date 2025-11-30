using System;
using System.Collections.Generic;

namespace AdidataDbContext.Models.MySql.Hrm
{
    public partial class RawAttendance
    {
        public long Id { get; set; }
        public long FingerId { get; set; }
        public string Name { get; set; } = null!;
        public DateOnly Date { get; set; }
        public TimeOnly TapTime { get; set; }
        public int UserC { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
    }
}
