using System;
using System.Collections.Generic;

namespace AdidataDbContext.Models.MySql.Hrm
{
    public partial class HistoryEmployeeContract
    {
        public long id { get; set; }
        public long? employee_id { get; set; }
        public long? employee_number { get; set; }
        public string? nik { get; set; }
        public string name { get; set; } = null!;
        public DateTime? join_date { get; set; }
        public DateTime? contract_start { get; set; }
        public DateTime? contract_end { get; set; }
        public DateTime? join_extend_start { get; set; }
        public DateTime? contract_extend_start { get; set; }
        public DateTime? contract_extend_end { get; set; }
        public string? contract_status { get; set; }
        public string? notes { get; set; }
        public string status { get; set; } = null!;
        public DateTime? created_date { get; set; }
        public int? created_by_user_id { get; set; }
        public DateTime? updated_time { get; set; }
        public int? updated_by_user_id { get; set; }
        public DateTime? deleted_time { get; set; }
        public int? deleted_by_user_id { get; set; }
    }
}
