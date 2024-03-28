using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Reviewer.Models.Data
{
    public partial class ReviewSPContext : DbContext
    {
        public ReviewSPContext()
        {
        }

        public ReviewSPContext(DbContextOptions<ReviewSPContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Admin> Admin { get; set; }
        public virtual DbSet<Author> Author { get; set; }
        public virtual DbSet<BaiViet> BaiViet { get; set; }
        public virtual DbSet<ChuyenMuc> ChuyenMuc { get; set; }
        public virtual DbSet<KhachHang> KhachHang { get; set; }
        public virtual DbSet<LienHe> LienHe { get; set; }
        public virtual DbSet<LoaiSp> LoaiSp { get; set; }
        public virtual DbSet<Pay> Pay { get; set; }
        public virtual DbSet<PostBv> PostBv { get; set; }
        public virtual DbSet<Subcribe> Subcribe { get; set; }
        public virtual DbSet<Tag> Tag { get; set; }
        public virtual DbSet<Voucher> Voucher { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=LAPTOP-1MDO8RLN;Database=ReviewSP;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.4-servicing-10062");

            modelBuilder.Entity<Admin>(entity =>
            {
                entity.HasKey(e => e.MaAdmin)
                    .HasName("PK_UserId");

                entity.HasIndex(e => e.EmailAd)
                    .HasName("UQ__Admin__7ED8D7C8DA691BA8")
                    .IsUnique();

                entity.HasIndex(e => e.PasswordAd)
                    .HasName("UQ__Admin__EA7BB3C3A48C8ED2")
                    .IsUnique();

                entity.Property(e => e.AvatarAd)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EmailAd)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FullnameAd)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.PasswordAd)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UsernameAd)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Author>(entity =>
            {
                entity.HasKey(e => e.MaReviewer)
                    .HasName("PK_Id");

                entity.HasIndex(e => e.EmailRe)
                    .HasName("UQ__Author__7ED96C24C4193C7B")
                    .IsUnique();

                entity.HasIndex(e => e.PasswordRe)
                    .HasName("UQ__Author__EA7A25EF600594CC")
                    .IsUnique();

                entity.Property(e => e.AvatarRe)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DiaChiRe).HasMaxLength(200);

                entity.Property(e => e.EmailRe)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FullnameRe)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.PasswordRe)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SoTien).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.UsernameRe)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BaiViet>(entity =>
            {
                entity.HasKey(e => e.MaBai);

                entity.Property(e => e.HinhAnhBv)
                    .HasColumnName("HinhAnhBV")
                    .HasColumnType("ntext");

                entity.Property(e => e.NgayViet).HasColumnType("date");

                entity.Property(e => e.TenBai)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.HasOne(d => d.MaLoaiNavigation)
                    .WithMany(p => p.BaiViet)
                    .HasForeignKey(d => d.MaLoai)
                    .HasConstraintName("FK_LoaiSP");

                entity.HasOne(d => d.MaReviewerNavigation)
                    .WithMany(p => p.BaiViet)
                    .HasForeignKey(d => d.MaReviewer)
                    .HasConstraintName("FK_Reviewer");

                entity.HasOne(d => d.MaTagNavigation)
                    .WithMany(p => p.BaiViet)
                    .HasForeignKey(d => d.MaTag)
                    .HasConstraintName("FK_TagBV");
            });

            modelBuilder.Entity<ChuyenMuc>(entity =>
            {
                entity.HasKey(e => e.MaMuc);

                entity.Property(e => e.HinhChuyenMuc)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TenMuc)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<KhachHang>(entity =>
            {
                entity.HasKey(e => e.MaKh);

                entity.HasIndex(e => e.EmailKh)
                    .HasName("UQ__KhachHan__7ED9643F182CDE1C")
                    .IsUnique();

                entity.HasIndex(e => e.UsernameKh)
                    .HasName("UQ__KhachHan__15DC6890FA6704CF")
                    .IsUnique();

                entity.Property(e => e.MaKh).HasColumnName("MaKH");

                entity.Property(e => e.AvatarKh)
                    .HasColumnName("AvatarKH")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EmailKh)
                    .HasColumnName("EmailKH")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.HoTenKh)
                    .HasColumnName("HoTenKH")
                    .HasMaxLength(40);

                entity.Property(e => e.PassKh)
                    .IsRequired()
                    .HasColumnName("PassKH")
                    .HasMaxLength(50);

                entity.Property(e => e.UsernameKh)
                    .HasColumnName("UsernameKH")
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<LienHe>(entity =>
            {
                entity.HasKey(e => e.MaLh);

                entity.HasIndex(e => e.Email)
                    .HasName("UQ__LienHe__A9D10534FFD10B2D")
                    .IsUnique();

                entity.Property(e => e.MaLh).HasColumnName("MaLH");

                entity.Property(e => e.Email).HasMaxLength(100);

                entity.Property(e => e.HoTen).HasMaxLength(40);
            });

            modelBuilder.Entity<LoaiSp>(entity =>
            {
                entity.HasKey(e => e.MaLoai);

                entity.ToTable("LoaiSP");

                entity.Property(e => e.TenLoai)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.MaMucNavigation)
                    .WithMany(p => p.LoaiSp)
                    .HasForeignKey(d => d.MaMuc)
                    .HasConstraintName("FK_ChuyenMuc");
            });

            modelBuilder.Entity<Pay>(entity =>
            {
                entity.HasKey(e => e.IdPay);

                entity.Property(e => e.EmailNl)
                    .HasColumnName("EmailNL")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NgayGio).HasColumnType("datetime");

                entity.Property(e => e.NgayGioHoanTat).HasColumnType("datetime");

                entity.Property(e => e.SoTien).HasColumnType("decimal(18, 0)");

                entity.HasOne(d => d.MaReviewerNavigation)
                    .WithMany(p => p.Pay)
                    .HasForeignKey(d => d.MaReviewer)
                    .HasConstraintName("FK_Review");
            });

            modelBuilder.Entity<PostBv>(entity =>
            {
                entity.HasKey(e => e.MaPost);

                entity.ToTable("PostBV");

                entity.Property(e => e.HinhAnhBv)
                    .HasColumnName("HinhAnhBV")
                    .HasColumnType("ntext");

                entity.Property(e => e.MaLoai).HasDefaultValueSql("('1')");

                entity.Property(e => e.NgayGioDuyet).HasColumnType("datetime");

                entity.Property(e => e.NgayViet).HasColumnType("date");

                entity.Property(e => e.TenBai)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.HasOne(d => d.MaLoaiNavigation)
                    .WithMany(p => p.PostBv)
                    .HasForeignKey(d => d.MaLoai)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MaLoaiPost");

                entity.HasOne(d => d.MaReviewerNavigation)
                    .WithMany(p => p.PostBv)
                    .HasForeignKey(d => d.MaReviewer)
                    .HasConstraintName("FK_NguoiDang");

                entity.HasOne(d => d.MaTagNavigation)
                    .WithMany(p => p.PostBv)
                    .HasForeignKey(d => d.MaTag)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MaTagPost");
            });

            modelBuilder.Entity<Subcribe>(entity =>
            {
                entity.HasKey(e => e.MaSub)
                    .HasName("PK_Sub");

                entity.Property(e => e.EmailSub)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Tag>(entity =>
            {
                entity.HasKey(e => e.MaTag)
                    .HasName("PK_Tag");

                entity.ToTable("TAG");

                entity.Property(e => e.TenTag).HasMaxLength(100);
            });

            modelBuilder.Entity<Voucher>(entity =>
            {
                entity.HasKey(e => e.IdVoucher)
                    .HasName("PK_VC");

                entity.Property(e => e.GiamGia)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Hsd)
                    .HasColumnName("HSD")
                    .HasColumnType("datetime");

                entity.Property(e => e.MaVoucher).HasMaxLength(20);
            });
        }
    }
}
