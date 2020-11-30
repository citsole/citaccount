using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace citaccount.Data
{
    public partial class citaccountContext : DbContext
    {
        public citaccountContext()
        {
        }

        public citaccountContext(DbContextOptions<citaccountContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TblAcc> TblAccs { get; set; }
        public virtual DbSet<TblBranch> TblBranches { get; set; }
        public virtual DbSet<TblCurrency> TblCurrencies { get; set; }
        public virtual DbSet<TblDepartment> TblDepartments { get; set; }
        public virtual DbSet<TblDistrict> TblDistricts { get; set; }
        public virtual DbSet<TblEmp> TblEmps { get; set; }
        public virtual DbSet<TblMarry> TblMarries { get; set; }
        public virtual DbSet<TblPosition> TblPositions { get; set; }
        public virtual DbSet<TblProvince> TblProvinces { get; set; }
        public virtual DbSet<TblRole> TblRoles { get; set; }
        public virtual DbSet<TblStatus> TblStatuses { get; set; }
        public virtual DbSet<TblTransection> TblTransections { get; set; }
        public virtual DbSet<TblUser> TblUsers { get; set; }
        public virtual DbSet<TblVillage> TblVillages { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseNpgsql("Host=localhost;Database=citaccount;Username=postgres;Password=Cit@123");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TblAcc>(entity =>
            {
                entity.ToTable("tbl_acc");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AccNo).HasColumnName("acc_no");

                entity.Property(e => e.BalCredit).HasColumnName("bal_credit");

                entity.Property(e => e.BalDebit).HasColumnName("bal_debit");

                entity.Property(e => e.Del)
                    .HasColumnName("del")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.Name)
                    .HasMaxLength(300)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<TblBranch>(entity =>
            {
                entity.ToTable("tbl_branch");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Address).HasColumnName("address");

                entity.Property(e => e.Code).HasColumnName("code");

                entity.Property(e => e.Del)
                    .HasColumnName("del")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.Name)
                    .HasMaxLength(150)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<TblCurrency>(entity =>
            {
                entity.ToTable("tbl_currency");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Del)
                    .HasColumnName("del")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.Name)
                    .HasMaxLength(150)
                    .HasColumnName("name");

                entity.Property(e => e.Symboll)
                    .HasMaxLength(3)
                    .HasColumnName("symboll")
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<TblDepartment>(entity =>
            {
                entity.ToTable("tbl_department");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Del)
                    .HasColumnName("del")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<TblDistrict>(entity =>
            {
                entity.ToTable("tbl_district");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Del)
                    .HasColumnName("del")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .HasColumnName("name");

                entity.Property(e => e.ProId).HasColumnName("pro_id");

                entity.HasOne(d => d.Pro)
                    .WithMany(p => p.TblDistricts)
                    .HasForeignKey(d => d.ProId)
                    .HasConstraintName("tbl_district_pro_id_fkey");
            });

            modelBuilder.Entity<TblEmp>(entity =>
            {
                entity.ToTable("tbl_emp");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.BDisId).HasColumnName("b_dis_id");

                entity.Property(e => e.BProId).HasColumnName("b_pro_id");

                entity.Property(e => e.BVillId).HasColumnName("b_vill_id");

                entity.Property(e => e.Bod)
                    .HasColumnType("date")
                    .HasColumnName("bod");

                entity.Property(e => e.Del)
                    .HasColumnName("del")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.DisId).HasColumnName("dis_id");

                entity.Property(e => e.FamilyNo).HasColumnName("family_no");

                entity.Property(e => e.File).HasColumnName("file");

                entity.Property(e => e.Firstname)
                    .HasMaxLength(100)
                    .HasColumnName("firstname");

                entity.Property(e => e.Lastname)
                    .HasMaxLength(100)
                    .HasColumnName("lastname");

                entity.Property(e => e.MarId).HasColumnName("mar_id");

                entity.Property(e => e.Note).HasColumnName("note");

                entity.Property(e => e.Phone).HasColumnName("phone");

                entity.Property(e => e.Picture).HasColumnName("picture");

                entity.Property(e => e.PosId).HasColumnName("pos_id");

                entity.Property(e => e.ProId).HasColumnName("pro_id");

                entity.Property(e => e.VillId).HasColumnName("vill_id");

                entity.HasOne(d => d.BDis)
                    .WithMany(p => p.TblEmpBDis)
                    .HasForeignKey(d => d.BDisId)
                    .HasConstraintName("tbl_emp_b_dis_id_fkey");

                entity.HasOne(d => d.BPro)
                    .WithMany(p => p.TblEmpBPros)
                    .HasForeignKey(d => d.BProId)
                    .HasConstraintName("tbl_emp_b_pro_id_fkey");

                entity.HasOne(d => d.BVill)
                    .WithMany(p => p.TblEmpBVills)
                    .HasForeignKey(d => d.BVillId)
                    .HasConstraintName("tbl_emp_b_vill_id_fkey");

                entity.HasOne(d => d.Dis)
                    .WithMany(p => p.TblEmpDis)
                    .HasForeignKey(d => d.DisId)
                    .HasConstraintName("tbl_emp_dis_id_fkey");

                entity.HasOne(d => d.Mar)
                    .WithMany(p => p.TblEmps)
                    .HasForeignKey(d => d.MarId)
                    .HasConstraintName("tbl_emp_mar_id_fkey");

                entity.HasOne(d => d.Pos)
                    .WithMany(p => p.TblEmps)
                    .HasForeignKey(d => d.PosId)
                    .HasConstraintName("tbl_emp_pos_id_fkey");

                entity.HasOne(d => d.Pro)
                    .WithMany(p => p.TblEmpPros)
                    .HasForeignKey(d => d.ProId)
                    .HasConstraintName("tbl_emp_pro_id_fkey");

                entity.HasOne(d => d.Vill)
                    .WithMany(p => p.TblEmpVills)
                    .HasForeignKey(d => d.VillId)
                    .HasConstraintName("tbl_emp_vill_id_fkey");
            });

            modelBuilder.Entity<TblMarry>(entity =>
            {
                entity.ToTable("tbl_marries");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Del)
                    .HasColumnName("del")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<TblPosition>(entity =>
            {
                entity.ToTable("tbl_position");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Del)
                    .HasColumnName("del")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<TblProvince>(entity =>
            {
                entity.ToTable("tbl_province");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Code)
                    .HasMaxLength(3)
                    .HasColumnName("code")
                    .IsFixedLength(true);

                entity.Property(e => e.Del)
                    .HasColumnName("del")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<TblRole>(entity =>
            {
                entity.ToTable("tbl_role");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Del)
                    .HasColumnName("del")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<TblStatus>(entity =>
            {
                entity.ToTable("tbl_status");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Del)
                    .HasColumnName("del")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<TblTransection>(entity =>
            {
                entity.ToTable("tbl_transection");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AccCredit).HasColumnName("acc_credit");

                entity.Property(e => e.AccDebit).HasColumnName("acc_debit");

                entity.Property(e => e.Amount)
                    .HasColumnType("money")
                    .HasColumnName("amount");

                entity.Property(e => e.BranchId).HasColumnName("branch_id");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("date")
                    .HasColumnName("create_date");

                entity.Property(e => e.CurrencyId).HasColumnName("currency_id");

                entity.Property(e => e.Del)
                    .HasColumnName("del")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.Des).HasColumnName("des");

                entity.Property(e => e.StatusId).HasColumnName("status_id");

                entity.Property(e => e.TranNo)
                    .HasMaxLength(14)
                    .HasColumnName("tran_no");

                entity.Property(e => e.UserApproveId).HasColumnName("user_approve_id");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.HasOne(d => d.Branch)
                    .WithMany(p => p.TblTransections)
                    .HasForeignKey(d => d.BranchId)
                    .HasConstraintName("tbl_transection_branch_id_fkey");

                entity.HasOne(d => d.Currency)
                    .WithMany(p => p.TblTransections)
                    .HasForeignKey(d => d.CurrencyId)
                    .HasConstraintName("tbl_transection_currency_id_fkey");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.TblTransections)
                    .HasForeignKey(d => d.StatusId)
                    .HasConstraintName("tbl_transection_status_id_fkey");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.TblTransections)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("tbl_transection_user_id_fkey");
            });

            modelBuilder.Entity<TblUser>(entity =>
            {
                entity.ToTable("tbl_user");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Del)
                    .HasColumnName("del")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.EmpId).HasColumnName("emp_id");

                entity.Property(e => e.Password)
                    .HasMaxLength(50)
                    .HasColumnName("password");

                entity.Property(e => e.RoleId).HasColumnName("role_id");

                entity.Property(e => e.Username)
                    .HasMaxLength(50)
                    .HasColumnName("username");

                entity.HasOne(d => d.Emp)
                    .WithMany(p => p.TblUsers)
                    .HasForeignKey(d => d.EmpId)
                    .HasConstraintName("emp_id_fkey");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.TblUsers)
                    .HasForeignKey(d => d.RoleId)
                    .HasConstraintName("tbl_user_role_id_fkey");
            });

            modelBuilder.Entity<TblVillage>(entity =>
            {
                entity.ToTable("tbl_village");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Del)
                    .HasColumnName("del")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.DisId).HasColumnName("dis_id");

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .HasColumnName("name");

                entity.Property(e => e.ProId).HasColumnName("pro_id");

                entity.HasOne(d => d.Dis)
                    .WithMany(p => p.TblVillages)
                    .HasForeignKey(d => d.DisId)
                    .HasConstraintName("tbl_village_dis_id_fkey");

                entity.HasOne(d => d.Pro)
                    .WithMany(p => p.TblVillages)
                    .HasForeignKey(d => d.ProId)
                    .HasConstraintName("tbl_village_pro_id_fkey");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
