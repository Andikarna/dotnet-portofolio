using System;
using System.Collections.Generic;

namespace AdidataDbContext.Models.MySql.Hrm
{
    public partial class SalaryCutComponentUpah
    {
        public ulong Id { get; set; }
        public ulong SalaryCutMasterId { get; set; }
        public string? Component { get; set; }
        public int IsProrate { get; set; }
        public int IsActive { get; set; }
        public long Nominal { get; set; }
        public long UpdatedByUserId { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
    }
}
