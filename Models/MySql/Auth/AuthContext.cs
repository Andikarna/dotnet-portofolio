
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Extensions.Configuration;
using Pomelo.EntityFrameworkCore.MySql;

namespace AdidataDbContext.Models.MySql.Auth
{
    public partial class AuthContext : DbContext
    {

        private readonly IConfiguration _configuration;
        public AuthContext(IConfiguration configuration)
        {
            _configuration = configuration;

        }

        public AuthContext(DbContextOptions<AuthContext> options, IConfiguration configuration)
            : base(options)
        {
            _configuration = configuration;
        }


        public virtual DbSet<Approval> Approvals { get; set; } = null!;
        public virtual DbSet<ApprovalHistory> ApprovalHistories { get; set; } = null!;
        public virtual DbSet<ApprovalStatus> ApprovalStatuses { get; set; } = null!;
        public virtual DbSet<ApprovalType> ApprovalTypes { get; set; } = null!;
        public virtual DbSet<FailedJob> FailedJobs { get; set; } = null!;
        public virtual DbSet<FeatureType> FeatureTypes { get; set; } = null!;
        public virtual DbSet<GrantType> GrantTypes { get; set; } = null!;
        public virtual DbSet<Log> Logs { get; set; } = null!;
        public virtual DbSet<LoginAttempt> LoginAttempts { get; set; } = null!;
        public virtual DbSet<Menu> Menus { get; set; } = null!;
        public virtual DbSet<Migration> Migrations { get; set; } = null!;
        public virtual DbSet<ModelHasPermission> ModelHasPermissions { get; set; } = null!;
        public virtual DbSet<ModelHasRole> ModelHasRoles { get; set; } = null!;
        public virtual DbSet<PasswordReset> PasswordResets { get; set; } = null!;
        public virtual DbSet<Permission> Permissions { get; set; } = null!;
        public virtual DbSet<PermissionMenu> PermissionMenus { get; set; } = null!;
        public virtual DbSet<PersonalAccessToken> PersonalAccessTokens { get; set; } = null!;
        public virtual DbSet<Role> Roles { get; set; } = null!;
        public virtual DbSet<User> Users { get; set; } = null!;
        public virtual DbSet<UserLog> UserLogs { get; set; } = null!;
        public virtual DbSet<UsersToken> UsersTokens { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseMySql(_configuration.GetConnectionString("Auth"), Microsoft.EntityFrameworkCore.ServerVersion.Parse("10.4.28-mariadb"));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseCollation("utf8mb4_0900_ai_ci")
                .HasCharSet("utf8mb4");

            modelBuilder.Entity<Approval>(entity =>
            {
                entity.ToTable("approvals");

                entity.UseCollation("utf8mb4_unicode_ci");

                entity.HasIndex(e => e.ApprovalByUserId, "approvals_approval_by_user_id_foreign");

                entity.HasIndex(e => e.ApprovalStatusId, "approvals_approval_status_id_foreign");

                entity.HasIndex(e => new { e.RequestableType, e.RequestableId }, "approvals_requestable_type_requestable_id_index");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ApprovalByUserId).HasColumnName("approval_by_user_id");

                entity.Property(e => e.ApprovalDate)
                    .HasColumnType("datetime")
                    .HasColumnName("approval_date")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.ApprovalStatusId).HasColumnName("approval_status_id");

                entity.Property(e => e.ApprovalTypeId).HasColumnName("approval_type_id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_at");

                entity.Property(e => e.DeletedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("deleted_at");

                entity.Property(e => e.Remarks)
                    .HasColumnType("text")
                    .HasColumnName("remarks");

                entity.Property(e => e.RequestableId).HasColumnName("requestable_id");

                entity.Property(e => e.RequestableType)
                    .HasMaxLength(191)
                    .HasColumnName("requestable_type");

                entity.Property(e => e.RequesterUserId).HasColumnName("requester_user_id");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("updated_at");

                entity.Property(e => e.UpdatedByUserId)
                    .HasColumnName("updated_by_user_id")
                    .HasDefaultValueSql("'1'");

                entity.HasOne(d => d.ApprovalStatus)
                    .WithMany(p => p.Approvals)
                    .HasForeignKey(d => d.ApprovalStatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("approvals_approval_status_id_foreign");
            });

            modelBuilder.Entity<ApprovalHistory>(entity =>
            {
                entity.ToTable("approval_histories");

                entity.UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ApprovalId).HasColumnName("approval_id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_at");

                entity.Property(e => e.DeletedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("deleted_at");

                entity.Property(e => e.NewRequestStatusId).HasColumnName("new_request_status_id");

                entity.Property(e => e.OldApprovalStatusId).HasColumnName("old_approval_status_id");

                entity.Property(e => e.Remarks)
                    .HasColumnType("text")
                    .HasColumnName("remarks");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("updated_at");

                entity.Property(e => e.UpdatedByUserId).HasColumnName("updated_by_user_id");

                entity.Property(e => e.UpdatedByUserName)
                    .HasMaxLength(191)
                    .HasColumnName("updated_by_user_name");

                entity.Property(e => e.UpdatedByUserRole)
                    .HasMaxLength(191)
                    .HasColumnName("updated_by_user_role");
            });

            modelBuilder.Entity<ApprovalStatus>(entity =>
            {
                entity.ToTable("approval_statuses");

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

                entity.Property(e => e.UpdatedByUserId)
                    .HasColumnName("updated_by_user_id")
                    .HasDefaultValueSql("'1'");
            });

            modelBuilder.Entity<ApprovalType>(entity =>
            {
                entity.ToTable("approval_types");

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

            modelBuilder.Entity<FailedJob>(entity =>
            {
                entity.ToTable("failed_jobs");

                entity.UseCollation("utf8mb4_unicode_ci");

                entity.HasIndex(e => e.Uuid, "failed_jobs_uuid_unique")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Connection)
                    .HasColumnType("text")
                    .HasColumnName("connection");

                entity.Property(e => e.Exception).HasColumnName("exception");

                entity.Property(e => e.FailedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("failed_at")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.Payload).HasColumnName("payload");

                entity.Property(e => e.Queue)
                    .HasColumnType("text")
                    .HasColumnName("queue");

                entity.Property(e => e.Uuid)
                    .HasMaxLength(191)
                    .HasColumnName("uuid");
            });

            modelBuilder.Entity<FeatureType>(entity =>
            {
                entity.ToTable("feature_type");

                entity.UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.id).HasColumnName("id");

                entity.Property(e => e.created_date)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_date");

                entity.Property(e => e.deleted_date)
                    .HasColumnType("timestamp")
                    .HasColumnName("deleted_date");

                entity.Property(e => e.feature_name)
                    .HasMaxLength(255)
                    .HasColumnName("feature_name");

                entity.Property(e => e.menu_id).HasColumnName("menu_id");

                entity.Property(e => e.updated_date)
                    .HasColumnType("timestamp")
                    .HasColumnName("updated_date");
            });

            modelBuilder.Entity<GrantType>(entity =>
            {
                entity.ToTable("grant_type");

                entity.UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.id).HasColumnName("id");

                entity.Property(e => e.created_date)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_date");

                entity.Property(e => e.deleted_date)
                    .HasColumnType("timestamp")
                    .HasColumnName("deleted_date");

                entity.Property(e => e.grant_name)
                    .HasMaxLength(255)
                    .HasColumnName("grant_name");

                entity.Property(e => e.updated_date)
                    .HasColumnType("timestamp")
                    .HasColumnName("updated_date");
            });

