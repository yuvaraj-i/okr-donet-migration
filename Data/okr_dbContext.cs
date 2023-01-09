//using System;
//using System.Collections.Generic;
//using Microsoft.EntityFrameworkCore;
//using Microsoft.EntityFrameworkCore.Metadata;

//namespace helloWorld.Data
//{
//    public partial class okr_dbContext : DbContext
//    {
//        public okr_dbContext()
//        {
//        }

//        public okr_dbContext(DbContextOptions<okr_dbContext> options)
//            : base(options)
//        {
//        }

//        public virtual DbSet<AbandonedObjective> AbandonedObjectives { get; set; } = null!;
//        public virtual DbSet<Accomplishment> Accomplishments { get; set; } = null!;
//        public virtual DbSet<ActivityLog> ActivityLogs { get; set; } = null!;
//        public virtual DbSet<ApplicationSetting> ApplicationSettings { get; set; } = null!;
//        public virtual DbSet<AssessmentPeriod> AssessmentPeriods { get; set; } = null!;
//        public virtual DbSet<CertificateAccomplishmentMapping> CertificateAccomplishmentMappings { get; set; } = null!;
//        public virtual DbSet<CertificateDetail> CertificateDetails { get; set; } = null!;
//        public virtual DbSet<CertificateIssuer> CertificateIssuers { get; set; } = null!;
//        public virtual DbSet<CertificateLog> CertificateLogs { get; set; } = null!;
//        public virtual DbSet<CertificateTypeDetail> CertificateTypeDetails { get; set; } = null!;
//        public virtual DbSet<CertificateTypeLog> CertificateTypeLogs { get; set; } = null!;
//        public virtual DbSet<Comment> Comments { get; set; } = null!;
//        public virtual DbSet<Company> Companies { get; set; } = null!;
//        public virtual DbSet<KeyResult> KeyResults { get; set; } = null!;
//        public virtual DbSet<Membership> Memberships { get; set; } = null!;
//        public virtual DbSet<Objective> Objectives { get; set; } = null!;
//        public virtual DbSet<QuarterlyDetail> QuarterlyDetails { get; set; } = null!;
//        public virtual DbSet<SchemaVersion> SchemaVersions { get; set; } = null!;
//        public virtual DbSet<SkillSet> SkillSets { get; set; } = null!;
//        public virtual DbSet<Team> Teams { get; set; } = null!;
//        public virtual DbSet<User> Users { get; set; } = null!;
//        public virtual DbSet<UserMentorMapping> UserMentorMappings { get; set; } = null!;
//        public virtual DbSet<UserSkillMapping> UserSkillMappings { get; set; } = null!;

//        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//        {
//            if (!optionsBuilder.IsConfigured)
//            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
//                optionsBuilder.UseMySql("server=localhost;user id=root;password=mysql1234;database=okr_db", Microsoft.EntityFrameworkCore.ServerVersion.Parse("8.0.30-mysql"));
//            }
//        }

//        protected override void OnModelCreating(ModelBuilder modelBuilder)
//        {
//            modelBuilder.UseCollation("utf8mb4_0900_ai_ci")
//                .HasCharSet("utf8mb4");

//            modelBuilder.Entity<AbandonedObjective>(entity =>
//            {
//                entity.ToTable("abandoned_objectives");

//                entity.HasCharSet("utf8mb3")
//                    .UseCollation("utf8mb3_general_ci");

//                entity.HasIndex(e => e.ObjectiveId, "fk_abandoned_objective_id_idx");

//                entity.Property(e => e.Id).HasColumnName("id");

//                entity.Property(e => e.ObjectiveId).HasColumnName("objective_id");

//                entity.Property(e => e.Reason)
//                    .HasMaxLength(200)
//                    .HasColumnName("reason");

//                entity.HasOne(d => d.Objective)
//                    .WithMany(p => p.AbandonedObjectives)
//                    .HasForeignKey(d => d.ObjectiveId)
//                    .HasConstraintName("fk_abandoned_objective_id");
//            });

//            modelBuilder.Entity<Accomplishment>(entity =>
//            {
//                entity.ToTable("accomplishments");

//                entity.HasCharSet("utf8mb3")
//                    .UseCollation("utf8mb3_unicode_ci");

//                entity.HasIndex(e => e.AccomplishedBy, "accomplished_user_id");

//                entity.HasIndex(e => e.CreatedBy, "id_idx");

//                entity.Property(e => e.AccomplishmentId).HasColumnName("accomplishment_id");

//                entity.Property(e => e.AccomplishedBy).HasColumnName("accomplished_by");

//                entity.Property(e => e.AccomplishedDate)
//                    .HasColumnType("datetime")
//                    .HasColumnName("accomplished_date");

//                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

//                entity.Property(e => e.CreatedDate)
//                    .HasColumnType("datetime")
//                    .HasColumnName("created_date")
//                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

