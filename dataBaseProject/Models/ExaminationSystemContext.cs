using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace dataBaseProject.Models
{
    public partial class ExaminationSystemContext : DbContext
    {
        public ExaminationSystemContext()
        {
        }

        public ExaminationSystemContext(DbContextOptions<ExaminationSystemContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Course> Courses { get; set; } = null!;
        public virtual DbSet<Department> Departments { get; set; } = null!;
        public virtual DbSet<Exam> Exams { get; set; } = null!;
        public virtual DbSet<QuesChoice> QuesChoices { get; set; } = null!;
        public virtual DbSet<Question> Questions { get; set; } = null!;
        public virtual DbSet<StdExam> StdExams { get; set; } = null!;
        public virtual DbSet<User> Users { get; set; } = null!;
        public object InsertUsingStoredProcedure { get; private set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=DESKTOP-K4R66GP;Database=ExaminationSystem;Trusted_Connection=True;TrustServerCertificate=true;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Course>(entity =>
            {
                entity.InsertUsingStoredProcedure("InsertCourse", c =>
                {
                    c.HasParameter(c => c.CrsId);
                    c.HasParameter(c => c.CrsName);
                    c.HasParameter(c => c.CrsDuration);

                });
                entity.UpdateUsingStoredProcedure("UpdateCourse", c =>
                {
                    c.HasOriginalValueParameter(c => c.CrsId);
                    c.HasParameter(c => c.CrsName);
                    c.HasParameter(c => c.CrsDuration);
                });
                entity.DeleteUsingStoredProcedure("DeleteCourse", c =>
                {
                    c.HasOriginalValueParameter(c => c.CrsId);
                });
                entity.HasKey(e => e.CrsId)
                    .HasName("PK__Course__56CAA5D54C3D6D6A");

                entity.ToTable("Course");

                entity.HasIndex(e => e.CrsName, "UQ__Course__E2D24123CCDBAA15")
                    .IsUnique();

                entity.Property(e => e.CrsId)
                    .ValueGeneratedNever()
                    .HasColumnName("Crs_Id");

                entity.Property(e => e.CrsDuration).HasColumnName("Crs_Duration");

                entity.Property(e => e.CrsName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Crs_Name");
            });

            modelBuilder.Entity<Department>(entity =>
            {
                entity.InsertUsingStoredProcedure("InsertDepartment", s =>
                {
                    s.HasParameter(a => a.DeptId);
                    s.HasParameter(a => a.DeptName);
                    
                });
                entity.UpdateUsingStoredProcedure("UpdateDepartment", s =>
                {
                    s.HasOriginalValueParameter(a => a.DeptId);
                    s.HasParameter(a => a.DeptName);
                });
                entity.DeleteUsingStoredProcedure("DeleteDepartment", s =>
                {
                    s.HasOriginalValueParameter(a => a.DeptId);
                });
                entity.HasKey(e => e.DeptId)
                    .HasName("PK__Departme__72ABC2CC85E43534");

                entity.ToTable("Department");

                entity.HasIndex(e => e.DeptName, "UQ__Departme__B744FF0F88118580")
                    .IsUnique();

                entity.Property(e => e.DeptId)
                    .ValueGeneratedNever()
                    .HasColumnName("Dept_Id");

                entity.Property(e => e.DeptName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Dept_Name");

                entity.HasMany(d => d.Crs)
                    .WithMany(p => p.Depts)
                    .UsingEntity<Dictionary<string, object>>(
                        "DeptCourse",
                        l => l.HasOne<Course>().WithMany().HasForeignKey("CrsId").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("Dept_Course_FK2"),
                        r => r.HasOne<Department>().WithMany().HasForeignKey("DeptId").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("Dept_Course_FK1"),
                        j =>
                        {
                            j.HasKey("DeptId", "CrsId").HasName("Dept_Course_Pk");

                            j.ToTable("Dept_Course");

                            j.IndexerProperty<int>("DeptId").HasColumnName("Dept_Id");

                            j.IndexerProperty<int>("CrsId").HasColumnName("crs_Id");
                        });
            });

            modelBuilder.Entity<Exam>(entity =>
            {
                entity.ToTable("Exam");

                entity.Property(e => e.ExamId)
                    .ValueGeneratedNever()
                    .HasColumnName("Exam_Id");

                entity.Property(e => e.CrsId).HasColumnName("crs_id");

                entity.HasOne(d => d.Crs)
                    .WithMany(p => p.Exams)
                    .HasForeignKey(d => d.CrsId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Exam_FK");
            });

            modelBuilder.Entity<QuesChoice>(entity =>
            {
                entity.InsertUsingStoredProcedure("InsertChoice", s =>
                {
                    s.HasParameter(a => a.QuesId);
                    s.HasParameter(a => a.QuesChoice1);

                });
                entity.HasKey(e => new { e.QuesId, e.QuesChoice1 })
                    .HasName("Ques_Choices_Pk");

                entity.ToTable("Ques_Choices");

                entity.Property(e => e.QuesId).HasColumnName("Ques_Id");

                entity.Property(e => e.QuesChoice1)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Ques_Choice");

                entity.HasOne(d => d.Ques)
                    .WithMany(p => p.QuesChoices)
                    .HasForeignKey(d => d.QuesId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Ques_Choices_FK");
            });

            modelBuilder.Entity<Question>(entity =>
            {
                entity.HasKey(e => e.QuesId)
                    .HasName("PK__Question__A821235E39D82835");

                entity.ToTable("Question");

                entity.HasIndex(e => e.Body, "UQ__Question__5F25785F48259B28")
                    .IsUnique();

                entity.Property(e => e.QuesId)
                    .ValueGeneratedNever()
                    .HasColumnName("Ques_Id");

                entity.Property(e => e.Body)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CrsId).HasColumnName("Crs_Id");

                entity.Property(e => e.ModelAnswer)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Model_answer");

                entity.Property(e => e.Type)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.Crs)
                    .WithMany(p => p.Questions)
                    .HasForeignKey(d => d.CrsId)
                    .HasConstraintName("SQuestionFK");

                entity.HasMany(d => d.Exams)
                    .WithMany(p => p.Ques)
                    .UsingEntity<Dictionary<string, object>>(
                        "QuesExam",
                        l => l.HasOne<Exam>().WithMany().HasForeignKey("ExamId").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("Ques_Exam_FK2"),
                        r => r.HasOne<Question>().WithMany().HasForeignKey("QuesId").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("Ques_Exam_FK1"),
                        j =>
                        {
                            j.HasKey("QuesId", "ExamId").HasName("Ques_Exam_Pk");

                            j.ToTable("Ques_Exam");

                            j.IndexerProperty<int>("QuesId").HasColumnName("Ques_Id");

                            j.IndexerProperty<int>("ExamId").HasColumnName("Exam_Id");
                        });
            });

            modelBuilder.Entity<StdExam>(entity =>
            {
                entity.HasKey(e => new { e.StdId, e.ExamId })
                    .HasName("Std_Exam_Pk");

                entity.ToTable("Std_Exam");

                entity.Property(e => e.StdId)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("Std_Id");

                entity.Property(e => e.ExamId).HasColumnName("Exam_Id");

                entity.HasOne(d => d.Exam)
                    .WithMany(p => p.StdExams)
                    .HasForeignKey(d => d.ExamId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Std_Exam_FK2");

                entity.HasOne(d => d.Std)
                    .WithMany(p => p.StdExams)
                    .HasForeignKey(d => d.StdId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Std_Exam_FK1");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.HasKey(e => e.Ssn)
                    .HasName("student_PK");

                entity.Property(e => e.Ssn)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("SSN");

                entity.Property(e => e.Age).HasColumnName("age");

                entity.Property(e => e.DeptId).HasColumnName("Dept_Id");

                entity.Property(e => e.Fname)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Lname)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Role)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.Dept)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.DeptId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Std_dept_Fk");

                entity.HasMany(d => d.Crs)
                    .WithMany(p => p.Insts)
                    .UsingEntity<Dictionary<string, object>>(
                        "InstCrourse",
                        l => l.HasOne<Course>().WithMany().HasForeignKey("CrsId").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("Inst_Crourse_FK2"),
                        r => r.HasOne<User>().WithMany().HasForeignKey("InstId").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("Inst_Crourse_FK1"),
                        j =>
                        {
                            j.HasKey("InstId", "CrsId").HasName("Inst_Crourse_Pk");

                            j.ToTable("Inst_Crourse");

                            j.IndexerProperty<string>("InstId").HasMaxLength(14).IsUnicode(false).HasColumnName("Inst_Id");

                            j.IndexerProperty<int>("CrsId").HasColumnName("Crs_Id");
                        });

                entity.HasMany(d => d.CrsNavigation)
                    .WithMany(p => p.Stds)
                    .UsingEntity<Dictionary<string, object>>(
                        "StudentCourse",
                        l => l.HasOne<Course>().WithMany().HasForeignKey("CrsId").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("Student_Course_FK2"),
                        r => r.HasOne<User>().WithMany().HasForeignKey("StdId").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("Student_Course_FK1"),
                        j =>
                        {
                            j.HasKey("StdId", "CrsId").HasName("Student_Course_Pk");

                            j.ToTable("Student_Course");

                            j.IndexerProperty<string>("StdId").HasMaxLength(14).IsUnicode(false).HasColumnName("Std_Id");

                            j.IndexerProperty<int>("CrsId").HasColumnName("Crs_Id");
                        });
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
