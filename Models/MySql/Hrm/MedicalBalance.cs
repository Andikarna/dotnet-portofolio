using System;
using System.Collections.Generic;

namespace AdidataDbContext.Models.MySql.Hrm
{
    public partial class MedicalBalance
    {
        public ulong Id { get; set; }
        public long EmpId { get; set; }
        public int Balance { get; set; }
        public long? UpdatedByUserId { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
    }
}