//                entity.Property(e => e.Description)
//                    .HasMaxLength(200)
//                    .HasColumnName("description");

//                entity.Property(e => e.IsDeleted).HasColumnName("is_deleted");

//                entity.Property(e => e.LastModifiedBy).HasColumnName("last_modified_by");

//                entity.Property(e => e.Title)
//                    .HasMaxLength(50)
//                    .HasColumnName("title");

//                entity.Property(e => e.Type)
//                    .HasMaxLength(20)
//                    .HasColumnName("type");

//                entity.Property(e => e.UpdatedDate)
//                    .HasColumnType("datetime")
//                    .ValueGeneratedOnAddOrUpdate()
//                    .HasColumnName("updated_date")
//                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

//                entity.HasOne(d => d.AccomplishedByNavigation)
//                    .WithMany(p => p.AccomplishmentAccomplishedByNavigations)
//                    .HasForeignKey(d => d.AccomplishedBy)
//                    .OnDelete(DeleteBehavior.ClientSetNull)
//                    .HasConstraintName("accomplished_user_id");

//                entity.HasOne(d => d.CreatedByNavigation)
//                    .WithMany(p => p.AccomplishmentCreatedByNavigations)
//                    .HasForeignKey(d => d.CreatedBy)
//                    .OnDelete(DeleteBehavior.ClientSetNull)
//                    .HasConstraintName("created_user_id");
//            });

//            modelBuilder.Entity<ActivityLog>(entity =>
//            {
//                entity.ToTable("activity_log");

//                entity.HasCharSet("utf8mb3")
//                    .UseCollation("utf8mb3_general_ci");

//                entity.Property(e => e.Id).HasColumnName("id");

//                entity.Property(e => e.ActionDate)
//                    .HasColumnType("timestamp")
//                    .HasColumnName("action_date")
//                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

//                entity.Property(e => e.ActionItem)
//                    .HasMaxLength(50)
//                    .HasColumnName("action_item");

//                entity.Property(e => e.CommentId).HasColumnName("comment_id");

//                entity.Property(e => e.EntityId)
//                    .HasColumnName("entity_id")
//                    .HasComment("It can be user id, team id or company id.");

//                entity.Property(e => e.EntityType)
//                    .HasMaxLength(20)
//                    .HasColumnName("entity_type")
//                    .HasDefaultValueSql("'user'");

//                entity.Property(e => e.KeyResultId).HasColumnName("key_result_id");

//                entity.Property(e => e.Score)
//                    .HasPrecision(3, 2)
//                    .HasColumnName("score");

//                entity.Property(e => e.TopicId).HasColumnName("topic_id");

//                entity.Property(e => e.TopicType)
//                    .HasMaxLength(20)
//                    .HasColumnName("topic_type")
//                    .HasDefaultValueSql("'objective'");

//                entity.Property(e => e.UserId)
//                    .HasColumnName("user_id")
//                    .HasComment("It can be user id for entity type team, and null for user id.");
//            });

//            modelBuilder.Entity<ApplicationSetting>(entity =>
//            {
//                entity.ToTable("application_settings");

//                entity.HasCharSet("utf8mb3")
//                    .UseCollation("utf8mb3_unicode_ci");

//                entity.HasIndex(e => e.LastModifiedBy, "settings_reference_id");

//                entity.Property(e => e.Id).HasColumnName("id");

//                entity.Property(e => e.CreatedDate)
//                    .HasColumnType("datetime")
//                    .HasColumnName("created_date")
//                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

//                entity.Property(e => e.Description)
//                    .HasMaxLength(50)
//                    .HasColumnName("description");

//                entity.Property(e => e.LastModifiedBy).HasColumnName("last_modified_by");

//                entity.Property(e => e.UpdatedDate)
//                    .HasColumnType("datetime")
//                    .ValueGeneratedOnAddOrUpdate()
//                    .HasColumnName("updated_date")
//                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

//                entity.Property(e => e.Value).HasColumnName("value");

//                entity.HasOne(d => d.LastModifiedByNavigation)
//                    .WithMany(p => p.ApplicationSettings)
//                    .HasForeignKey(d => d.LastModifiedBy)
//                    .OnDelete(DeleteBehavior.ClientSetNull)
//                    .HasConstraintName("settings_reference_id");
//            });

//            modelBuilder.Entity<AssessmentPeriod>(entity =>
//            {
//                entity.ToTable("assessment_period");

//                entity.HasCharSet("utf8mb3")
//                    .UseCollation("utf8mb3_general_ci");

//                entity.Property(e => e.Id).HasColumnName("id");

//                entity.Property(e => e.CreatedDate)
//                    .HasColumnType("timestamp")
//                    .HasColumnName("created_date")
//                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

//                entity.Property(e => e.EndDate)
//                    .HasColumnType("datetime")
//                    .HasColumnName("end_date");

//                entity.Property(e => e.Quarter).HasColumnName("quarter");

