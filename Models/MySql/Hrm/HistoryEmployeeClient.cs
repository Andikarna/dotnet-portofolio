using System;
using System.Collections.Generic;

namespace AdidataDbContext.Models.MySql.Hrm
{
    public partial class HistoryEmployeeClient
    {
        public long id { get; set; }
        public long? employee_id { get; set; }
        public long? employee_number { get; set; }
        public string name { get; set; } = null!;
        public int? job_old { get; set; }
        public int? division_old { get; set; }
        public int? client_old { get; set; }
        public int? project_old { get; set; }
        public int? emp_status_old { get; set; }
        public int? emp_position_old { get; set; }
        public int? job_new { get; set; }
        public int? division_new { get; set; }
        public int? client_new { get; set; }
        public int? project_new { get; set; }
        public int? emp_status_new { get; set; }
        public int? emp_position_new { get; set; }
        public int? emp_internal_id { get; set; }
        public DateTime? client_active_date { get; set; }
        public DateTime? client_expired_date { get; set; }
        public string? notes { get; set; }
        public string status { get; set; } = null!;
        public DateTime created_date { get; set; }
        public int? created_by_user_id { get; set; }
        public DateTime? updated_time { get; set; }
        public int? updated_by_user_id { get; set; }
        public DateTime? deleted_time { get; set; }
        public int? deleted_by_user_id { get; set; }
    }
}
