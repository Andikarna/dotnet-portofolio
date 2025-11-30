using System;
using System.Collections.Generic;

namespace AdidataDbContext.Models.MySql.Hrm
{
    public partial class Overtime
    {
        public long Id { get; set; }
        public DateOnly Date { get; set; }
        public long EmpId { get; set; }
        public string Reason { get; set; } = null!;
        public TimeOnly? TimeGoHome { get; set; }
        public DateTime? StartIn { get; set; }
        public DateTime? EndOut { get; set; }
        public string Status { get; set; } = null!;
        public long UserC { get; set; }
        public long? UserM { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public DateTime? DeletedAt { get; set; }
    }
}