//                entity.Property(e => e.StartDate)
//                    .HasColumnType("datetime")
//                    .HasColumnName("start_date");

//                entity.Property(e => e.Year).HasColumnName("year");
//            });

//            modelBuilder.Entity<CertificateAccomplishmentMapping>(entity =>
//            {
//                entity.ToTable("certificate_accomplishment_mapping");

//                entity.HasCharSet("utf8mb3")
//                    .UseCollation("utf8mb3_unicode_ci");

//                entity.HasIndex(e => e.CertificateAccomplishmentMappingId, "certificate_accomplishment_mapping_id_unique")
//                    .IsUnique();

//                entity.HasIndex(e => e.CertificateId, "id_idx");

//                entity.HasIndex(e => e.AccomplishmentId, "id_idx1");

//                entity.Property(e => e.CertificateAccomplishmentMappingId).HasColumnName("certificate_accomplishment_mapping_id");

//                entity.Property(e => e.AccomplishmentId).HasColumnName("accomplishment_id");

//                entity.Property(e => e.CertificateId).HasColumnName("certificate_id");

//                entity.HasOne(d => d.Accomplishment)
//                    .WithMany(p => p.CertificateAccomplishmentMappings)
//                    .HasForeignKey(d => d.AccomplishmentId)
//                    .OnDelete(DeleteBehavior.ClientSetNull)
//                    .HasConstraintName("fk_accomplishment_id");

//                entity.HasOne(d => d.Certificate)
//                    .WithMany(p => p.CertificateAccomplishmentMappings)
//                    .HasForeignKey(d => d.CertificateId)
//                    .OnDelete(DeleteBehavior.ClientSetNull)
//                    .HasConstraintName("fk_certificate_id");
//            });

//            modelBuilder.Entity<CertificateDetail>(entity =>
//            {
//                entity.HasKey(e => e.CertificateId)
//                    .HasName("PRIMARY");

//                entity.ToTable("certificate_details");

//                entity.HasCharSet("utf8mb3")
//                    .UseCollation("utf8mb3_unicode_ci");

//                entity.HasIndex(e => e.CertificateTypeId, "iisuer_id_idx");

//                entity.HasIndex(e => e.UserId, "user_id_idx");

//                entity.Property(e => e.CertificateId).HasColumnName("certificate_id");

//                entity.Property(e => e.CertificateTypeId).HasColumnName("certificate_type_id");

//                entity.Property(e => e.CertifiedDate)
//                    .HasColumnType("datetime")
//                    .HasColumnName("certified_date");

//                entity.Property(e => e.CreatedDate)
//                    .HasColumnType("datetime")
//                    .HasColumnName("created_date")
//                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

//                entity.Property(e => e.ExpiryDate)
//                    .HasColumnType("datetime")
//                    .HasColumnName("expiry_date");

//                entity.Property(e => e.IsDeleted)
//                    .HasColumnName("is_deleted")
//                    .HasDefaultValueSql("'0'");

//                entity.Property(e => e.Reason)
//                    .HasMaxLength(200)
//                    .HasColumnName("reason");

//                entity.Property(e => e.Status)
//                    .HasMaxLength(45)
//                    .HasColumnName("status")
//                    .HasDefaultValueSql("'pending'");

//                entity.Property(e => e.UpdatedDate)
//                    .HasColumnType("datetime")
//                    .ValueGeneratedOnAddOrUpdate()
//                    .HasColumnName("updated_date")
//                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

//                entity.Property(e => e.UserId).HasColumnName("user_id");

//                entity.Property(e => e.VerificationId)
//                    .HasMaxLength(200)
//                    .HasColumnName("verification_id");

//                entity.HasOne(d => d.CertificateType)
//                    .WithMany(p => p.CertificateDetails)
//                    .HasForeignKey(d => d.CertificateTypeId)
//                    .OnDelete(DeleteBehavior.ClientSetNull)
//                    .HasConstraintName("certificate_type_id");

//                entity.HasOne(d => d.User)
//                    .WithMany(p => p.CertificateDetails)
//                    .HasForeignKey(d => d.UserId)
//                    .OnDelete(DeleteBehavior.ClientSetNull)
//                    .HasConstraintName("user_id");
//            });

//            modelBuilder.Entity<CertificateIssuer>(entity =>
//            {
//                entity.HasKey(e => e.IssuerId)
//                    .HasName("PRIMARY");

//                entity.ToTable("certificate_issuer");

//                entity.HasCharSet("utf8mb3")
//                    .UseCollation("utf8mb3_unicode_ci");

//                entity.HasIndex(e => e.IssuerName, "issuer_name_UNIQUE")
//                    .IsUnique();

//                entity.Property(e => e.IssuerId).HasColumnName("issuer_id");

//                entity.Property(e => e.IsDeleted)
//                    .HasColumnName("is_deleted")
//                    .HasDefaultValueSql("'0'");

