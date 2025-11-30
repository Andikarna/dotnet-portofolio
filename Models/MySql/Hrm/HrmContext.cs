using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Extensions.Configuration;

namespace AdidataDbContext.Models.MySql.Hrm
{
    public partial class HrmContext : DbContext
    {

        private readonly IConfiguration _configuration;
        public HrmContext(IConfiguration configuration)
        {
            _configuration = configuration;


        }
        public HrmContext(DbContextOptions<HrmContext> options, IConfiguration configuration)
            : base(options)
        {
            _configuration = configuration;
        }
        public virtual DbSet<Allowance> Allowances { get; set; } = null!;
        public virtual DbSet<AllowanceAdjustment> AllowanceAdjustments { get; set; } = null!;
        public virtual DbSet<AllowanceComponentUpah> AllowanceComponentUpahs { get; set; } = null!;
        public virtual DbSet<AllowanceDetail> AllowanceDetails { get; set; } = null!;
        public virtual DbSet<AllowanceMaster> AllowanceMasters { get; set; } = null!;
        public virtual DbSet<AllowanceSetting> AllowanceSettings { get; set; } = null!;
        public virtual DbSet<AttendanceDetail> AttendanceDetails { get; set; } = null!;
        public virtual DbSet<AttendanceHistory> AttendanceHistories { get; set; } = null!;
        public virtual DbSet<AttendanceHistoryStatus> AttendanceHistoryStatuses { get; set; } = null!;
        public virtual DbSet<AttendancePeriod> AttendancePeriods { get; set; } = null!;
        public virtual DbSet<AttendancePeriodHistory> AttendancePeriodHistories { get; set; } = null!;
        public virtual DbSet<AttendanceReport> AttendanceReports { get; set; } = null!;
        public virtual DbSet<AttendanceTiming> AttendanceTimings { get; set; } = null!;
        public virtual DbSet<AutoreportEmail> AutoreportEmails { get; set; } = null!;
        public virtual DbSet<BankList> BankLists { get; set; } = null!;
        public virtual DbSet<CiSessionsDatum> CiSessionsData { get; set; } = null!;
        public virtual DbSet<Client> Clients { get; set; } = null!;
        public virtual DbSet<ConfigApi> ConfigApis { get; set; } = null!;
        public virtual DbSet<Cuti> Cutis { get; set; } = null!;
        public virtual DbSet<CutiLastPeriodic> CutiLastPeriodics { get; set; } = null!;
        public virtual DbSet<Departement> Departements { get; set; } = null!;
        public virtual DbSet<Division> Divisions { get; set; } = null!;
        public virtual DbSet<Employee> Employees { get; set; } = null!;
        public virtual DbSet<EmployeeBpjsDetail> EmployeeBpjsDetails { get; set; } = null!;
        public virtual DbSet<EmployeeFamiliesDetail> EmployeeFamiliesDetails { get; set; } = null!;
        public virtual DbSet<EmployeePayrollDetail> EmployeePayrollDetails { get; set; } = null!;
        public virtual DbSet<EmployeePosition> EmployeePositions { get; set; } = null!;
        public virtual DbSet<EmployeeStatus> EmployeeStatus { get; set; } = null!;
        public virtual DbSet<GroupLeader> GroupLeaders { get; set; } = null!;
        public virtual DbSet<GroupMember> GroupMembers { get; set; } = null!;
        public virtual DbSet<GroupMemberMandiri> GroupMemberMandiris { get; set; } = null!;
        public virtual DbSet<HistoryEmployeeClient> HistoryEmployeeClients { get; set; } = null!;
        public virtual DbSet<HistoryEmployeeContract> HistoryEmployeeContracts { get; set; } = null!;
        public virtual DbSet<HistoryEmployeeRehire> HistoryEmployeeRehires { get; set; } = null!;
        public virtual DbSet<HistoryEmployeeResign> HistoryEmployeeResigns { get; set; } = null!;
        public virtual DbSet<Holiday> Holidays { get; set; } = null!;
        public virtual DbSet<Job> Jobs { get; set; } = null!;
        public virtual DbSet<KeysApi> KeysApis { get; set; } = null!;
        public virtual DbSet<Leaf> Leaves { get; set; } = null!;
        public virtual DbSet<Medical> Medicals { get; set; } = null!;
        public virtual DbSet<MedicalBalance> MedicalBalances { get; set; } = null!;
        public virtual DbSet<MedicalReimbursement> MedicalReimbursements { get; set; } = null!;
        public virtual DbSet<Migration> Migrations { get; set; } = null!;
        public virtual DbSet<Overtime> Overtimes { get; set; } = null!;
        public virtual DbSet<Project> Projects { get; set; } = null!;
        public virtual DbSet<RawAttendance> RawAttendances { get; set; } = null!;
        public virtual DbSet<SalaryCut> SalaryCuts { get; set; } = null!;
        public virtual DbSet<SalaryCutComponentUpah> SalaryCutComponentUpahs { get; set; } = null!;
        public virtual DbSet<SalaryCutMaster> SalaryCutMasters { get; set; } = null!;
        public virtual DbSet<SalaryCutSetting> SalaryCutSettings { get; set; } = null!;
        public virtual DbSet<Setting> Settings { get; set; } = null!;
        public virtual DbSet<Sick> Sicks { get; set; } = null!;
        public virtual DbSet<TimeSheet> TimeSheets { get; set; } = null!;
        public virtual DbSet<User> Users { get; set; } = null!;
        public virtual DbSet<EmployeeClientDetail> EmployeeClientDetails { get; set; } = null!;
        public virtual DbSet<Section> Sections { get; set; } = null!;
        public virtual DbSet<HistoryEmployeeAssign> HistoryEmployeeAssigns { get; set; } = null!;
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                //optionsBuilder.UseMySql("server=10.20.30.145;port=3306;user=dev1;password=Dev1234;database=hrm_dev", Microsoft.EntityFrameworkCore.ServerVersion.Parse("8.0.34-mysql"));
                optionsBuilder.UseMySql(_configuration.GetConnectionString("Hrm"), Microsoft.EntityFrameworkCore.ServerVersion.Parse("10.4.28-mariadb"));
                     
            }
        }




        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseCollation("utf8mb4_0900_ai_ci")
                .HasCharSet("utf8mb4");


            modelBuilder.Entity<HistoryEmployeeAssign>(entity =>
            {
                entity.ToTable("history_employee_assign");

                entity.UseCollation("utf8mb4_general_ci");

                entity.Property(e => e.id).HasColumnName("id");

                entity.Property(e => e.client_id).HasColumnName("client_id");

                entity.Property(e => e.created_by_user_id).HasColumnName("created_by_user_id");

                entity.Property(e => e.created_date)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_date")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.departement_id).HasColumnName("departement_id");

                entity.Property(e => e.div_id).HasColumnName("div_id");

                entity.Property(e => e.employee_id).HasColumnName("employee_id");

                entity.Property(e => e.employee_internal).HasColumnName("employee_internal");

                entity.Property(e => e.employee_number).HasColumnName("employee_number");

                entity.Property(e => e.employee_position).HasColumnName("employee_position");

                entity.Property(e => e.employee_status).HasColumnName("employee_status");

                entity.Property(e => e.job_id).HasColumnName("job_id");

                entity.Property(e => e.name)
                    .HasMaxLength(255)
                    .HasColumnName("name")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.notes)
                    .HasMaxLength(255)
                    .HasColumnName("notes");

                entity.Property(e => e.project_id).HasColumnName("project_id");

                entity.Property(e => e.section_id).HasColumnName("section_id");

                entity.Property(e => e.status)
                    .HasColumnType("enum('active','inactive')")
                    .HasColumnName("status")
                    .HasDefaultValueSql("'active'")
                    .UseCollation("utf8mb4_unicode_ci");

            });


            modelBuilder.Entity<Departement>(entity =>
            {
                entity.ToTable("departement");

                entity.HasCharSet("utf32")
                    .UseCollation("utf32_unicode_ci");

                entity.Property(e => e.id).HasColumnName("id");

                entity.Property(e => e.created_date)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_date")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.div_id).HasColumnName("div_id");

                entity.Property(e => e.modified_date)
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate()
                    .HasColumnName("modified_date");

                entity.Property(e => e.name)
                    .HasMaxLength(255)
                    .HasColumnName("name");

                entity.Property(e => e.status)
                    .HasColumnType("enum('active','inactive')")
                    .HasColumnName("status")
                    .HasDefaultValueSql("'active'");

                entity.Property(e => e.user_c).HasColumnName("user_c");

                entity.Property(e => e.user_m).HasColumnName("user_m");
            });


            //modelBuilder.Entity<EmployeeClientDetail>(entity =>
            //{
            //    entity.ToTable("employee_client_detail");

            //    entity.UseCollation("utf8mb4_general_ci");

            //    entity.Property(e => e.id).HasColumnName("id");

            //    entity.Property(e => e.client_id).HasColumnName("client_id");

            //    entity.Property(e => e.created_by_user_id).HasColumnName("created_by_user_id");

            //    entity.Property(e => e.created_date)
            //        .HasColumnType("timestamp")
            //        .HasColumnName("created_date");

            //    entity.Property(e => e.deleted_by_user_id).HasColumnName("deleted_by_user_id");

            //    entity.Property(e => e.deleted_date)
            //        .HasColumnType("timestamp")
            //        .HasColumnName("deleted_date");

            //    entity.Property(e => e.departement_id).HasColumnName("departement_id");

            //    entity.Property(e => e.div_id).HasColumnName("div_id");

            //    entity.Property(e => e.effective_date).HasColumnName("effective_date");

            //    entity.Property(e => e.employee_id).HasColumnName("employee_id");

            //    entity.Property(e => e.employee_number).HasColumnName("employee_number");

            //    entity.Property(e => e.employee_position).HasColumnName("employee_position");

            //    entity.Property(e => e.employee_internal).HasColumnName("employee_internal");

            //    entity.Property(e => e.employee_status).HasColumnName("employee_status");

            //    entity.Property(e => e.expired_date).HasColumnName("expired_date");

            //    entity.Property(e => e.job_id).HasColumnName("job_id");

            //    entity.Property(e => e.name)
            //        .HasMaxLength(255)
            //        .HasColumnName("name")
            //        .UseCollation("utf8mb4_unicode_ci");

            //    entity.Property(e => e.project_id).HasColumnName("project_id");

            //    entity.Property(e => e.section_id).HasColumnName("section_id");

            //    entity.Property(e => e.status)
            //        .HasColumnType("enum('active','inactive')")
            //        .HasColumnName("status")
            //        .HasDefaultValueSql("'active'")
            //        .UseCollation("utf8mb4_unicode_ci");

            //    entity.Property(e => e.updated_by_user_id).HasColumnName("updated_by_user_id");

            //    entity.Property(e => e.updated_date)
            //        .HasColumnType("timestamp")
            //        .ValueGeneratedOnAddOrUpdate()
            //        .HasColumnName("updated_date");
            //});

            modelBuilder.Entity<EmployeeClientDetail>(entity =>
            {
                entity.ToTable("employee_client_detail");

                entity.UseCollation("utf8mb4_general_ci");

                entity.Property(e => e.id).HasColumnName("id");

                entity.Property(e => e.client_id).HasColumnName("client_id");

                entity.Property(e => e.created_by_user_id).HasColumnName("created_by_user_id");

                entity.Property(e => e.created_date)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_date");

                entity.Property(e => e.deleted_by_user_id).HasColumnName("deleted_by_user_id");

                entity.Property(e => e.deleted_date)
                    .HasColumnType("timestamp")
                    .HasColumnName("deleted_date");

                entity.Property(e => e.departement_id).HasColumnName("departement_id");

                entity.Property(e => e.div_id).HasColumnName("div_id");

                entity.Property(e => e.effective_date).HasColumnName("effective_date");
                entity.Property(e => e.finish_date).HasColumnName("finish_date");

                entity.Property(e => e.employee_id).HasColumnName("employee_id");

                entity.Property(e => e.employee_position).HasColumnName("employee_position");

                entity.Property(e => e.employee_status).HasColumnName("employee_status");

                entity.Property(e => e.expired_date).HasColumnName("expired_date");

                entity.Property(e => e.job_id).HasColumnName("job_id");

                entity.Property(e => e.name)
                    .HasMaxLength(255)
                    .HasColumnName("name")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.project_id).HasColumnName("project_id");

                entity.Property(e => e.section_id).HasColumnName("section_id");

                entity.Property(e => e.employee_internal).HasColumnName("employee_internal");

                entity.Property(e => e.status)
                    .HasColumnType("enum('active','inactive')")
                    .HasColumnName("status")
                    .HasDefaultValueSql("'active'")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.updated_by_user_id).HasColumnName("updated_by_user_id");

                entity.Property(e => e.updated_date)
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate()
                    .HasColumnName("updated_date");
            });



            modelBuilder.Entity<Section>(entity =>
            {
                entity.ToTable("section");

                entity.HasCharSet("utf32")
                    .UseCollation("utf32_unicode_ci");

                entity.Property(e => e.id).HasColumnName("id");

                entity.Property(e => e.created_date)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_date")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.departement_id).HasColumnName("departement_id");

                entity.Property(e => e.modified_date)
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate()
                    .HasColumnName("modified_date");

                entity.Property(e => e.name)
                    .HasMaxLength(255)
                    .HasColumnName("name");

                entity.Property(e => e.status)
                    .HasColumnType("enum('active','inactive')")
                    .HasColumnName("status")
                    .HasDefaultValueSql("'active'");

                entity.Property(e => e.user_c).HasColumnName("user_c");

                entity.Property(e => e.user_m).HasColumnName("user_m");
            });



            modelBuilder.Entity<Allowance>(entity =>
            {
                entity.ToTable("allowance");

                entity.HasCharSet("utf32")
                    .UseCollation("utf32_unicode_ci");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ClientId).HasColumnName("client_id");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_date")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.EmployeePositionId).HasColumnName("employee_position_id");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate()
                    .HasColumnName("modified_date");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .HasColumnName("name");

                entity.Property(e => e.Nominal).HasColumnName("nominal");

                entity.Property(e => e.ProjectId).HasColumnName("project_id");

                entity.Property(e => e.ShowedName)
                    .HasMaxLength(255)
                    .HasColumnName("showed_name");

                entity.Property(e => e.Status)
                    .HasColumnType("enum('active','inactive')")
                    .HasColumnName("status")
                    .HasDefaultValueSql("'active'");

                entity.Property(e => e.UserC).HasColumnName("user_c");

                entity.Property(e => e.UserM).HasColumnName("user_m");
            });

            modelBuilder.Entity<AllowanceAdjustment>(entity =>
            {
                entity.ToTable("allowance_adjustment");

                entity.UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AllowanceSettingId).HasColumnName("allowance_setting_id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_at");

                entity.Property(e => e.DeletedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("deleted_at");

                entity.Property(e => e.Description)
                    .HasColumnType("text")
                    .HasColumnName("description");

                entity.Property(e => e.EffectiveDate).HasColumnName("effective_date");

                entity.Property(e => e.EmployeeId).HasColumnName("employee_id");

                entity.Property(e => e.Locked)
                    .HasColumnType("enum('yes','no')")
                    .HasColumnName("locked")
                    .HasDefaultValueSql("'no'");

                entity.Property(e => e.Nominal).HasColumnName("nominal");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("updated_at");

                entity.Property(e => e.UpdatedByUserId).HasColumnName("updated_by_user_id");
            });

            modelBuilder.Entity<AllowanceComponentUpah>(entity =>
            {
                entity.ToTable("allowance_component_upah");

                entity.UseCollation("utf8mb4_unicode_ci");

                entity.HasIndex(e => new { e.Id, e.AllowanceMasterId }, "IDX_allowance_component_upah");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AllowanceMasterId).HasColumnName("allowance_master_id");

                entity.Property(e => e.Component)
                    .HasColumnType("text")
                    .HasColumnName("component");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_at");

                entity.Property(e => e.DeletedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("deleted_at");

                entity.Property(e => e.IsActive)
                    .HasColumnName("is_active")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.IsProrate)
                    .HasColumnName("is_prorate")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.Nominal).HasColumnName("nominal");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("updated_at");

                entity.Property(e => e.UpdatedByUserId).HasColumnName("updated_by_user_id");
            });

            modelBuilder.Entity<AllowanceDetail>(entity =>
            {
                entity.ToTable("allowance_detail");

                entity.UseCollation("utf8mb4_unicode_ci");

                entity.HasIndex(e => new { e.Id, e.EmployeePayrollDetailId, e.AllowanceSettingId }, "idxKeyAllowanceDetail");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AllowanceOldId).HasColumnName("allowance_old_id");

                entity.Property(e => e.AllowanceSettingId).HasColumnName("allowance_setting_id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_at");

                entity.Property(e => e.DeletedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("deleted_at");

                entity.Property(e => e.EmployeePayrollDetailId).HasColumnName("employee_payroll_detail_id");

                entity.Property(e => e.Nominal)
                    .HasPrecision(12, 2)
                    .HasColumnName("nominal");

                entity.Property(e => e.UpdateByUserId).HasColumnName("update_by_user_id");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("updated_at");
            });

            modelBuilder.Entity<AllowanceMaster>(entity =>
            {
                entity.ToTable("allowance_master");

                entity.UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_at");

                entity.Property(e => e.DeletedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("deleted_at");

                entity.Property(e => e.Name)
                    .HasMaxLength(191)
                    .HasColumnName("name");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("updated_at");

                entity.Property(e => e.UpdatedByUserId).HasColumnName("updated_by_user_id");
            });

            modelBuilder.Entity<AllowanceSetting>(entity =>
            {
                entity.ToTable("allowance_setting");

                entity.UseCollation("utf8mb4_unicode_ci");

                entity.HasIndex(e => new { e.Id, e.AllowanceMasterId, e.EmployeePositionId, e.ProjectId, e.ClientId }, "IDX_allowance_setting");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AllowanceMasterId).HasColumnName("allowance_master_id");

                entity.Property(e => e.AllowanceSettingCode)
                    .HasMaxLength(255)
                    .HasColumnName("allowance_setting_code");

                entity.Property(e => e.ClientId).HasColumnName("client_id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_at");

                entity.Property(e => e.DeletedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("deleted_at");

                entity.Property(e => e.EmployeePositionId).HasColumnName("employee_position_id");

                entity.Property(e => e.Nominal).HasColumnName("nominal");

                entity.Property(e => e.ProjectId).HasColumnName("project_id");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("updated_at");

                entity.Property(e => e.UpdatedByUserId).HasColumnName("updated_by_user_id");
            });

            modelBuilder.Entity<AttendanceDetail>(entity =>
            {
                entity.ToTable("attendance_detail");

                entity.HasCharSet("utf32")
                    .UseCollation("utf32_unicode_ci");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Arrived)
                    .HasColumnType("time")
                    .HasColumnName("arrived");

                entity.Property(e => e.AttdPeriodId).HasColumnName("attd_period_id");

                entity.Property(e => e.Attend).HasColumnName("attend");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_date")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.DailyReport).HasColumnName("daily_report");

                entity.Property(e => e.Date).HasColumnName("date");

                entity.Property(e => e.Late).HasColumnName("late");

                entity.Property(e => e.Leaves).HasColumnName("leaves");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate()
                    .HasColumnName("modified_date");

                entity.Property(e => e.Returns)
                    .HasColumnType("time")
                    .HasColumnName("returns");

                entity.Property(e => e.UserC).HasColumnName("user_c");

                entity.Property(e => e.UserM).HasColumnName("user_m");
            });

            modelBuilder.Entity<AttendanceHistory>(entity =>
            {
                entity.ToTable("attendance_histories");

                entity.UseCollation("utf8mb4_unicode_ci");

                entity.HasIndex(e => e.AttendanceHistoryStatusId, "attendance_histories_attendance_history_status_id_foreign");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Arrived)
                    .HasColumnType("datetime")
                    .HasColumnName("arrived");

                entity.Property(e => e.Attend).HasColumnName("attend");

                entity.Property(e => e.AttendanceHistoryStatusId).HasColumnName("attendance_history_status_id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_at");

                entity.Property(e => e.DailyReport).HasColumnName("daily_report");

                entity.Property(e => e.DeletedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("deleted_at");

                entity.Property(e => e.EmployeeId).HasColumnName("employee_id");

                entity.Property(e => e.Late).HasColumnName("late");

                entity.Property(e => e.Leaves).HasColumnName("leaves");

                entity.Property(e => e.Notes)
                    .HasColumnType("text")
                    .HasColumnName("notes");

                entity.Property(e => e.Period).HasColumnName("period");

                entity.Property(e => e.Returns)
                    .HasColumnType("datetime")
                    .HasColumnName("returns");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("updated_at");

                entity.Property(e => e.UpdatedBy).HasColumnName("updated_by");

                entity.Property(e => e.ViaZkteco).HasColumnName("via_zkteco");

                entity.HasOne(d => d.AttendanceHistoryStatus)
                    .WithMany(p => p.AttendanceHistories)
                    .HasForeignKey(d => d.AttendanceHistoryStatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("attendance_histories_attendance_history_status_id_foreign");
            });

            modelBuilder.Entity<AttendanceHistoryStatus>(entity =>
            {
                entity.ToTable("attendance_history_statuses");

                entity.UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_at");

                entity.Property(e => e.DeletedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("deleted_at");

                entity.Property(e => e.HistoryName)
                    .HasMaxLength(191)
                    .HasColumnName("history_name");

                entity.Property(e => e.Name)
                    .HasMaxLength(191)
                    .HasColumnName("name");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("updated_at");
            });

            modelBuilder.Entity<AttendancePeriod>(entity =>
            {
                entity.ToTable("attendance_period");

                entity.HasCharSet("utf32")
                    .UseCollation("utf32_unicode_ci");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AttendTotal).HasColumnName("attend_total");

                entity.Property(e => e.ClientId).HasColumnName("client_id");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_date")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.DailyReportTotal).HasColumnName("daily_report_total");

                entity.Property(e => e.EmpId).HasColumnName("emp_id");

                entity.Property(e => e.EmployeePositionId).HasColumnName("employee_position_id");

                entity.Property(e => e.LateTotal).HasColumnName("late_total");

                entity.Property(e => e.LeavesTotal).HasColumnName("leaves_total");

                entity.Property(e => e.MedicalTotal).HasColumnName("medical_total");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate()
                    .HasColumnName("modified_date");

                entity.Property(e => e.OvertimeGoHome).HasColumnName("overtime_go_home");

                entity.Property(e => e.OvertimeTotal).HasColumnName("overtime_total");

                entity.Property(e => e.Period)
                    .HasMaxLength(7)
                    .HasColumnName("period");

                entity.Property(e => e.PostedDate)
                    .HasColumnType("timestamp")
                    .HasColumnName("posted_date");

                entity.Property(e => e.ProjectId).HasColumnName("project_id");

                entity.Property(e => e.SickTotal).HasColumnName("sick_total");

                entity.Property(e => e.Status)
                    .HasColumnType("enum('not post','posted')")
                    .HasColumnName("status")
                    .HasDefaultValueSql("'not post'");

                entity.Property(e => e.UserC).HasColumnName("user_c");

                entity.Property(e => e.UserM).HasColumnName("user_m");
            });

            modelBuilder.Entity<AttendancePeriodHistory>(entity =>
            {
                entity.ToTable("attendance_period_history");

                entity.HasCharSet("utf32")
                    .UseCollation("utf32_unicode_ci");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AttendTotal).HasColumnName("attend_total");

                entity.Property(e => e.ClientId).HasColumnName("client_id");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_date")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.DailyReportTotal).HasColumnName("daily_report_total");

                entity.Property(e => e.EmpId).HasColumnName("emp_id");

                entity.Property(e => e.EmployeePositionId).HasColumnName("employee_position_id");

                entity.Property(e => e.IdOld).HasColumnName("id_old");

                entity.Property(e => e.LateTotal).HasColumnName("late_total");

                entity.Property(e => e.LeavesTotal).HasColumnName("leaves_total");

                entity.Property(e => e.MedicalTotal).HasColumnName("medical_total");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate()
                    .HasColumnName("modified_date");

                entity.Property(e => e.OvertimeGoHome).HasColumnName("overtime_go_home");

                entity.Property(e => e.OvertimeTotal).HasColumnName("overtime_total");

                entity.Property(e => e.Period)
                    .HasMaxLength(7)
                    .HasColumnName("period");

                entity.Property(e => e.PostedDate)
                    .HasColumnType("timestamp")
                    .HasColumnName("posted_date");

                entity.Property(e => e.ProjectId).HasColumnName("project_id");

                entity.Property(e => e.SickTotal).HasColumnName("sick_total");

                entity.Property(e => e.Status)
                    .HasColumnType("enum('not post','posted')")
                    .HasColumnName("status")
                    .HasDefaultValueSql("'not post'");

                entity.Property(e => e.UserC).HasColumnName("user_c");

                entity.Property(e => e.UserM).HasColumnName("user_m");
            });

            modelBuilder.Entity<AttendanceReport>(entity =>
            {
                entity.ToTable("attendance_report");

                entity.HasCharSet("utf32")
                    .UseCollation("utf32_unicode_ci");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AttendTotal).HasColumnName("attend_total");

                entity.Property(e => e.BankAccountNumber)
                    .HasMaxLength(255)
                    .HasColumnName("bank_account_number");

                entity.Property(e => e.BankName)
                    .HasMaxLength(255)
                    .HasColumnName("bank_name");

                entity.Property(e => e.ClientId).HasColumnName("client_id");

                entity.Property(e => e.ClientName)
                    .HasMaxLength(30)
                    .HasColumnName("client_name");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_date")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.DailyReportTotal).HasColumnName("daily_report_total");

                entity.Property(e => e.EmpId).HasColumnName("emp_id");

                entity.Property(e => e.EmployeePositionId).HasColumnName("employee_position_id");

                entity.Property(e => e.EmployeePositionName)
                    .HasMaxLength(255)
                    .HasColumnName("employee_position_name");

                entity.Property(e => e.LaptopInternetTotal).HasColumnName("laptop_internet_total");

                entity.Property(e => e.LateTotal).HasColumnName("late_total");

                entity.Property(e => e.LeavesRemaining).HasColumnName("leaves_remaining");

                entity.Property(e => e.LeavesTotal).HasColumnName("leaves_total");

                entity.Property(e => e.MealAllowanceTotal).HasColumnName("meal_allowance_total");

                entity.Property(e => e.MedicalTotal).HasColumnName("medical_total");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate()
                    .HasColumnName("modified_date");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .HasColumnName("name");

                entity.Property(e => e.OvertimeGoHome).HasColumnName("overtime_go_home");

                entity.Property(e => e.OvertimeMealAllowanceTotal).HasColumnName("overtime_meal_allowance_total");

                entity.Property(e => e.OvertimeTotal).HasColumnName("overtime_total");

                entity.Property(e => e.Period)
                    .HasMaxLength(7)
                    .HasColumnName("period");

                entity.Property(e => e.PostedDate)
                    .HasColumnType("timestamp")
                    .HasColumnName("posted_date");

                entity.Property(e => e.ProjectId).HasColumnName("project_id");

                entity.Property(e => e.ProjectName)
                    .HasMaxLength(30)
                    .HasColumnName("project_name");

                entity.Property(e => e.SickTotal).HasColumnName("sick_total");

                entity.Property(e => e.Total).HasColumnName("total");

                entity.Property(e => e.TransportTotal).HasColumnName("transport_total");

                entity.Property(e => e.UserC).HasColumnName("user_c");

                entity.Property(e => e.UserM).HasColumnName("user_m");
            });

            modelBuilder.Entity<AttendanceTiming>(entity =>
            {
                entity.ToTable("attendance_timing");

                entity.HasCharSet("utf32")
                    .UseCollation("utf32_unicode_ci");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ClientId).HasColumnName("client_id");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_date")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate()
                    .HasColumnName("modified_date");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .HasColumnName("name");

                entity.Property(e => e.ProjectId).HasColumnName("project_id");

                entity.Property(e => e.ShowedName)
                    .HasMaxLength(255)
                    .HasColumnName("showed_name");

                entity.Property(e => e.Status)
                    .HasColumnType("enum('active','inactive')")
                    .HasColumnName("status")
                    .HasDefaultValueSql("'active'");

                entity.Property(e => e.Time)
                    .HasColumnType("time")
                    .HasColumnName("time");

                entity.Property(e => e.UserC).HasColumnName("user_c");

                entity.Property(e => e.UserM).HasColumnName("user_m");
            });

            modelBuilder.Entity<AutoreportEmail>(entity =>
            {
                entity.ToTable("autoreport_email");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Client)
                    .HasMaxLength(50)
                    .HasColumnName("client");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_date")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .HasColumnName("email");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate()
                    .HasColumnName("modified_date");

                entity.Property(e => e.Status)
                    .HasColumnType("enum('active','inactive')")
                    .HasColumnName("status")
                    .HasDefaultValueSql("'active'");

                entity.Property(e => e.UserC).HasColumnName("user_c");

                entity.Property(e => e.UserM).HasColumnName("user_m");
            });

            modelBuilder.Entity<BankList>(entity =>
            {
                entity.ToTable("bank_list");

                entity.HasCharSet("utf32")
                    .UseCollation("utf32_unicode_ci");

                entity.HasIndex(e => e.Id, "IDX_bank_list_id");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_date")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate()
                    .HasColumnName("modified_date");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .HasColumnName("name");

                entity.Property(e => e.Status)
                    .HasColumnType("enum('active','inactive')")
                    .HasColumnName("status")
                    .HasDefaultValueSql("'active'");

                entity.Property(e => e.UserC).HasColumnName("user_c");

                entity.Property(e => e.UserM).HasColumnName("user_m");
            });

            modelBuilder.Entity<CiSessionsDatum>(entity =>
            {
                entity.ToTable("ci_sessions_data");

                entity.HasCharSet("utf32")
                    .UseCollation("utf32_unicode_ci");

                entity.HasIndex(e => e.Timestamp, "ci_sessions_timestamp");

                entity.Property(e => e.Id)
                    .HasMaxLength(40)
                    .HasColumnName("id");

                entity.Property(e => e.Data)
                    .HasColumnType("blob")
                    .HasColumnName("data");

                entity.Property(e => e.IpAddress)
                    .HasMaxLength(45)
                    .HasColumnName("ip_address");

                entity.Property(e => e.Timestamp).HasColumnName("timestamp");
            });

            modelBuilder.Entity<Client>(entity =>
            {
                entity.ToTable("client");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.Property(e => e.id).HasColumnName("id");

                entity.Property(e => e.created_date)
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate()
                    .HasColumnName("created_date")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.modified_date)
                    .HasColumnType("timestamp")
                    .HasColumnName("modified_date");

                entity.Property(e => e.name)
                    .HasMaxLength(500)
                    .HasColumnName("name");

                entity.Property(e => e.status)
                    .HasColumnName("status")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.user_c).HasColumnName("user_c");

                entity.Property(e => e.user_m).HasColumnName("user_m");
            });

            modelBuilder.Entity<ConfigApi>(entity =>
            {
                entity.ToTable("config_api");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AppId)
                    .HasColumnName("app_id")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.ClientId).HasColumnName("client_id");

                entity.Property(e => e.Url)
                    .HasMaxLength(200)
                    .HasColumnName("url");
            });

            modelBuilder.Entity<Cuti>(entity =>
            {
                entity.ToTable("cuti");

                entity.HasCharSet("utf32")
                    .UseCollation("utf32_unicode_ci");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_date")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.EmpId).HasColumnName("emp_id");

                entity.Property(e => e.Limit).HasColumnName("limit");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate()
                    .HasColumnName("modified_date");

                entity.Property(e => e.Status)
                    .HasColumnType("enum('active','inactive','changed')")
                    .HasColumnName("status")
                    .HasDefaultValueSql("'active'");

                entity.Property(e => e.UserC).HasColumnName("user_c");

                entity.Property(e => e.UserM).HasColumnName("user_m");
            });

            modelBuilder.Entity<CutiLastPeriodic>(entity =>
            {
                entity.ToTable("cuti_last_periodic");

                entity.HasCharSet("utf32")
                    .UseCollation("utf32_unicode_ci");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_date")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.EmpId).HasColumnName("emp_id");

                entity.Property(e => e.LeavesRemain).HasColumnName("leaves_remain");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate()
                    .HasColumnName("modified_date");

                entity.Property(e => e.Period)
                    .HasMaxLength(7)
                    .HasColumnName("period");

                entity.Property(e => e.Status)
                    .HasColumnType("enum('active','inactive','changed')")
                    .HasColumnName("status")
                    .HasDefaultValueSql("'active'");

                entity.Property(e => e.UserC).HasColumnName("user_c");

                entity.Property(e => e.UserM).HasColumnName("user_m");
            });


            modelBuilder.Entity<Division>(entity =>
            {
                entity.ToTable("division");

                entity.HasCharSet("utf32")
                    .UseCollation("utf32_unicode_ci");

                entity.Property(e => e.id).HasColumnName("id");

                entity.Property(e => e.created_date)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_date")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.modified_date)
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate()
                    .HasColumnName("modified_date");

                entity.Property(e => e.name)
                    .HasMaxLength(255)
                    .HasColumnName("name");

                entity.Property(e => e.status)
                    .HasColumnType("enum('active','inactive')")
                    .HasColumnName("status")
                    .HasDefaultValueSql("'active'");

                entity.Property(e => e.user_c).HasColumnName("user_c");

                entity.Property(e => e.user_m).HasColumnName("user_m");
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.ToTable("employee");

                entity.UseCollation("utf8mb4_general_ci");

                entity.Property(e => e.id).HasColumnName("id");

                entity.Property(e => e.address)
                    .HasMaxLength(255)
                    .HasColumnName("address")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.attendance_id).HasColumnName("attendance_id");

                entity.Property(e => e.bank_account)
                    .HasMaxLength(15)
                    .HasColumnName("bank_account")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.bank_account_name)
                    .HasMaxLength(255)
                    .HasColumnName("bank_account_name");

                entity.Property(e => e.bank_id).HasColumnName("bank_id");

                entity.Property(e => e.bank_name)
                    .HasMaxLength(255)
                    .HasColumnName("bank_name");

                entity.Property(e => e.birth_of_date).HasColumnName("birth_of_date");

                entity.Property(e => e.blood_type)
                    .HasColumnType("enum('A','B','AB','O')")
                    .HasColumnName("blood_type")
                    .HasDefaultValueSql("'A'");

                entity.Property(e => e.citizenship)
                    .HasMaxLength(50)
                    .HasColumnName("citizenship");

                entity.Property(e => e.city)
                    .HasMaxLength(255)
                    .HasColumnName("city");

                entity.Property(e => e.client_id).HasColumnName("client_id");

                entity.Property(e => e.contract_count)
                    .HasColumnName("contract_count")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.contract_end).HasColumnName("contract_end");

                entity.Property(e => e.contract_start).HasColumnName("contract_start");

                entity.Property(e => e.created_date)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_date")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.deleted_at)
                    .HasColumnType("timestamp")
                    .HasColumnName("deleted_at");

                entity.Property(e => e.departement_name)
                    .HasMaxLength(255)
                    .HasColumnName("departement_name");

                entity.Property(e => e.div_id).HasColumnName("div_id");

                entity.Property(e => e.div_name)
                    .HasMaxLength(255)
                    .HasColumnName("div_name");

                entity.Property(e => e.email)
                    .HasMaxLength(255)
                    .HasColumnName("email")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.email2)
                    .HasMaxLength(255)
                    .HasColumnName("email2")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.emergency_name)
                    .HasMaxLength(255)
                    .HasColumnName("emergency_name")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.emergency_number)
                    .HasMaxLength(20)
                    .HasColumnName("emergency_number")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.emergency_relation)
                    .HasMaxLength(255)
                    .HasColumnName("emergency_relation")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.employee_internal).HasColumnName("employee_internal");

                entity.Property(e => e.employee_number).HasColumnName("employee_number");

                entity.Property(e => e.employee_payroll_detail_id).HasColumnName("employee_payroll_detail_id");

                entity.Property(e => e.employee_position).HasColumnName("employee_position");

                entity.Property(e => e.employee_position_name)
                    .HasMaxLength(255)
                    .HasColumnName("employee_position_name");

                entity.Property(e => e.employee_status).HasColumnName("employee_status");

                entity.Property(e => e.employee_status_name)
                    .HasMaxLength(255)
                    .HasColumnName("employee_status_name");

                entity.Property(e => e.families_detail_id).HasColumnName("families_detail_id");

                entity.Property(e => e.assignment_id).HasColumnName("assignment_id");

                entity.Property(e => e.family_card_number)
                    .HasMaxLength(255)
                    .HasColumnName("family_card_number");

                entity.Property(e => e.finger_id).HasColumnName("finger_id");

                entity.Property(e => e.first_employment_date).HasColumnName("first_employment_date");

                entity.Property(e => e.gander)
                    .HasColumnType("enum('pria','wanita')")
                    .HasColumnName("gander");

                entity.Property(e => e.grade_point_average)
                    .HasPrecision(4, 2)
                    .HasColumnName("grade_point_average");

                entity.Property(e => e.graduation_year).HasColumnName("graduation_year");

                entity.Property(e => e.hire_type)
                    .HasColumnType("enum('New Hire','Rehire')")
                    .HasColumnName("hire_type")
                    .HasDefaultValueSql("'New Hire'")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.house_number)
                    .HasMaxLength(20)
                    .HasColumnName("house_number");

                entity.Property(e => e.hp)
                    .HasMaxLength(20)
                    .HasColumnName("hp")
                    .HasDefaultValueSql("''")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.hp2)
                    .HasMaxLength(20)
                    .HasColumnName("hp2")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.insurance_account)
                    .HasMaxLength(20)
                    .HasColumnName("insurance_account")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.job_id).HasColumnName("job_id");

                entity.Property(e => e.job_title_name)
                    .HasMaxLength(255)
                    .HasColumnName("job_title_name");

                entity.Property(e => e.join_date).HasColumnName("join_date");

                entity.Property(e => e.last_education)
                    .HasMaxLength(255)
                    .HasColumnName("last_education");

                entity.Property(e => e.length_of_service)
                    .HasPrecision(10, 2)
                    .HasColumnName("length_of_service");

                entity.Property(e => e.major_school_or_university)
                    .HasMaxLength(255)
                    .HasColumnName("major_school_or_university");

                entity.Property(e => e.marital_status)
                    .HasColumnType("enum('single','menikah','cerai hidup','cerai mati')")
                    .HasColumnName("marital_status")
                    .HasDefaultValueSql("'single'");

                entity.Property(e => e.marriage_year).HasColumnName("marriage_year");

                entity.Property(e => e.modified_date)
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate()
                    .HasColumnName("modified_date");

                entity.Property(e => e.mother_name)
                    .HasMaxLength(255)
                    .HasColumnName("mother_name");

                entity.Property(e => e.name)
                    .HasMaxLength(255)
                    .HasColumnName("name")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.nick_name)
                    .HasMaxLength(255)
                    .HasColumnName("nick_name")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.nik)
                    .HasMaxLength(255)
                    .HasColumnName("nik");

                entity.Property(e => e.non_active_date)
                    .HasColumnType("timestamp")
                    .HasColumnName("non_active_date");

                entity.Property(e => e.note)
                    .HasMaxLength(255)
                    .HasColumnName("note")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.npwp)
                    .HasMaxLength(15)
                    .HasColumnName("npwp")
                    .HasDefaultValueSql("''")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.npwp_date).HasColumnName("npwp_date");

                entity.Property(e => e.organization_name)
                    .HasMaxLength(255)
                    .HasColumnName("organization_name");

                entity.Property(e => e.permanent_date).HasColumnName("permanent_date");

                entity.Property(e => e.place_of_birth)
                    .HasMaxLength(255)
                    .HasColumnName("place_of_birth");

                entity.Property(e => e.project_id).HasColumnName("project_id");

                entity.Property(e => e.project_name)
                    .HasMaxLength(255)
                    .HasColumnName("project_name");

                entity.Property(e => e.religion)
                    .HasColumnType("enum('islam','kristen protestan','kristen katolik','hindu','buddha','khonghucu')")
                    .HasColumnName("religion");

                entity.Property(e => e.residence_address)
                    .HasMaxLength(255)
                    .HasColumnName("residence_address");

                entity.Property(e => e.rt).HasColumnName("rt");

                entity.Property(e => e.rw).HasColumnName("rw");

                entity.Property(e => e.school_or_university)
                    .HasMaxLength(255)
                    .HasColumnName("school_or_university");

                entity.Property(e => e.school_or_university_town)
                    .HasMaxLength(255)
                    .HasColumnName("school_or_university_town");

                entity.Property(e => e.starting_year).HasColumnName("starting_year");

                entity.Property(e => e.status)
                    .HasColumnType("enum('active','inactive')")
                    .HasColumnName("status")
                    .HasDefaultValueSql("'active'")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.subdistrict)
                    .HasMaxLength(255)
                    .HasColumnName("subdistrict");

                entity.Property(e => e.user_c).HasColumnName("user_c");

                entity.Property(e => e.user_m).HasColumnName("user_m");

                entity.Property(e => e.village)
                    .HasMaxLength(255)
                    .HasColumnName("village");

                entity.Property(e => e.zip_code).HasColumnName("zip_code");

                entity.Property(e => e.section_id).HasColumnName("section_id");

                entity.Property(e => e.department_id).HasColumnName("department_id");
            });

            modelBuilder.Entity<EmployeeBpjsDetail>(entity =>
            {
                entity.ToTable("employee_bpjs_detail");

                entity.UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.BpjsId).HasColumnName("bpjs_id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_at");

                entity.Property(e => e.DeletedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("deleted_at");

                entity.Property(e => e.EmployeePayrollDetailId).HasColumnName("employee_payroll_detail_id");

                entity.Property(e => e.Nominal)
                    .HasPrecision(12, 2)
                    .HasColumnName("nominal");

                entity.Property(e => e.UpdateByUserId).HasColumnName("update_by_user_id");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("updated_at");
            });

            //modelBuilder.Entity<EmployeeFamiliesDetail>(entity =>
            //{
            //    entity.ToTable("employee_families_detail");

            //    entity.UseCollation("utf8mb4_general_ci");

            //    entity.Property(e => e.id).HasColumnName("id");

            //    entity.Property(e => e.created_at)
            //        .HasColumnType("timestamp")
            //        .HasColumnName("created_at");

            //    entity.Property(e => e.deleted_at)
            //        .HasColumnType("timestamp")
            //        .HasColumnName("deleted_at");

            //    entity.Property(e => e.education)
            //        .HasMaxLength(20)
            //        .HasColumnName("education");

            //    entity.Property(e => e.employee_id).HasColumnName("employee_id");

            //    entity.Property(e => e.employee_name)
            //        .HasMaxLength(255)
            //        .HasColumnName("employee_name");

            //    entity.Property(e => e.gender)
            //        .HasMaxLength(10)
            //        .HasColumnName("gender");

            //    entity.Property(e => e.name)
            //        .HasMaxLength(255)
            //        .HasColumnName("name");

            //    entity.Property(e => e.occupation)
            //        .HasMaxLength(255)
            //        .HasColumnName("occupation");

            //    entity.Property(e => e.status)
            //        .HasMaxLength(25)
            //        .HasColumnName("status");

            //    entity.Property(e => e.updated_at)
            //        .HasColumnType("timestamp")
            //        .HasColumnName("updated_at");
            //});


            modelBuilder.Entity<EmployeeFamiliesDetail>(entity =>
            {
                entity.ToTable("employee_families_detail");

                entity.UseCollation("utf8mb4_general_ci");

                entity.Property(e => e.id).HasColumnName("id");

                entity.Property(e => e.created_at)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_at");

                entity.Property(e => e.deleted_at)
                    .HasColumnType("timestamp")
                    .HasColumnName("deleted_at");

                entity.Property(e => e.education)
                    .HasMaxLength(20)
                    .HasColumnName("education");

                entity.Property(e => e.employee_id).HasColumnName("employee_id");

                entity.Property(e => e.employee_number).HasColumnName("employee_number");

                entity.Property(e => e.gender)
                    .HasMaxLength(10)
                    .HasColumnName("gender");

                entity.Property(e => e.name)
                    .HasMaxLength(255)
                    .HasColumnName("name");

                entity.Property(e => e.occupation)
                    .HasMaxLength(255)
                    .HasColumnName("occupation");

                entity.Property(e => e.status)
                    .HasMaxLength(25)
                    .HasColumnName("status");

                entity.Property(e => e.updated_at)
                    .HasColumnType("timestamp")
                    .HasColumnName("updated_at");
            });


            modelBuilder.Entity<EmployeePayrollDetail>(entity =>
            {
                entity.ToTable("employee_payroll_detail");

                entity.UseCollation("utf8mb4_unicode_ci");

                entity.HasIndex(e => new { e.id, e.employee_id, e.bank_id, e.ptkp_detail_id, e.positional_allowance_detail_id }, "IDX_employee_payroll_detail");

                entity.HasIndex(e => new { e.npwp, e.nama_ibu_kandung, e.email_slip, e.password_slip }, "IDX_employee_payroll_detail2")
                    .HasAnnotation("MySql:FullTextIndex", true);

                entity.Property(e => e.id).HasColumnName("id");

                entity.Property(e => e.bank_id).HasColumnName("bank_id");

                entity.Property(e => e.bpjs_kis_effective_date).HasColumnName("bpjs_kis_effective_date");

                entity.Property(e => e.bpjs_kis_number)
                    .HasMaxLength(50)
                    .HasColumnName("bpjs_kis_number");

                entity.Property(e => e.bpjs_tk_number)
                   .HasMaxLength(50)
                   .HasColumnName("bpjs_tk_number");

                entity.Property(e => e.bpjs_tk_effective_date).HasColumnName("bpjs_tk_effective_date");

                entity.Property(e => e.child).HasColumnName("child");

                entity.Property(e => e.created_at)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_at");

                entity.Property(e => e.deleted_at)
                    .HasColumnType("timestamp")
                    .HasColumnName("deleted_at");

                entity.Property(e => e.email_slip)
                    .HasMaxLength(191)
                    .HasColumnName("email_slip")
                    .HasDefaultValueSql("'-'");

                entity.Property(e => e.employee_id).HasColumnName("employee_id");

                entity.Property(e => e.employee_type)
                    .HasColumnType("enum('normal','khusus')")
                    .HasColumnName("employee_type")
                    .HasDefaultValueSql("'normal'");

                entity.Property(e => e.marital_status)
                    .HasColumnType("enum('single','menikah','cerai hidup','cerai mati')")
                    .HasColumnName("marital_status");

                entity.Property(e => e.nama_ibu_kandung)
                    .HasMaxLength(191)
                    .HasColumnName("nama_ibu_kandung");

                entity.Property(e => e.npwp)
                    .HasMaxLength(191)
                    .HasColumnName("npwp")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.npwp_date)
                    .HasColumnName("npwp_date")
                    .HasDefaultValueSql("'1900-01-01'");

                entity.Property(e => e.password_slip)
                    .HasMaxLength(191)
                    .HasColumnName("password_slip")
                    .HasDefaultValueSql("'-'");

                entity.Property(e => e.positional_allowance_detail_id).HasColumnName("positional_allowance_detail_id");

                entity.Property(e => e.ptkp)
                    .HasMaxLength(255)
                    .HasColumnName("ptkp");

                entity.Property(e => e.ptkp_detail_id).HasColumnName("ptkp_detail_id");

                entity.Property(e => e.salary)
                    .HasPrecision(12, 2)
                    .HasColumnName("salary");

                entity.Property(e => e.status)
                    .HasColumnType("enum('completed','not completed')")
                    .HasColumnName("status")
                    .HasDefaultValueSql("'not completed'");

                entity.Property(e => e.tax_status)
                    .HasColumnType("enum('tetap','expatriat','harian')")
                    .HasColumnName("tax_status");

                entity.Property(e => e.total)
                    .HasPrecision(12, 2)
                    .HasColumnName("total");

                entity.Property(e => e.type_bpjs_kis_transaction)
                    .HasColumnType("enum('gross','nett')")
                    .HasColumnName("type_bpjs_kis_transaction");

                entity.Property(e => e.type_bpjs_tk_transaction)
                    .HasColumnType("enum('gross','nett')")
                    .HasColumnName("type_bpjs_tk_transaction");

                entity.Property(e => e.type_tax_transaction)
                    .HasColumnType("enum('gross','nett')")
                    .HasColumnName("type_tax_transaction");

                entity.Property(e => e.update_by_user_id).HasColumnName("update_by_user_id");

                entity.Property(e => e.updated_at)
                    .HasColumnType("timestamp")
                    .HasColumnName("updated_at");
            });

            modelBuilder.Entity<EmployeePosition>(entity =>
            {
                entity.ToTable("employee_position");

                entity.HasCharSet("utf32")
                    .UseCollation("utf32_unicode_ci");

                entity.Property(e => e.id).HasColumnName("id");

                entity.Property(e => e.created_date)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_date")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.modified_date)
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate()
                    .HasColumnName("modified_date");

                entity.Property(e => e.name)
                    .HasMaxLength(255)
                    .HasColumnName("name");

                entity.Property(e => e.status)
                    .HasColumnType("enum('active','inactive')")
                    .HasColumnName("status")
                    .HasDefaultValueSql("'active'");

                entity.Property(e => e.user_c).HasColumnName("user_c");

                entity.Property(e => e.user_m).HasColumnName("user_m");
            });

            modelBuilder.Entity<EmployeeStatus>(entity =>
            {
                entity.ToTable("employee_status");

                entity.HasCharSet("utf32")
                    .UseCollation("utf32_unicode_ci");

                entity.Property(e => e.id).HasColumnName("id");

                entity.Property(e => e.created_date)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_date")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.modified_date)
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate()
                    .HasColumnName("modified_date");

                entity.Property(e => e.name)
                    .HasMaxLength(255)
                    .HasColumnName("name");

                entity.Property(e => e.status)
                    .HasColumnType("enum('active','inactive')")
                    .HasColumnName("status")
                    .HasDefaultValueSql("'active'");

                entity.Property(e => e.user_c).HasColumnName("user_c");

                entity.Property(e => e.user_m).HasColumnName("user_m");
            });

            modelBuilder.Entity<GroupLeader>(entity =>
            {
                entity.ToTable("group_leaders");

                entity.UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_at");

                entity.Property(e => e.DeletedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("deleted_at");

                entity.Property(e => e.EmployeeId).HasColumnName("employee_id");

                entity.Property(e => e.Status)
                    .HasMaxLength(191)
                    .HasColumnName("status")
                    .HasDefaultValueSql("'active'");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("updated_at");

                entity.Property(e => e.UpdatedByUserId).HasColumnName("updated_by_user_id");
            });

            modelBuilder.Entity<GroupMember>(entity =>
            {
                entity.ToTable("group_members");

                entity.UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_at");

                entity.Property(e => e.DeletedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("deleted_at");

                entity.Property(e => e.EmployeeId).HasColumnName("employee_id");

                entity.Property(e => e.GroupLeaderId).HasColumnName("group_leader_id");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("updated_at");

                entity.Property(e => e.UpdatedByUserId).HasColumnName("updated_by_user_id");
            });

            modelBuilder.Entity<GroupMemberMandiri>(entity =>
            {
                entity.ToTable("group_member_mandiri");

                entity.UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_at");

                entity.Property(e => e.DeletedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("deleted_at");

                entity.Property(e => e.EmployeeId).HasColumnName("employee_id");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("updated_at");

                entity.Property(e => e.UpdatedByUserId).HasColumnName("updated_by_user_id");

                entity.Property(e => e.UserId).HasColumnName("user_id");
            });

            modelBuilder.Entity<HistoryEmployeeClient>(entity =>
            {
                entity.ToTable("history_employee_client");

                entity.UseCollation("utf8mb4_general_ci");

                entity.Property(e => e.id).HasColumnName("id");

                entity.Property(e => e.client_active_date).HasColumnName("client_active_date");

                entity.Property(e => e.client_expired_date).HasColumnName("client_expired_date");

                entity.Property(e => e.client_new).HasColumnName("client_new");

                entity.Property(e => e.client_old).HasColumnName("client_old");

                entity.Property(e => e.created_by_user_id).HasColumnName("created_by_user_id");

                entity.Property(e => e.created_date)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_date")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.deleted_by_user_id).HasColumnName("deleted_by_user_id");

                entity.Property(e => e.deleted_time)
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate()
                    .HasColumnName("deleted_time");

                entity.Property(e => e.division_new).HasColumnName("division_new");

                entity.Property(e => e.division_old).HasColumnName("division_old");

                entity.Property(e => e.emp_internal_id).HasColumnName("emp_internal_id");

                entity.Property(e => e.emp_position_new).HasColumnName("emp_position_new");

                entity.Property(e => e.emp_position_old).HasColumnName("emp_position_old");

                entity.Property(e => e.emp_status_new).HasColumnName("emp_status_new");

                entity.Property(e => e.emp_status_old).HasColumnName("emp_status_old");

                entity.Property(e => e.employee_id).HasColumnName("employee_id");

                entity.Property(e => e.employee_number).HasColumnName("employee_number");

                entity.Property(e => e.job_new).HasColumnName("job_new");

                entity.Property(e => e.job_old).HasColumnName("job_old");

                entity.Property(e => e.name)
                    .HasMaxLength(255)
                    .HasColumnName("name")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.notes)
                    .HasMaxLength(255)
                    .HasColumnName("notes");

                entity.Property(e => e.project_new).HasColumnName("project_new");

                entity.Property(e => e.project_old).HasColumnName("project_old");

                entity.Property(e => e.status)
                    .HasColumnType("enum('active','inactive')")
                    .HasColumnName("status")
                    .HasDefaultValueSql("'active'")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.updated_by_user_id).HasColumnName("updated_by_user_id");

                entity.Property(e => e.updated_time)
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate()
                    .HasColumnName("updated_time");
            });

            modelBuilder.Entity<HistoryEmployeeContract>(entity =>
            {
                entity.ToTable("history_employee_contract");

                entity.UseCollation("utf8mb4_general_ci");

                entity.Property(e => e.id).HasColumnName("id");

                entity.Property(e => e.contract_end).HasColumnName("contract_end");

                entity.Property(e => e.contract_extend_end).HasColumnName("contract_extend_end");

                entity.Property(e => e.contract_extend_start).HasColumnName("contract_extend_start");

                entity.Property(e => e.contract_start).HasColumnName("contract_start");

                entity.Property(e => e.created_by_user_id).HasColumnName("created_by_user_id");

                entity.Property(e => e.contract_status)
                    .HasColumnType("enum('active','inactive')")
                    .HasColumnName("contract_status");

                entity.Property(e => e.created_date)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_date")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.deleted_by_user_id).HasColumnName("deleted_by_user_id");

                entity.Property(e => e.deleted_time)
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate()
                    .HasColumnName("deleted_time");

                entity.Property(e => e.employee_id).HasColumnName("employee_id");

                entity.Property(e => e.employee_number).HasColumnName("employee_number");

                entity.Property(e => e.join_date).HasColumnName("join_date");

                entity.Property(e => e.join_extend_start).HasColumnName("join_extend_start");

                entity.Property(e => e.name)
                    .HasMaxLength(255)
                    .HasColumnName("name")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.nik)
                    .HasMaxLength(255)
                    .HasColumnName("nik");

                entity.Property(e => e.notes)
                    .HasMaxLength(255)
                    .HasColumnName("notes");

                entity.Property(e => e.status)
                    .HasColumnType("enum('extend contract','new contract')")
                    .HasColumnName("status")
                    .HasDefaultValueSql("'new contract'")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.updated_by_user_id).HasColumnName("updated_by_user_id");

                entity.Property(e => e.updated_time)
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate()
                    .HasColumnName("updated_time");
            });

            modelBuilder.Entity<HistoryEmployeeRehire>(entity =>
            {
                entity.ToTable("history_employee_rehire");

                entity.UseCollation("utf8mb4_general_ci");

                entity.Property(e => e.id).HasColumnName("id");

                entity.Property(e => e.contract_end_new).HasColumnName("contract_end_new");

                entity.Property(e => e.contract_end_old).HasColumnName("contract_end_old");

                entity.Property(e => e.contract_start_new).HasColumnName("contract_start_new");

                entity.Property(e => e.contract_start_old).HasColumnName("contract_start_old");

                entity.Property(e => e.created_by_user_id).HasColumnName("created_by_user_id");

                entity.Property(e => e.created_date)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_date")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.employee_id).HasColumnName("employee_id");

                entity.Property(e => e.employee_number).HasColumnName("employee_number");

                entity.Property(e => e.join_date_new).HasColumnName("join_date_new");

                entity.Property(e => e.join_date_old).HasColumnName("join_date_old");

                entity.Property(e => e.name)
                    .HasMaxLength(255)
                    .HasColumnName("name")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.nik)
                    .HasMaxLength(255)
                    .HasColumnName("nik");

                entity.Property(e => e.notes)
                    .HasMaxLength(255)
                    .HasColumnName("notes");

                entity.Property(e => e.status)
                    .HasColumnType("enum('Rehire')")
                    .HasColumnName("status")
                    .HasDefaultValueSql("'Rehire'")
                    .UseCollation("utf8mb4_unicode_ci");
            });

            modelBuilder.Entity<HistoryEmployeeResign>(entity =>
            {
                entity.ToTable("history_employee_resign");

                entity.UseCollation("utf8mb4_general_ci");

                entity.Property(e => e.id).HasColumnName("id");

                entity.Property(e => e.contract_end_last).HasColumnName("contract_end_last");

                entity.Property(e => e.contract_start_last).HasColumnName("contract_start_last");

                entity.Property(e => e.created_by_user_id).HasColumnName("created_by_user_id");

                entity.Property(e => e.created_date)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_date")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.emp_position_id).HasColumnName("emp_position_id");

                entity.Property(e => e.emp_position_name)
                    .HasMaxLength(255)
                    .HasColumnName("emp_position_name");

                entity.Property(e => e.emp_status_id).HasColumnName("emp_status_id");

                entity.Property(e => e.emp_status_name)
                    .HasMaxLength(255)
                    .HasColumnName("emp_status_name");

                entity.Property(e => e.employee_id).HasColumnName("employee_id");

                entity.Property(e => e.employee_number).HasColumnName("employee_number");

                entity.Property(e => e.join_date_last).HasColumnName("join_date_last");

                entity.Property(e => e.membership_number_jkn_kis)
                    .HasMaxLength(255)
                    .HasColumnName("membership_number_jkn_kis");

                entity.Property(e => e.name)
                    .HasMaxLength(255)
                    .HasColumnName("name")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.nik)
                    .HasMaxLength(255)
                    .HasColumnName("nik");

                entity.Property(e => e.notes)
                    .HasMaxLength(255)
                    .HasColumnName("notes");

                entity.Property(e => e.phone_number)
                    .HasMaxLength(255)
                    .HasColumnName("phone_number");

                entity.Property(e => e.resign_date)
                    .HasColumnType("timestamp")
                    .HasColumnName("resign_date")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.status)
                    .HasColumnType("enum('Resign')")
                    .HasColumnName("status")
                    .HasDefaultValueSql("'Resign'")
                    .UseCollation("utf8mb4_unicode_ci");
            });

            modelBuilder.Entity<Holiday>(entity =>
            {
                entity.ToTable("holiday");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_date")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.Date).HasColumnName("date");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate()
                    .HasColumnName("modified_date");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .HasColumnName("name");

                entity.Property(e => e.Status)
                    .HasColumnType("enum('active','inactive')")
                    .HasColumnName("status")
                    .HasDefaultValueSql("'active'");

                entity.Property(e => e.UserC).HasColumnName("user_c");

                entity.Property(e => e.UserM).HasColumnName("user_m");
            });

            modelBuilder.Entity<Job>(entity =>
            {
                entity.ToTable("job");

                entity.HasCharSet("utf32")
                    .UseCollation("utf32_unicode_ci");

                entity.HasIndex(e => e.id, "IDX_job_id");

                entity.Property(e => e.id).HasColumnName("id");

                entity.Property(e => e.created_date)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_date")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.modified_date)
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate()
                    .HasColumnName("modified_date");

                entity.Property(e => e.name)
                    .HasMaxLength(255)
                    .HasColumnName("name");

                entity.Property(e => e.status)
                    .HasColumnType("enum('active','inactive')")
                    .HasColumnName("status")
                    .HasDefaultValueSql("'active'");

                entity.Property(e => e.user_c).HasColumnName("user_c");

                entity.Property(e => e.user_m).HasColumnName("user_m");
            });

            modelBuilder.Entity<KeysApi>(entity =>
            {
                entity.ToTable("keys_api");

                entity.HasCharSet("utf8mb3")
                    .UseCollation("utf8mb3_general_ci");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.DateCreated).HasColumnName("date_created");

                entity.Property(e => e.IgnoreLimits).HasColumnName("ignore_limits");

                entity.Property(e => e.Key)
                    .HasMaxLength(40)
                    .HasColumnName("key");

                entity.Property(e => e.Level).HasColumnName("level");
            });

            modelBuilder.Entity<Leaf>(entity =>
            {
                entity.ToTable("leaves");

                entity.HasCharSet("utf32")
                    .UseCollation("utf32_unicode_ci");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_date")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.Date).HasColumnName("date");

                entity.Property(e => e.EmpId).HasColumnName("emp_id");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate()
                    .HasColumnName("modified_date");

                entity.Property(e => e.Reason)
                    .HasMaxLength(255)
                    .HasColumnName("reason");

                entity.Property(e => e.Status)
                    .HasColumnType("enum('active','inactive')")
                    .HasColumnName("status")
                    .HasDefaultValueSql("'active'");

                entity.Property(e => e.UserC).HasColumnName("user_c");

                entity.Property(e => e.UserM).HasColumnName("user_m");
            });

            modelBuilder.Entity<Medical>(entity =>
            {
                entity.ToTable("medical");

                entity.HasCharSet("utf32")
                    .UseCollation("utf32_unicode_ci");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_date")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.EmpId).HasColumnName("emp_id");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate()
                    .HasColumnName("modified_date");

                entity.Property(e => e.Nominal).HasColumnName("nominal");

                entity.Property(e => e.Status)
                    .HasColumnType("enum('active','inactive','changed')")
                    .HasColumnName("status")
                    .HasDefaultValueSql("'active'");

                entity.Property(e => e.UserC).HasColumnName("user_c");

                entity.Property(e => e.UserM).HasColumnName("user_m");
            });

            modelBuilder.Entity<MedicalBalance>(entity =>
            {
                entity.ToTable("medical_balances");

                entity.UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Balance).HasColumnName("balance");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_at");

                entity.Property(e => e.DeletedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("deleted_at");

                entity.Property(e => e.EmpId).HasColumnName("emp_id");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("updated_at");

                entity.Property(e => e.UpdatedByUserId).HasColumnName("updated_by_user_id");
            });

            modelBuilder.Entity<MedicalReimbursement>(entity =>
            {
                entity.ToTable("medical_reimbursement");

                entity.HasCharSet("utf32")
                    .UseCollation("utf32_unicode_ci");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Attachment)
                    .HasColumnType("text")
                    .HasColumnName("attachment");

                entity.Property(e => e.Balance).HasColumnName("balance");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_date")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.Date).HasColumnName("date");

                entity.Property(e => e.DeletedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("deleted_at");

                entity.Property(e => e.EmpId).HasColumnName("emp_id");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate()
                    .HasColumnName("modified_date");

                entity.Property(e => e.Nominal).HasColumnName("nominal");

                entity.Property(e => e.RealNominal).HasColumnName("real_nominal");

                entity.Property(e => e.Status)
                    .HasColumnType("enum('not post','posted')")
                    .HasColumnName("status")
                    .HasDefaultValueSql("'not post'");

                entity.Property(e => e.UserC).HasColumnName("user_c");

                entity.Property(e => e.UserM).HasColumnName("user_m");
            });

            modelBuilder.Entity<Migration>(entity =>
            {
                entity.ToTable("migrations");

                entity.UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Batch).HasColumnName("batch");

                entity.Property(e => e.Migration1)
                    .HasMaxLength(255)
                    .HasColumnName("migration");
            });

            modelBuilder.Entity<Overtime>(entity =>
            {
                entity.ToTable("overtime");

                entity.HasCharSet("utf32")
                    .UseCollation("utf32_unicode_ci");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_date")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.Date).HasColumnName("date");

                entity.Property(e => e.DeletedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("deleted_at");

                entity.Property(e => e.EmpId).HasColumnName("emp_id");

                entity.Property(e => e.EndOut)
                    .HasColumnType("datetime")
                    .HasColumnName("end_out");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate()
                    .HasColumnName("modified_date");

                entity.Property(e => e.Reason)
                    .HasMaxLength(255)
                    .HasColumnName("reason");

                entity.Property(e => e.StartIn)
                    .HasColumnType("timestamp")
                    .HasColumnName("start_in");

                entity.Property(e => e.Status)
                    .HasColumnType("enum('active','inactive')")
                    .HasColumnName("status")
                    .HasDefaultValueSql("'active'");

                entity.Property(e => e.TimeGoHome)
                    .HasColumnType("time")
                    .HasColumnName("time_go_home");

                entity.Property(e => e.UserC).HasColumnName("user_c");

                entity.Property(e => e.UserM).HasColumnName("user_m");
            });

            modelBuilder.Entity<Project>(entity =>
            {
                entity.ToTable("projects");

                entity.HasCharSet("utf32")
                    .UseCollation("utf32_unicode_ci");

                entity.Property(e => e.id).HasColumnName("id");

                entity.Property(e => e.client_id).HasColumnName("client_id");

                entity.Property(e => e.created_date)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_date")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.leaves_sub).HasColumnName("leaves_sub");

                entity.Property(e => e.modified_date)
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate()
                    .HasColumnName("modified_date");

                entity.Property(e => e.name)
                    .HasMaxLength(100)
                    .HasColumnName("name");

                entity.Property(e => e.status)
                    .HasColumnType("enum('Active','Inactive')")
                    .HasColumnName("status")
                    .HasDefaultValueSql("'Active'");

                entity.Property(e => e.user_c).HasColumnName("user_c");

                entity.Property(e => e.user_m).HasColumnName("user_m");
            });

            modelBuilder.Entity<RawAttendance>(entity =>
            {
                entity.ToTable("raw_attendance");

                entity.HasCharSet("utf32")
                    .UseCollation("utf32_unicode_ci");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_date")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.Date).HasColumnName("date");

                entity.Property(e => e.FingerId).HasColumnName("finger_id");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate()
                    .HasColumnName("modified_date");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .HasColumnName("name");

                entity.Property(e => e.TapTime)
                    .HasColumnType("time")
                    .HasColumnName("tap_time");

                entity.Property(e => e.UserC).HasColumnName("user_c");
            });

            modelBuilder.Entity<SalaryCut>(entity =>
            {
                entity.ToTable("salary_cut");

                entity.UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_at");

                entity.Property(e => e.DeletedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("deleted_at");

                entity.Property(e => e.EmployeePayrollDetailId).HasColumnName("employee_payroll_detail_id");

                entity.Property(e => e.Name)
                    .HasMaxLength(191)
                    .HasColumnName("name");

                entity.Property(e => e.Nominal)
                    .HasPrecision(12, 2)
                    .HasColumnName("nominal");

                entity.Property(e => e.UpdateByUserId).HasColumnName("update_by_user_id");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("updated_at");
            });

            modelBuilder.Entity<SalaryCutComponentUpah>(entity =>
            {
                entity.ToTable("salary_cut_component_upah");

                entity.UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Component)
                    .HasColumnType("text")
                    .HasColumnName("component");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_at");

                entity.Property(e => e.DeletedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("deleted_at");

                entity.Property(e => e.IsActive)
                    .HasColumnName("is_active")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.IsProrate)
                    .HasColumnName("is_prorate")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.Nominal).HasColumnName("nominal");

                entity.Property(e => e.SalaryCutMasterId).HasColumnName("salary_cut_master_id");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("updated_at");

                entity.Property(e => e.UpdatedByUserId).HasColumnName("updated_by_user_id");
            });

            modelBuilder.Entity<SalaryCutMaster>(entity =>
            {
                entity.ToTable("salary_cut_master");

                entity.UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_at");

                entity.Property(e => e.DeletedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("deleted_at");

                entity.Property(e => e.Name)
                    .HasMaxLength(191)
                    .HasColumnName("name");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("updated_at");

                entity.Property(e => e.UpdatedByUserId).HasColumnName("updated_by_user_id");
            });

            modelBuilder.Entity<SalaryCutSetting>(entity =>
            {
                entity.ToTable("salary_cut_setting");

                entity.UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ClientId).HasColumnName("client_id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_at");

                entity.Property(e => e.DeletedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("deleted_at");

                entity.Property(e => e.EmployeePositionId).HasColumnName("employee_position_id");

                entity.Property(e => e.Nominal).HasColumnName("nominal");

                entity.Property(e => e.ProjectId).HasColumnName("project_id");

                entity.Property(e => e.SalaryCutMasterId).HasColumnName("salary_cut_master_id");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("updated_at");

                entity.Property(e => e.UpdatedByUserId).HasColumnName("updated_by_user_id");
            });

            modelBuilder.Entity<Setting>(entity =>
            {
                entity.ToTable("settings");

                entity.HasCharSet("utf32")
                    .UseCollation("utf32_unicode_ci");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .HasColumnName("name");

                entity.Property(e => e.Status)
                    .HasColumnType("enum('active','inactive')")
                    .HasColumnName("status")
                    .HasDefaultValueSql("'active'");

                entity.Property(e => e.UserC).HasColumnName("user_c");

                entity.Property(e => e.UserM).HasColumnName("user_m");

                entity.Property(e => e.Value)
                    .HasMaxLength(25)
                    .HasColumnName("value");
            });

            modelBuilder.Entity<Sick>(entity =>
            {
                entity.ToTable("sick");

                entity.HasCharSet("utf32")
                    .UseCollation("utf32_unicode_ci");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_date")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.Date).HasColumnName("date");

                entity.Property(e => e.EmpId).HasColumnName("emp_id");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate()
                    .HasColumnName("modified_date");

                entity.Property(e => e.Reason)
                    .HasMaxLength(255)
                    .HasColumnName("reason");

                entity.Property(e => e.Status)
                    .HasColumnType("enum('active','inactive')")
                    .HasColumnName("status")
                    .HasDefaultValueSql("'active'");

                entity.Property(e => e.UserC).HasColumnName("user_c");

                entity.Property(e => e.UserM).HasColumnName("user_m");
            });

            modelBuilder.Entity<TimeSheet>(entity =>
            {
                entity.ToTable("time_sheet");

                entity.UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Activity)
                    .HasColumnType("text")
                    .HasColumnName("activity");

                entity.Property(e => e.AssignedTc).HasColumnName("assigned_tc");

                entity.Property(e => e.AttendanceHistoryId).HasColumnName("attendance_history_id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_at");

                entity.Property(e => e.Date).HasColumnName("date");

                entity.Property(e => e.DeletedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("deleted_at");

                entity.Property(e => e.EmployeeId).HasColumnName("employee_id");

                entity.Property(e => e.ExecutedTc).HasColumnName("executed_tc");

                entity.Property(e => e.Remarks)
                    .HasColumnType("text")
                    .HasColumnName("remarks");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("updated_at");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("users");

                entity.HasCharSet("utf32")
                    .UseCollation("utf32_unicode_ci");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_date")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.EmpId).HasColumnName("emp_id");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate()
                    .HasColumnName("modified_date");

                entity.Property(e => e.Password)
                    .HasMaxLength(255)
                    .HasColumnName("password");

                entity.Property(e => e.Status)
                    .HasColumnType("enum('active','inactive')")
                    .HasColumnName("status")
                    .HasDefaultValueSql("'active'");

                entity.Property(e => e.UserC).HasColumnName("user_c");

                entity.Property(e => e.UserM).HasColumnName("user_m");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
