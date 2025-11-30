using System;
using System.Collections.Generic;

namespace AdidataDbContext.Models.MySql.Hrm
{
    public partial class MedicalReimbursement
    {
        public long Id { get; set; }
        public long EmpId { get; set; }
        public DateOnly Date { get; set; }
        public long RealNominal { get; set; }
        public int Nominal { get; set; }
        public string Status { get; set; } = null!;
        public long UserC { get; set; }
        public long? UserM { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public DateTime? DeletedAt { get; set; }
        public string? Attachment { get; set; }
        public long Balance { get; set; }
    }
}