//                entity.Property(e => e.IssuerName)
//                    .HasMaxLength(200)
//                    .HasColumnName("issuer_name");
//            });

//            modelBuilder.Entity<CertificateLog>(entity =>
//            {
//                entity.HasKey(e => e.CertificateLogsId)
//                    .HasName("PRIMARY");

//                entity.ToTable("certificate_logs");

//                entity.HasCharSet("utf8mb3")
//                    .UseCollation("utf8mb3_unicode_ci");

//                entity.Property(e => e.CertificateLogsId).HasColumnName("certificate_logs_id");

//                entity.Property(e => e.ActionDate)
//                    .HasColumnType("timestamp")
//                    .HasColumnName("action_date")
//                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

//                entity.Property(e => e.ActionStatus)
//                    .HasMaxLength(45)
//                    .HasColumnName("action_status")
//                    .HasComment("It can be approved ,declined ,created ,edited ,deleted.");

//                entity.Property(e => e.ApproverId).HasColumnName("approver_id");

//                entity.Property(e => e.CertificateId).HasColumnName("certificate_id");
//            });

//            modelBuilder.Entity<CertificateTypeDetail>(entity =>
//            {
//                entity.HasKey(e => e.CertificateTypeId)
//                    .HasName("PRIMARY");

//                entity.ToTable("certificate_type_details");

//                entity.HasCharSet("utf8mb3")
//                    .UseCollation("utf8mb3_unicode_ci");

//                entity.HasIndex(e => e.IssuerId, "issuer_id_idx");

//                entity.Property(e => e.CertificateTypeId).HasColumnName("certificate_type_id");

//                entity.Property(e => e.CertificateTypeName)
//                    .HasMaxLength(200)
//                    .HasColumnName("certificate_type_name");

//                entity.Property(e => e.IsDeleted)
//                    .HasColumnName("is_deleted")
//                    .HasDefaultValueSql("'0'");

//                entity.Property(e => e.IssuerId).HasColumnName("issuer_id");

//                entity.HasOne(d => d.Issuer)
//                    .WithMany(p => p.CertificateTypeDetails)
//                    .HasForeignKey(d => d.IssuerId)
//                    .OnDelete(DeleteBehavior.ClientSetNull)
//                    .HasConstraintName("issuer_id");
//            });

//            modelBuilder.Entity<CertificateTypeLog>(entity =>
//            {
//                entity.ToTable("certificate_type_logs");

//                entity.HasCharSet("utf8mb3")
//                    .UseCollation("utf8mb3_unicode_ci");

//                entity.HasIndex(e => e.NewIssuerId, "new_issuer_id_constraint");

//                entity.HasIndex(e => e.NewTypeId, "new_type_id_constraint");

//                entity.HasIndex(e => e.UserId, "user_id_constraint");

//                entity.Property(e => e.CertificateTypeLogId).HasColumnName("certificate_type_log_id");

//                entity.Property(e => e.ActionDate)
//                    .HasColumnType("datetime")
//                    .HasColumnName("action_date")
//                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

//                entity.Property(e => e.CertificateStatus)
//                    .HasMaxLength(50)
//                    .HasColumnName("certificate_status")
//                    .HasComment("It can be changed, renamed or unchanged.");

//                entity.Property(e => e.IsDeleted)
//                    .HasColumnName("is_deleted")
//                    .HasDefaultValueSql("'0'");

//                entity.Property(e => e.IssuerStatus)
//                    .HasMaxLength(50)
//                    .HasColumnName("issuer_status")
//                    .HasComment("It can be changed, renamed or unchanged.");

//                entity.Property(e => e.NewIssuerId).HasColumnName("new_issuer_id");

//                entity.Property(e => e.NewIssuerName)
//                    .HasMaxLength(200)
//                    .HasColumnName("new_issuer_name");

//                entity.Property(e => e.NewTypeId).HasColumnName("new_type_id");

//                entity.Property(e => e.NewTypeName)
//                    .HasMaxLength(100)
//                    .HasColumnName("new_type_name");

//                entity.Property(e => e.OldIssuerId).HasColumnName("old_issuer_id");

//                entity.Property(e => e.OldIssuerName)
//                    .HasMaxLength(200)
//                    .HasColumnName("old_issuer_name");

//                entity.Property(e => e.OldTypeId).HasColumnName("old_type_id");

//                entity.Property(e => e.OldTypeName)
//                    .HasMaxLength(100)
//                    .HasColumnName("old_type_name");

//                entity.Property(e => e.UserId).HasColumnName("user_id");

//                entity.HasOne(d => d.NewIssuer)
//                    .WithMany(p => p.CertificateTypeLogs)
//                    .HasForeignKey(d => d.NewIssuerId)
//                    .OnDelete(DeleteBehavior.ClientSetNull)
//                    .HasConstraintName("new_issuer_id_constraint");

