using System;
using System.Collections.Generic;

namespace AdidataDbContext.Models.MySql.Hrm
{
    public partial class EmployeeClientDetail
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
        public string status { get; set; } = null!;
        public int? employee_internal { get; set; }
        public DateTime? effective_date { get; set; }
        public DateTime? expired_date { get; set; }
        public DateTime? finish_date { get; set; }
        public DateTime created_date { get; set; }
        public long? created_by_user_id { get; set; }
        public DateTime? updated_date { get; set; }
        public long? updated_by_user_id { get; set; }
        public DateTime? deleted_date { get; set; }
        public long? deleted_by_user_id { get; set; }
    }
}
