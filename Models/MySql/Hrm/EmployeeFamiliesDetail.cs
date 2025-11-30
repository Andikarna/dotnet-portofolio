using System;
using System.Collections.Generic;

namespace AdidataDbContext.Models.MySql.Hrm
{
    public partial class EmployeeFamiliesDetail
    {
        public long id { get; set; }
        public long employee_id { get; set; }
        public long? employee_number { get; set; }
        public string name { get; set; } = null!;
        public string status { get; set; } = null!;
        public string gender { get; set; } = null!;
        public string occupation { get; set; } = null!;
        public string education { get; set; } = null!;
        public DateTime? created_at { get; set; }
        public DateTime? updated_at { get; set; }
        public DateTime? deleted_at { get; set; }
    }
}