//                entity.HasOne(d => d.NewType)
//                    .WithMany(p => p.CertificateTypeLogs)
//                    .HasForeignKey(d => d.NewTypeId)
//                    .OnDelete(DeleteBehavior.ClientSetNull)
//                    .HasConstraintName("new_type_id_constraint");

//                entity.HasOne(d => d.User)
//                    .WithMany(p => p.CertificateTypeLogs)
//                    .HasForeignKey(d => d.UserId)
//                    .OnDelete(DeleteBehavior.ClientSetNull)
//                    .HasConstraintName("user_id_constraint");
//            });

//            modelBuilder.Entity<Comment>(entity =>
//            {
//                entity.ToTable("comments");

//                entity.HasCharSet("utf8mb3")
//                    .UseCollation("utf8mb3_general_ci");

//                entity.Property(e => e.Id).HasColumnName("id");

//                entity.Property(e => e.Content)
//                    .HasMaxLength(500)
//                    .HasColumnName("content");

//                entity.Property(e => e.CreatedDate)
//                    .HasColumnType("timestamp")
//                    .HasColumnName("created_date")
//                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

//                entity.Property(e => e.TopicId).HasColumnName("topic_id");

//                entity.Property(e => e.TopicType)
//                    .HasMaxLength(50)
//                    .HasColumnName("topic_type");

//                entity.Property(e => e.UserId).HasColumnName("user_id");
//            });

//            modelBuilder.Entity<Company>(entity =>
//            {
//                entity.ToTable("company");

//                entity.HasCharSet("utf8mb3")
//                    .UseCollation("utf8mb3_general_ci");

//                entity.Property(e => e.Id).HasColumnName("id");

//                entity.Property(e => e.CreatedDate)
//                    .HasColumnType("timestamp")
//                    .HasColumnName("created_date")
//                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

//                entity.Property(e => e.Name)
//                    .HasMaxLength(45)
//                    .HasColumnName("name");

//                entity.Property(e => e.Status)
//                    .HasMaxLength(45)
//                    .HasColumnName("status")
//                    .HasDefaultValueSql("'active'");
//            });

//            modelBuilder.Entity<KeyResult>(entity =>
//            {
//                entity.ToTable("key_results");

//                entity.HasCharSet("utf8mb3")
//                    .UseCollation("utf8mb3_general_ci");

//                entity.HasIndex(e => e.ParentObjectiveId, "fk_p_okey_idx");

//                entity.Property(e => e.Id).HasColumnName("id");

//                entity.Property(e => e.CreatedDate)
//                    .HasColumnType("timestamp")
//                    .HasColumnName("created_date")
//                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

//                entity.Property(e => e.EndDate)
//                    .HasColumnType("datetime")
//                    .HasColumnName("end_date");

//                entity.Property(e => e.IsDeleted)
//                    .HasColumnName("is_deleted")
//                    .HasDefaultValueSql("'0'");

//                entity.Property(e => e.KeyResultType)
//                    .HasMaxLength(15)
//                    .HasColumnName("key_result_type")
//                    .HasDefaultValueSql("'metric'");

//                entity.Property(e => e.NoOfComments).HasColumnName("no_of_comments");

//                entity.Property(e => e.ParentObjectiveId).HasColumnName("parent_objective_id");

//                entity.Property(e => e.PercentageDone).HasColumnName("percentage_done");

//                entity.Property(e => e.QuarterPeriod)
//                    .HasMaxLength(5)
//                    .HasColumnName("quarter_period");

//                entity.Property(e => e.QuarterYear)
//                    .HasMaxLength(10)
//                    .HasColumnName("quarter_year");

//                entity.Property(e => e.Score)
//                    .HasPrecision(3, 2)
//                    .HasColumnName("score");

//                entity.Property(e => e.StartDate)
//                    .HasColumnType("datetime")
//                    .HasColumnName("start_date");

//                entity.Property(e => e.Status)
//                    .HasMaxLength(15)
//                    .HasColumnName("status")
//                    .HasDefaultValueSql("'todo'");

//                entity.Property(e => e.Title)
//                    .HasMaxLength(200)
//                    .HasColumnName("title");

//                entity.Property(e => e.UpdatedDate)
//                    .HasColumnType("datetime")
//                    .HasColumnName("updated_date");

//                entity.HasOne(d => d.ParentObjective)
//                    .WithMany(p => p.KeyResults)
//                    .HasForeignKey(d => d.ParentObjectiveId)
//                    .HasConstraintName("fk_key_results_parent_obj_id");
//            });

//            modelBuilder.Entity<Membership>(entity =>
//            {
//                entity.ToTable("membership");

//                entity.HasCharSet("utf8mb3")
//                    .UseCollation("utf8mb3_unicode_ci");

//                entity.HasIndex(e => new { e.UsersId, e.TeamsId }, "UQ_teamsId_usersId")
//                    .IsUnique();

//                entity.HasIndex(e => e.TeamsId, "fk_membership_teams_idx");

