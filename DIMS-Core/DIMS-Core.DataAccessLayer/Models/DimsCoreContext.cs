using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace DIMS_Core.DataAccessLayer.Models
{
    public partial class DimsCoreContext : DbContext
    {
        public DimsCoreContext()
        {
        }

        public DimsCoreContext(DbContextOptions<DimsCoreContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Direction> Directions { get; set; }
        public virtual DbSet<Task> Tasks { get; set; }
        public virtual DbSet<TaskState> TaskStates { get; set; }
        public virtual DbSet<TaskTrack> TaskTracks { get; set; }
        public virtual DbSet<UserProfile> UserProfiles { get; set; }
        public virtual DbSet<UserTask> UserTasks { get; set; }
        public virtual DbSet<vTask> vTasks { get; set; }
        public virtual DbSet<VUserProfile> vUserProfiles { get; set; }
        public virtual DbSet<VUserProgress> vUserProgresses { get; set; }
        public virtual DbSet<VUserTask> vUserTasks { get; set; }
        public virtual DbSet<VUserTrack> vUserTracks { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=localhost,1433; Database=Dims; User=sa; Password =Orsi4ek148");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Direction>(entity =>
            {
                entity.ToTable("Direction");

                entity.Property(e => e.Description).HasMaxLength(250);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Task>(entity =>
            {
                entity.ToTable("Task");

                entity.Property(e => e.DeadlineDate).HasColumnType("date");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.StartDate).HasColumnType("date");
            });

            modelBuilder.Entity<TaskState>(entity =>
            {
                entity.HasKey(e => e.StateId)
                    .HasName("PK_TaskState_StateId");

                entity.ToTable("TaskState");

                entity.Property(e => e.StateName)
                    .IsRequired()
                    .HasMaxLength(25);
            });

            modelBuilder.Entity<TaskTrack>(entity =>
            {
                entity.ToTable("TaskTrack");

                entity.Property(e => e.TrackDate).HasColumnType("date");

                entity.Property(e => e.TrackNote)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.HasOne(d => d.UserTask)
                    .WithMany(p => p.TaskTracks)
                    .HasForeignKey(d => d.UserTaskId);
            });

            modelBuilder.Entity<UserProfile>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("PK_UserProfile_UserId");

                entity.ToTable("UserProfile");

                entity.Property(e => e.Address).HasMaxLength(120);

                entity.Property(e => e.BirthDate).HasColumnType("date");

                entity.Property(e => e.Education).HasMaxLength(50);

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.MobilePhone)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Skype).HasMaxLength(50);

                entity.Property(e => e.StartDate).HasColumnType("date");

                entity.HasOne(d => d.Direction)
                    .WithMany(p => p.UserProfiles)
                    .HasForeignKey(d => d.DirectionId)
                    .HasConstraintName("FK_UserProfile_Directions_DirectionId");
            });

            modelBuilder.Entity<UserTask>(entity =>
            {
                entity.ToTable("UserTask");

                entity.HasOne(d => d.State)
                    .WithMany(p => p.UserTasks)
                    .HasForeignKey(d => d.StateId);

                entity.HasOne(d => d.Task)
                    .WithMany(p => p.UserTasks)
                    .HasForeignKey(d => d.TaskId);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserTasks)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<vTask>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vTask");

                entity.Property(e => e.DeadlineDate).HasColumnType("date");

                entity.Property(e => e.Description)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.StartDate).HasColumnType("date");
            });

            modelBuilder.Entity<VUserProfile>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vUserProfile");

                entity.Property(e => e.Address).HasMaxLength(120);

                entity.Property(e => e.Direction)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Education).HasMaxLength(50);

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.FullName)
                    .IsRequired()
                    .HasMaxLength(101);

                entity.Property(e => e.MobilePhone)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Skype).HasMaxLength(50);

                entity.Property(e => e.StartDate).HasColumnType("date");
            });
            

            modelBuilder.Entity<VUserProgress>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vUserProgress");

                entity.Property(e => e.TaskName)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TrackDate).HasColumnType("date");

                entity.Property(e => e.TrackNote)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.UserName)
                    .HasMaxLength(3)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VUserTask>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vUserTask");

                entity.Property(e => e.DeadlineDate).HasColumnType("date");

                entity.Property(e => e.Description)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.StartDate).HasColumnType("date");

                entity.Property(e => e.State)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TaskName)
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VUserTrack>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vUserTrack");

                entity.Property(e => e.TaskName)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TrackDate).HasColumnType("date");

                entity.Property(e => e.TrackNote)
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
