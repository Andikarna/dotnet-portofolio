using System;
using System.Collections.Generic;

namespace AdidataDbContext.Models.MySql.Hrm
{
    public partial class HistoryEmployeeAssign
    {
        public long id { get; set; }
        public long? employee_id { get; set; }
        public long? employee_number { get; set; }
        public string name { get; set; } = null!;
        public int? job_id { get; set; }
        public int? div_id { get; set; }
        public int? employee_status { get; set; }
        public int? employee_position { get; set; }
        public int? client_id { get; set; }
        public int? project_id { get; set; }
        public int? departement_id { get; set; }
        public int? section_id { get; set; }
        public int? employee_internal { get; set; }
        public string? notes { get; set; }
        public string status { get; set; } = null!;
        public DateTime created_date { get; set; }
        public int? created_by_user_id { get; set; }
    }
}