//                entity.HasIndex(e => e.UsersId, "fk_membership_users1_idx");

//                entity.HasIndex(e => e.Id, "id_UNIQUE")
//                    .IsUnique();

//                entity.Property(e => e.Id).HasColumnName("id");

//                entity.Property(e => e.Roles)
//                    .HasMaxLength(30)
//                    .HasColumnName("roles");

//                entity.Property(e => e.TeamsId).HasColumnName("teams_id");

//                entity.Property(e => e.UsersId).HasColumnName("users_id");

//                entity.HasOne(d => d.Teams)
//                    .WithMany(p => p.Memberships)
//                    .HasForeignKey(d => d.TeamsId)
//                    .OnDelete(DeleteBehavior.ClientSetNull)
//                    .HasConstraintName("fk_membership_teams");

//                entity.HasOne(d => d.Users)
//                    .WithMany(p => p.Memberships)
//                    .HasForeignKey(d => d.UsersId)
//                    .OnDelete(DeleteBehavior.ClientSetNull)
//                    .HasConstraintName("fk_membership_users1");
//            });

//            modelBuilder.Entity<Objective>(entity =>
//            {
//                entity.ToTable("objectives");

//                entity.HasCharSet("utf8mb3")
//                    .UseCollation("utf8mb3_general_ci");

//                entity.Property(e => e.Id).HasColumnName("id");

//                entity.Property(e => e.AssessmentPeriodId)
//                    .HasColumnName("assessment_period_id")
//                    .HasDefaultValueSql("'1'");

//                entity.Property(e => e.CreatedDate)
//                    .HasColumnType("timestamp")
//                    .HasColumnName("created_date")
//                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

//                entity.Property(e => e.EndDate)
//                    .HasColumnType("datetime")
//                    .HasColumnName("end_date");

//                entity.Property(e => e.IsDeleted)
//                    .HasColumnName("is_deleted")
//                    .HasDefaultValueSql("'0'");

//                entity.Property(e => e.NoOfComments).HasColumnName("no_of_comments");

//                entity.Property(e => e.ParentId)
//                    .HasColumnName("parent_id")
//                    .HasComment("It can be user id, team id or company id.");

//                entity.Property(e => e.ParentType)
//                    .HasMaxLength(10)
//                    .HasColumnName("parent_type")
//                    .HasComment("It can be user, team or company.");

//                entity.Property(e => e.PercentageDone).HasColumnName("percentage_done");

//                entity.Property(e => e.QuarterPeriod)
//                    .HasMaxLength(5)
//                    .HasColumnName("quarter_period");

//                entity.Property(e => e.QuarterYear)
//                    .HasMaxLength(10)
//                    .HasColumnName("quarter_year");

//                entity.Property(e => e.Score)
//                    .HasPrecision(3, 2)
//                    .HasColumnName("score");

//                entity.Property(e => e.StartDate)
//                    .HasColumnType("datetime")
//                    .HasColumnName("start_date");

//                entity.Property(e => e.Status)
//                    .HasMaxLength(15)
//                    .HasColumnName("status")
//                    .HasDefaultValueSql("'todo'");

//                entity.Property(e => e.Title)
//                    .HasMaxLength(200)
//                    .HasColumnName("title");

//                entity.Property(e => e.UpdatedDate)
//                    .HasColumnType("datetime")
//                    .HasColumnName("updated_date");
//            });

//            modelBuilder.Entity<QuarterlyDetail>(entity =>
//            {
//                entity.HasKey(e => new { e.QuarterPeriod, e.QuarterYear })
//                    .HasName("PRIMARY")
//                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

//                entity.ToTable("quarterly_details");

//                entity.HasCharSet("utf8mb3")
//                    .UseCollation("utf8mb3_general_ci");

//                entity.Property(e => e.QuarterPeriod)
//                    .HasMaxLength(10)
//                    .HasColumnName("quarter_period")
//                    .HasDefaultValueSql("''");

//                entity.Property(e => e.QuarterYear)
//                    .HasMaxLength(10)
//                    .HasColumnName("quarter_year")
//                    .HasDefaultValueSql("''");

//                entity.Property(e => e.KeyResultCount)
//                    .HasColumnName("key_result_count")
//                    .HasDefaultValueSql("'0'");

//                entity.Property(e => e.ObjectiveCount)
//                    .HasColumnName("objective_count")
//                    .HasDefaultValueSql("'0'");

//                entity.Property(e => e.OkrScore)
//                    .HasColumnName("okr_score")
//                    .HasDefaultValueSql("'0'");
//            });

//            modelBuilder.Entity<SchemaVersion>(entity =>
//            {
//                entity.HasKey(e => e.Version)
//                    .HasName("PRIMARY");

//                entity.ToTable("schema_version");

//                entity.HasCharSet("latin1")
//                    .UseCollation("latin1_swedish_ci");

//                entity.HasIndex(e => e.InstalledRank, "schema_version_ir_idx");

