using System;
using System.Collections.Generic;

namespace AdidataDbContext.Models.MySql.Hrm
{
    public partial class HistoryEmployeeResign
    {
        public long id { get; set; }
        public long? employee_id { get; set; }
        public long? employee_number { get; set; }
        public string? nik { get; set; }
        public string name { get; set; } = null!;
        public string? phone_number { get; set; }
        public string? membership_number_jkn_kis { get; set; }
        public int? emp_status_id { get; set; }
        public int? emp_position_id { get; set; }
        public string? emp_status_name { get; set; }
        public string? emp_position_name { get; set; }
        public DateTime? join_date_last { get; set; }
        public DateTime? contract_start_last { get; set; }
        public DateTime? contract_end_last { get; set; }
        public DateTime? resign_date { get; set; }
        public string? notes { get; set; }
        public string status { get; set; } = null!;
        public DateTime? created_date { get; set; }
        public int? created_by_user_id { get; set; }
    }
}
