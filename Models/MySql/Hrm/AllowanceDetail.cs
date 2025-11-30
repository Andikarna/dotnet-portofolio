using System;
using System.Collections.Generic;

namespace AdidataDbContext.Models.MySql.Hrm
{
    public partial class AllowanceDetail
    {
        public ulong Id { get; set; }
        public ulong? EmployeePayrollDetailId { get; set; }
        public ulong? AllowanceOldId { get; set; }
        public int UpdateByUserId { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
        public decimal Nominal { get; set; }
        public ulong AllowanceSettingId { get; set; }
    }
}