//                entity.HasIndex(e => e.Success, "schema_version_s_idx");

//                entity.HasIndex(e => e.VersionRank, "schema_version_vr_idx");

//                entity.Property(e => e.Version)
//                    .HasMaxLength(50)
//                    .HasColumnName("version");

//                entity.Property(e => e.Checksum).HasColumnName("checksum");

//                entity.Property(e => e.Description)
//                    .HasMaxLength(200)
//                    .HasColumnName("description");

//                entity.Property(e => e.ExecutionTime).HasColumnName("execution_time");

//                entity.Property(e => e.InstalledBy)
//                    .HasMaxLength(100)
//                    .HasColumnName("installed_by");

//                entity.Property(e => e.InstalledOn)
//                    .HasColumnType("timestamp")
//                    .HasColumnName("installed_on")
//                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

//                entity.Property(e => e.InstalledRank).HasColumnName("installed_rank");

//                entity.Property(e => e.Script)
//                    .HasMaxLength(1000)
//                    .HasColumnName("script");

//                entity.Property(e => e.Success).HasColumnName("success");

//                entity.Property(e => e.Type)
//                    .HasMaxLength(20)
//                    .HasColumnName("type");

//                entity.Property(e => e.VersionRank).HasColumnName("version_rank");
//            });

//            modelBuilder.Entity<SkillSet>(entity =>
//            {
//                entity.HasKey(e => e.SkillId)
//                    .HasName("PRIMARY");

//                entity.ToTable("skill_set");

//                entity.HasCharSet("utf8mb3")
//                    .UseCollation("utf8mb3_unicode_ci");

//                entity.HasIndex(e => e.SkillDescription, "skill_description_unique")
//                    .IsUnique();

//                entity.Property(e => e.SkillId).HasColumnName("skill_id");

//                entity.Property(e => e.CreatedDate)
//                    .HasColumnType("datetime")
//                    .HasColumnName("created_date")
//                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

//                entity.Property(e => e.IsDeleted).HasColumnName("is_deleted");

//                entity.Property(e => e.SkillDescription)
//                    .HasMaxLength(200)
//                    .HasColumnName("skill_description");

//                entity.Property(e => e.UpdatedDate)
//                    .HasColumnType("datetime")
//                    .ValueGeneratedOnAddOrUpdate()
//                    .HasColumnName("updated_date")
//                    .HasDefaultValueSql("CURRENT_TIMESTAMP");
//            });

//            modelBuilder.Entity<Team>(entity =>
//            {
//                entity.ToTable("teams");

//                entity.HasCharSet("utf8mb3")
//                    .UseCollation("utf8mb3_general_ci");

//                entity.Property(e => e.Id).HasColumnName("id");

//                entity.Property(e => e.CompanyId).HasColumnName("company_id");

//                entity.Property(e => e.CreatedDate)
//                    .HasColumnType("timestamp")
//                    .HasColumnName("created_date")
//                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

//                entity.Property(e => e.IsDeleted)
//                    .HasColumnName("isDeleted")
//                    .HasDefaultValueSql("'0'")
//                    .HasComment("for soft delete of teams");

//                entity.Property(e => e.ManagerId)
//                    .HasColumnName("manager_id")
//                    .HasComment("It will be the user id of the manager");

//                entity.Property(e => e.Name)
//                    .HasMaxLength(45)
//                    .HasColumnName("name");

//                entity.Property(e => e.Status)
//                    .HasMaxLength(45)
//                    .HasColumnName("status")
//                    .HasDefaultValueSql("'active'");

//                entity.Property(e => e.TeamCount)
//                    .HasColumnName("teamCount")
//                    .HasComment("number of members in the team");
//            });

//            modelBuilder.Entity<User>(entity =>
//            {
//                entity.ToTable("users");

//                entity.HasCharSet("utf8mb3")
//                    .UseCollation("utf8mb3_general_ci");

//                entity.HasIndex(e => e.OldEmail, "email_UNIQUE")
//                    .IsUnique();

//                entity.Property(e => e.Id).HasColumnName("id");

//                entity.Property(e => e.AuthUserId)
//                    .HasMaxLength(100)
//                    .HasColumnName("auth_user_id");

//                entity.Property(e => e.CertificateRole)
//                    .HasColumnName("certificate_role")
//                    .HasDefaultValueSql("'0'");

//                entity.Property(e => e.CognitoUserId)
//                    .HasMaxLength(100)
//                    .HasColumnName("cognito_user_id");

//                entity.Property(e => e.CompanyId)
//                    .HasColumnName("company_id")
//                    .HasDefaultValueSql("'1'");

//                entity.Property(e => e.CreatedDate)
//                    .HasColumnType("timestamp")
//                    .HasColumnName("created_date")
//                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

//                entity.Property(e => e.Department)
//                    .HasMaxLength(100)
//                    .HasColumnName("department");

