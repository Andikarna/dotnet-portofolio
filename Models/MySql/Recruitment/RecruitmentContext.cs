using System;
using System.Collections.Generic;
using BasicProject.Models.MySql.Recruitment;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Extensions.Configuration;


namespace AdidataDbContext.Models.MySql.Recruitment
{

    public partial class RecruitmentContext : DbContext
    {

        private readonly IConfiguration _configuration;
        public RecruitmentContext(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public RecruitmentContext(DbContextOptions<RecruitmentContext> options, IConfiguration configuration)
            : base(options)
        {
            _configuration = configuration;
        }

        public virtual DbSet<CrudTable> CrudTables { get; set; } = null!;
       
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                //optionsBuilder.UseMySql("server=10.20.30.145;port=3306;user=dev1;password=Dev1234;database=hrm_dev", Microsoft.EntityFrameworkCore.ServerVersion.Parse("8.0.34-mysql"));
                optionsBuilder.UseMySql(_configuration.GetConnectionString("Recruitment"), Microsoft.EntityFrameworkCore.ServerVersion.Parse("10.4.28-mariadb"));

            }
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseCollation("utf8mb4_0900_ai_ci")
                .HasCharSet("utf8mb4");


            modelBuilder.Entity<CrudTable>(entity =>
            {
                entity.ToTable("crud_table");

                entity.HasKey(e => e.Id);

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .IsRequired()
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Data)
                    .HasColumnName("data")
                    .HasMaxLength(255)
                    .IsRequired();
            });

        }
        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
