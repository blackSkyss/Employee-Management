using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace BusinessObject
{
    public partial class PRN211Context : DbContext
    {
        public PRN211Context()
        {
        }

        public PRN211Context(DbContextOptions<PRN211Context> options)
            : base(options)
        {
        }

        public virtual DbSet<Certificate> Certificates { get; set; }
        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Position> Positions { get; set; }
        public virtual DbSet<Regulation> Regulations { get; set; }
        public virtual DbSet<RewardAndPenalty> RewardAndPenalties { get; set; }
        public virtual DbSet<TypeCertificate> TypeCertificates { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=\n(local);Uid=sa;Pwd=12345;Database=PRN211");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Certificate>(entity =>
            {
                entity.HasKey(e => e.CerId)
                    .HasName("PK__Certific__22EED403E8B0E8ED");

                entity.ToTable("Certificate");

                entity.Property(e => e.CerId)
                    .ValueGeneratedNever()
                    .HasColumnName("cerID");

                entity.Property(e => e.CerName)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("cerName");

                entity.Property(e => e.Doi)
                    .HasColumnType("datetime")
                    .HasColumnName("doi");

                entity.Property(e => e.IdEmp).HasColumnName("idEmp");

                entity.Property(e => e.IdTypeCer).HasColumnName("idTypeCer");

                entity.HasOne(d => d.IdEmpNavigation)
                    .WithMany(p => p.Certificates)
                    .HasForeignKey(d => d.IdEmp)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__Certifica__idEmp__300424B4");

                entity.HasOne(d => d.IdTypeCerNavigation)
                    .WithMany(p => p.Certificates)
                    .HasForeignKey(d => d.IdTypeCer)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__Certifica__idTyp__30F848ED");
            });

            modelBuilder.Entity<Department>(entity =>
            {
                entity.HasKey(e => e.DepNum)
                    .HasName("PK__Departme__D7AE2EAE7A7E3D67");

                entity.ToTable("Department");

                entity.Property(e => e.DepNum)
                    .ValueGeneratedNever()
                    .HasColumnName("depNum");

                entity.Property(e => e.DepName)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("depName");

                entity.Property(e => e.Description)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("description");

                entity.Property(e => e.Location)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("location");
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.HasKey(e => e.IdEmp)
                    .HasName("PK__Employee__3F174B8B268ECE9A");

                entity.ToTable("Employee");

                entity.Property(e => e.IdEmp)
                    .ValueGeneratedNever()
                    .HasColumnName("idEmp");

                entity.Property(e => e.Address)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("address");

                entity.Property(e => e.BaseSalary).HasColumnName("baseSalary");

                entity.Property(e => e.DepNum).HasColumnName("depNum");

                entity.Property(e => e.Dob)
                    .HasColumnType("datetime")
                    .HasColumnName("dob");

                entity.Property(e => e.Email)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.Gender)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("gender");

                entity.Property(e => e.IdPos).HasColumnName("idPos");

                entity.Property(e => e.JoinDate)
                    .HasColumnType("datetime")
                    .HasColumnName("joinDate");

                entity.Property(e => e.Name)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.Password)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("password");

                entity.Property(e => e.PhoneNum)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("phoneNum");

                entity.Property(e => e.Role).HasColumnName("role");

                entity.HasOne(d => d.DepNumNavigation)
                    .WithMany(p => p.Employees)
                    .HasForeignKey(d => d.DepNum)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__Employee__depNum__2A4B4B5E");

                entity.HasOne(d => d.IdPosNavigation)
                    .WithMany(p => p.Employees)
                    .HasForeignKey(d => d.IdPos)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__Employee__idPos__2B3F6F97");
            });

            modelBuilder.Entity<Position>(entity =>
            {
                entity.HasKey(e => e.IdPos)
                    .HasName("PK__Position__3D78A0B7CA5EFD7C");

                entity.ToTable("Position");

                entity.Property(e => e.IdPos)
                    .ValueGeneratedNever()
                    .HasColumnName("idPos");

                entity.Property(e => e.Description)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("description");

                entity.Property(e => e.PosName)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("posName");
            });

            modelBuilder.Entity<Regulation>(entity =>
            {
                entity.HasKey(e => e.IdReg)
                    .HasName("PK__Regulati__3C879029201E7478");

                entity.ToTable("Regulation");

                entity.Property(e => e.IdReg)
                    .ValueGeneratedNever()
                    .HasColumnName("idReg");

                entity.Property(e => e.Name)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.Status).HasColumnName("status");
            });

            modelBuilder.Entity<RewardAndPenalty>(entity =>
            {
                entity.HasKey(e => e.IdRp)
                    .HasName("PK__RewardAn__9DB858A94A1CA957");

                entity.ToTable("RewardAndPenalty");

                entity.Property(e => e.IdRp)
                    .ValueGeneratedNever()
                    .HasColumnName("idRP");

                entity.Property(e => e.ApplicableDate)
                    .HasColumnType("datetime")
                    .HasColumnName("applicableDate");

                entity.Property(e => e.IdEmp).HasColumnName("idEmp");

                entity.Property(e => e.IdReg).HasColumnName("idReg");

                entity.Property(e => e.Reason)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("reason");

                entity.Property(e => e.Times).HasColumnName("times");

                entity.HasOne(d => d.IdEmpNavigation)
                    .WithMany(p => p.RewardAndPenalties)
                    .HasForeignKey(d => d.IdEmp)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__RewardAnd__idEmp__38996AB5");

                entity.HasOne(d => d.IdRegNavigation)
                    .WithMany(p => p.RewardAndPenalties)
                    .HasForeignKey(d => d.IdReg)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__RewardAnd__idReg__37A5467C");
            });

            modelBuilder.Entity<TypeCertificate>(entity =>
            {
                entity.HasKey(e => e.IdTypeCer)
                    .HasName("PK__TypeCert__8B731267765C7E78");

                entity.ToTable("TypeCertificate");

                entity.Property(e => e.IdTypeCer)
                    .ValueGeneratedNever()
                    .HasColumnName("idTypeCer");

                entity.Property(e => e.Name)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("name");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
