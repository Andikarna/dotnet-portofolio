using System;
using System.Collections.Generic;

namespace AdidataDbContext.Models.MySql.Hrm
{
    public partial class AttendanceReport
    {
        public long Id { get; set; }
        public long EmpId { get; set; }
        public int ClientId { get; set; }
        public int ProjectId { get; set; }
        public int EmployeePositionId { get; set; }
        public string ClientName { get; set; } = null!;
        public string ProjectName { get; set; } = null!;
        public string EmployeePositionName { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string Period { get; set; } = null!;
        public int LeavesRemaining { get; set; }
        public int LeavesTotal { get; set; }
        public int SickTotal { get; set; }
        public int AttendTotal { get; set; }
        public int LateTotal { get; set; }
        public int OvertimeTotal { get; set; }
        public long OvertimeGoHome { get; set; }
        public int MedicalTotal { get; set; }
        public int DailyReportTotal { get; set; }
        public long LaptopInternetTotal { get; set; }
        public long TransportTotal { get; set; }
        public long MealAllowanceTotal { get; set; }
        public long OvertimeMealAllowanceTotal { get; set; }
        public long Total { get; set; }
        public string BankAccountNumber { get; set; } = null!;
        public string BankName { get; set; } = null!;
        public DateTime? PostedDate { get; set; }
        public long UserC { get; set; }
        public long? UserM { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
    }
}
