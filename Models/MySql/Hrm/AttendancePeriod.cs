using System;
using System.Collections.Generic;

namespace AdidataDbContext.Models.MySql.Hrm
{
    public partial class AttendancePeriod
    {
        public long Id { get; set; }
        public long EmpId { get; set; }
        public int ClientId { get; set; }
        public int ProjectId { get; set; }
        public int EmployeePositionId { get; set; }
        public string Period { get; set; } = null!;
        public int LeavesTotal { get; set; }
        public int AttendTotal { get; set; }
        public int LateTotal { get; set; }
        public int OvertimeTotal { get; set; }
        public int OvertimeGoHome { get; set; }
        public int MedicalTotal { get; set; }
        public int SickTotal { get; set; }
        public int DailyReportTotal { get; set; }
        public string Status { get; set; } = null!;
        public DateTime? PostedDate { get; set; }
        public long UserC { get; set; }
        public long? UserM { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
    }
}
