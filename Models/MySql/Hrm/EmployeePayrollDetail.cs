using System;
using System.Collections.Generic;

namespace AdidataDbContext.Models.MySql.Hrm
{
    public partial class EmployeePayrollDetail
    {
        public ulong id { get; set; }
        public ulong employee_id { get; set; }
        public string status { get; set; }
        public string? npwp { get; set; }
        public DateTime? npwp_date { get; set; }
        public string type_tax_transaction { get; set; }
        public string ptkp { get; set; } = null!;
        public decimal salary { get; set; }
        public string? email_slip { get; set; }
        public string? password_slip { get; set; }
        public int bank_id { get; set; }
        public string? bpjs_tk_number { get; set; }
        public string? bpjs_kis_number { get; set; }
        public DateTime? bpjs_kis_effective_date { get; set; }
        public int update_by_user_id { get; set; }
        public decimal total { get; set; }
        public DateTime? created_at { get; set; }
        public DateTime? updated_at { get; set; }
        public DateTime? deleted_at { get; set; }
        public string type_bpjs_tk_transaction { get; set; }
        public string type_bpjs_kis_transaction { get; set; }
        public string marital_status { get; set; }
        public int? child { get; set; }
        public ulong? ptkp_detail_id { get; set; }
        public ulong? positional_allowance_detail_id { get; set; }
        public string? nama_ibu_kandung { get; set; }
        public string tax_status { get; set; }
        public string employee_type { get; set; }
        public DateTime? bpjs_tk_effective_date { get; set; }
    }
}
