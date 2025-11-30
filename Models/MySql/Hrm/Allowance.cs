using System;
using System.Collections.Generic;

namespace AdidataDbContext.Models.MySql.Hrm
{
    public partial class Allowance
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public int ProjectId { get; set; }
        public int EmployeePositionId { get; set; }
        public string Name { get; set; } = null!;
        public string ShowedName { get; set; } = null!;
        public long Nominal { get; set; }
        public string Status { get; set; } = null!;
        public long UserC { get; set; }
        public long? UserM { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
    }
}