            modelBuilder.Entity<Log>(entity =>
            {
                entity.ToTable("logs");

                entity.UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.id).HasColumnName("id");

                entity.Property(e => e.created_at)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_at");

                entity.Property(e => e.logs)
                    .HasColumnType("text")
                    .HasColumnName("logs");

                entity.Property(e => e.updated_at)
                    .HasColumnType("timestamp")
                    .HasColumnName("updated_at");
            });

            modelBuilder.Entity<LoginAttempt>(entity =>
            {
                entity.ToTable("login_attempts");

                entity.Property(e => e.id).HasColumnName("id");

                entity.Property(e => e.attempt_time)
                    .HasColumnType("timestamp")
                    .HasColumnName("attempt_time")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.error_type)
                    .HasColumnType("text")
                    .HasColumnName("error_type");

                entity.Property(e => e.hostname)
                    .HasColumnType("text")
                    .HasColumnName("hostname");

                entity.Property(e => e.info_api)
                    .HasColumnType("text")
                    .HasColumnName("info_api");

                entity.Property(e => e.ip_address)
                    .HasColumnType("text")
                    .HasColumnName("ip_address");

                entity.Property(e => e.mac_address)
                    .HasColumnType("text")
                    .HasColumnName("mac_address");

                entity.Property(e => e.name)
                    .HasColumnType("text")
                    .HasColumnName("name");

                entity.Property(e => e.paths)
                    .HasColumnType("text")
                    .HasColumnName("paths");

                entity.Property(e => e.user_agent)
                    .HasColumnType("text")
                    .HasColumnName("user_agent");

                entity.Property(e => e.user_id).HasColumnName("user_id");
            });

            modelBuilder.Entity<Menu>(entity =>
            {
                entity.ToTable("menus");

                entity.UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_date");

                entity.Property(e => e.DeletedDate)
                    .HasColumnType("timestamp")
                    .HasColumnName("deleted_date");

                entity.Property(e => e.MenuName)
                    .HasMaxLength(255)
                    .HasColumnName("menu_name");

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("timestamp")
                    .HasColumnName("updated_date");
            });

            modelBuilder.Entity<Migration>(entity =>
            {
                entity.ToTable("migrations");

                entity.UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Batch).HasColumnName("batch");

                entity.Property(e => e.Migration1)
                    .HasMaxLength(191)
                    .HasColumnName("migration");
            });

            modelBuilder.Entity<ModelHasPermission>(entity =>
            {
                entity.HasKey(e => new { e.PermissionId, e.ModelId, e.ModelType })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

                entity.ToTable("model_has_permissions");

                entity.UseCollation("utf8mb4_unicode_ci");

                entity.HasIndex(e => new { e.ModelId, e.ModelType }, "model_has_permissions_model_id_model_type_index");

                entity.Property(e => e.PermissionId).HasColumnName("permission_id");

                entity.Property(e => e.ModelId).HasColumnName("model_id");

                entity.Property(e => e.ModelType)
                    .HasMaxLength(191)
                    .HasColumnName("model_type");

                entity.HasOne(d => d.Permission)
                    .WithMany(p => p.ModelHasPermissions)
                    .HasForeignKey(d => d.PermissionId)
                    .HasConstraintName("model_has_permissions_permission_id_foreign");
            });

            modelBuilder.Entity<ModelHasRole>(entity =>
            {
                entity.HasKey(e => new { e.RoleId, e.ModelId, e.ModelType })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

                entity.ToTable("model_has_roles");

                entity.UseCollation("utf8mb4_unicode_ci");

                entity.HasIndex(e => new { e.ModelId, e.ModelType }, "model_has_roles_model_id_model_type_index");

                entity.Property(e => e.RoleId).HasColumnName("role_id");

                entity.Property(e => e.ModelId).HasColumnName("model_id");

                entity.Property(e => e.ModelType)
                    .HasMaxLength(191)
                    .HasColumnName("model_type");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.ModelHasRoles)
                    .HasForeignKey(d => d.RoleId)
                    .HasConstraintName("model_has_roles_role_id_foreign");
            });

            modelBuilder.Entity<PasswordReset>(entity =>
            {
                entity.ToTable("password_resets");

                entity.UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_at");

                entity.Property(e => e.CurrentPassword)
                    .HasMaxLength(255)
                    .HasColumnName("current_password");

                entity.Property(e => e.Email)
                    .HasMaxLength(191)
                    .HasColumnName("email");

                entity.Property(e => e.NewPassword)
                    .HasMaxLength(255)
                    .HasColumnName("new_password");

                entity.Property(e => e.ReNewPassword)
                    .HasMaxLength(255)
                    .HasColumnName("re_new_password");

                entity.Property(e => e.Token)
                    .HasColumnType("text")
                    .HasColumnName("token");
            });

            modelBuilder.Entity<Permission>(entity =>
            {
                entity.ToTable("permissions");

                entity.UseCollation("utf8mb4_unicode_ci");

                entity.HasIndex(e => new { e.Name, e.GuardName }, "permissions_name_guard_name_unique")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_at");

                entity.Property(e => e.Group)
                    .HasMaxLength(191)
                    .HasColumnName("group");

                entity.Property(e => e.GuardName)
                    .HasMaxLength(191)
                    .HasColumnName("guard_name")
                    .HasDefaultValueSql("'web'");

                entity.Property(e => e.Name)
                    .HasMaxLength(191)
                    .HasColumnName("name");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("updated_at");

                entity.HasMany(d => d.Roles)
                    .WithMany(p => p.Permissions)
                    .UsingEntity<Dictionary<string, object>>(
                        "RoleHasPermission",
                        l => l.HasOne<Role>().WithMany().HasForeignKey("RoleId").HasConstraintName("role_has_permissions_role_id_foreign"),
                        r => r.HasOne<Permission>().WithMany().HasForeignKey("PermissionId").HasConstraintName("role_has_permissions_permission_id_foreign"),
                        j =>
                        {
                            j.HasKey("PermissionId", "RoleId").HasName("PRIMARY").HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                            j.ToTable("role_has_permissions").UseCollation("utf8mb4_unicode_ci");

                            j.HasIndex(new[] { "RoleId" }, "role_has_permissions_role_id_foreign");

                            j.IndexerProperty<ulong>("PermissionId").HasColumnName("permission_id");

                            j.IndexerProperty<ulong>("RoleId").HasColumnName("role_id");
                        });
            });

            modelBuilder.Entity<PermissionMenu>(entity =>
            {
                entity.ToTable("permission_menus");

                entity.UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CanCreate).HasColumnName("can_create");

                entity.Property(e => e.CanDelete).HasColumnName("can_delete");

                entity.Property(e => e.CanRead).HasColumnName("can_read");

                entity.Property(e => e.CanUpdate).HasColumnName("can_update");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_date");

                entity.Property(e => e.DeletedDate)
                    .HasColumnType("timestamp")
                    .HasColumnName("deleted_date");

                entity.Property(e => e.FeatureId).HasColumnName("feature_id");

                entity.Property(e => e.GrantId).HasColumnName("grant_id");

                entity.Property(e => e.MenuId).HasColumnName("menu_id");

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("timestamp")
                    .HasColumnName("updated_date");

                entity.Property(e => e.UserId).HasColumnName("user_id");
            });

            modelBuilder.Entity<PersonalAccessToken>(entity =>
            {
                entity.ToTable("personal_access_tokens");

                entity.UseCollation("utf8mb4_unicode_ci");

                entity.HasIndex(e => e.Token, "personal_access_tokens_token_unique")
                    .IsUnique();

                entity.HasIndex(e => new { e.TokenableType, e.TokenableId }, "personal_access_tokens_tokenable_type_tokenable_id_index");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Abilities)
                    .HasColumnType("text")
                    .HasColumnName("abilities");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_at");

                entity.Property(e => e.ExpiresAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("expires_at");

                entity.Property(e => e.LastUsedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("last_used_at");

                entity.Property(e => e.Name)
                    .HasMaxLength(191)
                    .HasColumnName("name");

                entity.Property(e => e.Token)
                    .HasMaxLength(64)
                    .HasColumnName("token");

                entity.Property(e => e.TokenableId).HasColumnName("tokenable_id");

                entity.Property(e => e.TokenableType)
                    .HasMaxLength(191)
                    .HasColumnName("tokenable_type");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("updated_at");
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.ToTable("roles");

                entity.UseCollation("utf8mb4_unicode_ci");

                entity.HasIndex(e => new { e.Name, e.GuardName }, "roles_name_guard_name_unique")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_at");

                entity.Property(e => e.GuardName)
                    .HasMaxLength(191)
                    .HasColumnName("guard_name");

                entity.Property(e => e.Name)
                    .HasMaxLength(191)
                    .HasColumnName("name");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("updated_at");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("users");

                entity.UseCollation("utf8mb4_unicode_ci");

                entity.HasIndex(e => e.employee_id, "IDX_users_employee_id");

                entity.HasIndex(e => e.email, "users_email_unique")
                    .IsUnique();

                entity.Property(e => e.id).HasColumnName("id");

                entity.Property(e => e.created_at)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_at");

                entity.Property(e => e.email)
                    .HasMaxLength(191)
                    .HasColumnName("email");

                entity.Property(e => e.email_verified_at)
                    .HasColumnType("timestamp")
                    .HasColumnName("email_verified_at");

                entity.Property(e => e.employee_id).HasColumnName("employee_id");

                entity.Property(e => e.employee_role_id).HasColumnName("employee_role_id");

                entity.Property(e => e.grant_employee_type)
                    .HasColumnType("enum('internal','outsource','all')")
                    .HasColumnName("grant_employee_type")
                    .HasDefaultValueSql("'all'");

                entity.Property(e => e.is_active).HasColumnName("is_active");

                entity.Property(e => e.is_need_change_password)
                    .HasColumnName("is_need_change_password")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.lang_id)
                    .HasColumnName("lang_id")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.name)
                    .HasMaxLength(191)
                    .HasColumnName("name");

                entity.Property(e => e.password)
                    .HasMaxLength(191)
                    .HasColumnName("password");

                entity.Property(e => e.remember_token)
                    .HasColumnType("text")
                    .HasColumnName("remember_token");

                entity.Property(e => e.two_factor_confirmed_at)
                    .HasColumnType("timestamp")
                    .HasColumnName("two_factor_confirmed_at");

                entity.Property(e => e.two_factor_recovery_codes)
                    .HasColumnType("text")
                    .HasColumnName("two_factor_recovery_codes");

                entity.Property(e => e.two_factor_secret)
                    .HasColumnType("text")
                    .HasColumnName("two_factor_secret");

                entity.Property(e => e.updated_at)
                    .HasColumnType("timestamp")
                    .HasColumnName("updated_at");
            });

            modelBuilder.Entity<UserLog>(entity =>
            {
                entity.ToTable("user_log");

                entity.UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.browser)
                    .HasColumnType("text")
                    .HasColumnName("browser");

                entity.Property(e => e.created_at)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_at");

                entity.Property(e => e.hostname)
                    .HasColumnType("text")
                    .HasColumnName("hostname");

                entity.Property(e => e.ip_address)
                    .HasColumnType("text")
                    .HasColumnName("ip_address");

                entity.Property(e => e.mac_address)
                    .HasColumnType("text")
                    .HasColumnName("mac_address");

                entity.Property(e => e.name)
                    .HasColumnType("text")
                    .HasColumnName("name");

                entity.Property(e => e.url)
                    .HasColumnType("text")
                    .HasColumnName("url");

                entity.Property(e => e.user_id).HasColumnName("user_id");
            });

            modelBuilder.Entity<UsersToken>(entity =>
            {
                entity.ToTable("users_token");

                entity.UseCollation("utf8mb4_unicode_ci");

                entity.HasIndex(e => e.remember_token, "IDX_users_token_remember_token")
                    .HasAnnotation("MySql:FullTextIndex", true);

                entity.HasIndex(e => e.user_id, "IDX_users_token_user_id");

                entity.Property(e => e.id).HasColumnName("id");

                entity.Property(e => e.created_at)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_at");

                entity.Property(e => e.deleted_at)
                    .HasColumnType("timestamp")
                    .HasColumnName("deleted_at");

                entity.Property(e => e.expired_date)
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate()
                    .HasColumnName("expired_date")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.expired_time).HasColumnName("expired_time");

                entity.Property(e => e.ip_address)
                    .HasColumnType("text")
                    .HasColumnName("ip_address");

                entity.Property(e => e.remember_token)
                    .HasColumnType("text")
                    .HasColumnName("remember_token");

                entity.Property(e => e.updated_at)
                    .HasColumnType("timestamp")
                    .HasColumnName("updated_at");

                entity.Property(e => e.user_id).HasColumnName("user_id");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UsersTokens)
                    .HasForeignKey(d => d.user_id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("users_token_user_id_foreign");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
