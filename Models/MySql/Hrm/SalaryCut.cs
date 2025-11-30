using System;
using System.Collections.Generic;

namespace AdidataDbContext.Models.MySql.Hrm
{
    public partial class SalaryCut
    {
        public ulong Id { get; set; }
        public ulong? EmployeePayrollDetailId { get; set; }
        public string Name { get; set; } = null!;
        public decimal Nominal { get; set; }
        public int UpdateByUserId { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
    }
}
