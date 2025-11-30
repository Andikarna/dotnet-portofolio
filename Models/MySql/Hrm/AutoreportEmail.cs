using System;
using System.Collections.Generic;

namespace AdidataDbContext.Models.MySql.Hrm
{
    public partial class AutoreportEmail
    {
        public int Id { get; set; }
        public string Email { get; set; } = null!;
        public string Client { get; set; } = null!;
        public string Status { get; set; } = null!;
        public long UserC { get; set; }
        public long? UserM { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
    }
}
