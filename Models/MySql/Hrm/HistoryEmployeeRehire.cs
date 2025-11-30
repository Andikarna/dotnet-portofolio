using System;
using System.Collections.Generic;

namespace AdidataDbContext.Models.MySql.Hrm
{
    public partial class HistoryEmployeeRehire
    {
        public long id { get; set; }
        public long? employee_id { get; set; }
        public long? employee_number { get; set; }
        public string? nik { get; set; }
        public string name { get; set; } = null!;
        public DateTime? join_date_old { get; set; }
        public DateTime? contract_start_old { get; set; }
        public DateTime? contract_end_old { get; set; }
        public DateTime? join_date_new { get; set; }
        public DateTime? contract_start_new { get; set; }
        public DateTime? contract_end_new { get; set; }
        public string? notes { get; set; }
        public string status { get; set; } = null!;
        public DateTime? created_date { get; set; }
        public int? created_by_user_id { get; set; }
    }
}
