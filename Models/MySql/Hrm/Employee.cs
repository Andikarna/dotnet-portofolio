using System;
using System.Collections.Generic;

namespace AdidataDbContext.Models.MySql.Hrm
{
    public partial class Employee
    {
        public long id { get; set; }
        public long? employee_number { get; set; }
        public string? nik { get; set; }
        public string name { get; set; } = null!;
        public string? nick_name { get; set; }
        public int? job_id { get; set; }
        public int? div_id { get; set; }
        public DateTime? birth_of_date { get; set; }
        public int? employee_status { get; set; }
        public int? employee_position { get; set; }
        public string? hp { get; set; }
        public string? hp2 { get; set; }
        public string? address { get; set; }
        public string? bank_account { get; set; }
        public int? bank_id { get; set; }
        public string? insurance_account { get; set; }
        public string? email { get; set; }
        public string? email2 { get; set; }
        public DateTime? join_date { get; set; }
        public DateTime contract_start { get; set; }
        public DateTime? contract_end { get; set; }
        public string status { get; set; } = null!;
        public DateTime? non_active_date { get; set; }
        public string? note { get; set; }
        public string? emergency_number { get; set; }
        public string? emergency_name { get; set; }
        public string? emergency_relation { get; set; }
        public string? npwp { get; set; }
        public int? client_id { get; set; }
        public int? project_id { get; set; }
        public long? user_c { get; set; }
        public long? user_m { get; set; }
        public DateTime created_date { get; set; }
        public DateTime? modified_date { get; set; }
        public long? finger_id { get; set; }
        public ulong? employee_payroll_detail_id { get; set; }
        public string? gander { get; set; }
        public int employee_internal { get; set; }
        public DateTime? deleted_at { get; set; }
        public long? attendance_id { get; set; }
        public string hire_type { get; set; } = null!;
        public DateTime? first_employment_date { get; set; }
        public DateTime? npwp_date { get; set; }
        public string? place_of_birth { get; set; }
        public string marital_status { get; set; } = null!;
        public string? job_title_name { get; set; }
        public string? departement_name { get; set; }
        public string? organization_name { get; set; }
        public string? mother_name { get; set; }
        public string? last_education { get; set; }
        public string? school_or_university { get; set; }
        public string? major_school_or_university { get; set; }
        public int? graduation_year { get; set; }
        public decimal? length_of_service { get; set; }
        public string? family_card_number { get; set; }
        public int? rt { get; set; }
        public int? rw { get; set; }
        public int? zip_code { get; set; }
        public string? city { get; set; }
        public string? subdistrict { get; set; }
        public string? village { get; set; }
        public string? project_name { get; set; }
        public string? div_name { get; set; }
        public string? employee_status_name { get; set; }
        public string? employee_position_name { get; set; }
        public string? bank_name { get; set; }
        public string? bank_account_name { get; set; }
        public int? contract_count { get; set; }
        public DateTime? permanent_date { get; set; }
        public int? starting_year { get; set; }
        public decimal? grade_point_average { get; set; }
        public string? blood_type { get; set; }
        public string? house_number { get; set; }
        public string? citizenship { get; set; }
        public string? religion { get; set; }
        public string? residence_address { get; set; }
        public string? school_or_university_town { get; set; }
        public int? marriage_year { get; set; }
        public int? families_detail_id { get; set; }
        public int? assignment_id { get; set; }
        public int? department_id { get; set; }
        public int? section_id { get; set; }
    }
}
