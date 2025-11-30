using System;
using System.Collections.Generic;

namespace AdidataDbContext.Models.MySql.Hrm
{
    public partial class CutiLastPeriodic
    {
        public int Id { get; set; }
        public long EmpId { get; set; }
        public string Period { get; set; } = null!;
        public int LeavesRemain { get; set; }
        public string Status { get; set; } = null!;
        public int UserC { get; set; }
        public int? UserM { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
    }
}