//                entity.Property(e => e.Designation)
//                    .HasMaxLength(255)
//                    .HasColumnName("designation")
//                    .HasDefaultValueSql("'Employee'");

//                entity.Property(e => e.Email)
//                    .HasMaxLength(45)
//                    .HasColumnName("email");

//                entity.Property(e => e.IsDeleted)
//                    .HasColumnName("is_deleted")
//                    .HasDefaultValueSql("'0'");

//                entity.Property(e => e.Location)
//                    .HasMaxLength(100)
//                    .HasColumnName("location");

//                entity.Property(e => e.Name)
//                    .HasMaxLength(45)
//                    .HasColumnName("name");

//                entity.Property(e => e.OkrRole)
//                    .HasColumnName("okr_role")
//                    .HasDefaultValueSql("'0'");

//                entity.Property(e => e.OldAuthUserId)
//                    .HasMaxLength(100)
//                    .HasColumnName("old_auth_user_id");

//                entity.Property(e => e.OldEmail)
//                    .HasMaxLength(45)
//                    .HasColumnName("old_email");

//                entity.Property(e => e.Role)
//                    .HasMaxLength(45)
//                    .HasColumnName("role")
//                    .HasDefaultValueSql("'user'");

//                entity.Property(e => e.Status)
//                    .HasMaxLength(45)
//                    .HasColumnName("status")
//                    .HasDefaultValueSql("'active'");
//            });

//            modelBuilder.Entity<UserMentorMapping>(entity =>
//            {
//                entity.HasKey(e => new { e.MentorId, e.MenteeId })
//                    .HasName("PRIMARY")
//                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

//                entity.ToTable("user_mentor_mapping");

//                entity.HasCharSet("utf8mb3")
//                    .UseCollation("utf8mb3_unicode_ci");

//                entity.HasIndex(e => e.MenteeId, "mentee_reference_id");

//                entity.HasIndex(e => e.MentorId, "mentor_reference_id");

//                entity.Property(e => e.MentorId).HasColumnName("mentor_id");

//                entity.Property(e => e.MenteeId).HasColumnName("mentee_id");

//                entity.Property(e => e.CreatedDate)
//                    .HasColumnType("datetime")
//                    .HasColumnName("created_date")
//                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

//                entity.Property(e => e.IsDeleted).HasColumnName("is_deleted");

//                entity.Property(e => e.UpdatedDate)
//                    .HasColumnType("datetime")
//                    .ValueGeneratedOnAddOrUpdate()
//                    .HasColumnName("updated_date")
//                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

//                entity.HasOne(d => d.Mentee)
//                    .WithMany(p => p.UserMentorMappingMentees)
//                    .HasForeignKey(d => d.MenteeId)
//                    .OnDelete(DeleteBehavior.ClientSetNull)
//                    .HasConstraintName("mentee_reference_id");

//                entity.HasOne(d => d.Mentor)
//                    .WithMany(p => p.UserMentorMappingMentors)
//                    .HasForeignKey(d => d.MentorId)
//                    .OnDelete(DeleteBehavior.ClientSetNull)
//                    .HasConstraintName("mentor_reference_id");
//            });

//            modelBuilder.Entity<UserSkillMapping>(entity =>
//            {
//                entity.HasKey(e => new { e.SkillId, e.UserId })
//                    .HasName("PRIMARY")
//                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

//                entity.ToTable("user_skill_mapping");

//                entity.HasCharSet("utf8mb3")
//                    .UseCollation("utf8mb3_unicode_ci");

//                entity.HasIndex(e => e.SkillId, "skill_reference_id_idx");

//                entity.HasIndex(e => e.UserId, "user_reference_id_idx");

//                entity.Property(e => e.SkillId).HasColumnName("skill_id");

//                entity.Property(e => e.UserId).HasColumnName("user_id");

//                entity.Property(e => e.CreatedDate)
//                    .HasColumnType("datetime")
//                    .HasColumnName("created_date")
//                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

//                entity.Property(e => e.IsDeleted).HasColumnName("is_deleted");

//                entity.Property(e => e.Rating).HasColumnName("rating");

//                entity.Property(e => e.UpdatedDate)
//                    .HasColumnType("datetime")
//                    .ValueGeneratedOnAddOrUpdate()
//                    .HasColumnName("updated_date")
//                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

//                entity.HasOne(d => d.Skill)
//                    .WithMany(p => p.UserSkillMappings)
//                    .HasForeignKey(d => d.SkillId)
//                    .OnDelete(DeleteBehavior.ClientSetNull)
//                    .HasConstraintName("skill_reference_id");

//                entity.HasOne(d => d.User)
//                    .WithMany(p => p.UserSkillMappings)
//                    .HasForeignKey(d => d.UserId)
//                    .OnDelete(DeleteBehavior.ClientSetNull)
//                    .HasConstraintName("user_reference_id");
//            });

//            OnModelCreatingPartial(modelBuilder);
//        }

//        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
//    }
//}
