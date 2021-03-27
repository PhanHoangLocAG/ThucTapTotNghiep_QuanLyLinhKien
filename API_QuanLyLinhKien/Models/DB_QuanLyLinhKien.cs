using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace API_QuanLyLinhKien.Models
{
    public partial class DB_QuanLyLinhKien : DbContext
    {
        public DB_QuanLyLinhKien()
            : base("name=DB_QuanLyLinhKien")
        {
        }

        public virtual DbSet<ChiTietHD> ChiTietHDs { get; set; }
        public virtual DbSet<ChiTietPhieuNhap> ChiTietPhieuNhaps { get; set; }
        public virtual DbSet<ChiTietPhieuXuat> ChiTietPhieuXuats { get; set; }
        public virtual DbSet<ChucVu> ChucVus { get; set; }
        public virtual DbSet<DonViTinh> DonViTinhs { get; set; }
        public virtual DbSet<HangSX> HangSXes { get; set; }
        public virtual DbSet<HoaDon> HoaDons { get; set; }
        public virtual DbSet<KhachHang> KhachHangs { get; set; }
        public virtual DbSet<LinhKien> LinhKiens { get; set; }
        public virtual DbSet<LoaiLK> LoaiLKs { get; set; }
        public virtual DbSet<LuongNV> LuongNVs { get; set; }
        public virtual DbSet<NhaCC> NhaCCs { get; set; }
        public virtual DbSet<NhanVien> NhanViens { get; set; }
        public virtual DbSet<PhieuXuat> PhieuXuats { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ChiTietHD>()
                .Property(e => e.MaLK)
                .IsUnicode(false);

            modelBuilder.Entity<ChiTietPhieuNhap>()
                .Property(e => e.MaPN)
                .IsUnicode(false);

            modelBuilder.Entity<ChiTietPhieuNhap>()
                .Property(e => e.MaLK)
                .IsUnicode(false);

            modelBuilder.Entity<ChiTietPhieuNhap>()
                .Property(e => e.DonViTinh)
                .IsUnicode(false);

            modelBuilder.Entity<ChiTietPhieuXuat>()
                .Property(e => e.MaLK)
                .IsUnicode(false);

            modelBuilder.Entity<ChucVu>()
                .Property(e => e.MaCV)
                .IsUnicode(false);

            modelBuilder.Entity<ChucVu>()
                .HasMany(e => e.NhanViens)
                .WithOptional(e => e.ChucVu1)
                .HasForeignKey(e => e.ChucVu);

            modelBuilder.Entity<DonViTinh>()
                .Property(e => e.MaDVT)
                .IsUnicode(false);

            modelBuilder.Entity<DonViTinh>()
                .HasMany(e => e.ChiTietPhieuNhaps)
                .WithRequired(e => e.DonViTinh1)
                .HasForeignKey(e => e.DonViTinh)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<HangSX>()
                .Property(e => e.MaHangSX)
                .IsUnicode(false);

            modelBuilder.Entity<HangSX>()
                .HasMany(e => e.LinhKiens)
                .WithRequired(e => e.HangSX1)
                .HasForeignKey(e => e.HangSX)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<HoaDon>()
                .Property(e => e.MaKH)
                .IsUnicode(false);

            modelBuilder.Entity<HoaDon>()
                .Property(e => e.MaNV)
                .IsUnicode(false);

            modelBuilder.Entity<HoaDon>()
                .HasMany(e => e.ChiTietHDs)
                .WithRequired(e => e.HoaDon)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<KhachHang>()
                .Property(e => e.MaKH)
                .IsUnicode(false);

            modelBuilder.Entity<KhachHang>()
                .Property(e => e.SoDT)
                .IsUnicode(false);

            modelBuilder.Entity<KhachHang>()
                .HasMany(e => e.HoaDons)
                .WithRequired(e => e.KhachHang)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<LinhKien>()
                .Property(e => e.MaLK)
                .IsUnicode(false);

            modelBuilder.Entity<LinhKien>()
                .Property(e => e.MaLoai)
                .IsUnicode(false);

            modelBuilder.Entity<LinhKien>()
                .Property(e => e.MaNCC)
                .IsUnicode(false);

            modelBuilder.Entity<LinhKien>()
                .Property(e => e.MoTa)
                .IsUnicode(false);

            modelBuilder.Entity<LinhKien>()
                .Property(e => e.Hinh)
                .IsUnicode(false);

            modelBuilder.Entity<LinhKien>()
                .Property(e => e.HangSX)
                .IsUnicode(false);

            modelBuilder.Entity<LinhKien>()
                .HasMany(e => e.ChiTietHDs)
                .WithRequired(e => e.LinhKien)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<LinhKien>()
                .HasMany(e => e.ChiTietPhieuNhaps)
                .WithRequired(e => e.LinhKien)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<LinhKien>()
                .HasMany(e => e.ChiTietPhieuXuats)
                .WithRequired(e => e.LinhKien)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<LoaiLK>()
                .Property(e => e.MaLoai)
                .IsUnicode(false);

            modelBuilder.Entity<LoaiLK>()
                .HasMany(e => e.LinhKiens)
                .WithRequired(e => e.LoaiLK)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<LuongNV>()
                .HasMany(e => e.NhanViens)
                .WithRequired(e => e.LuongNV)
                .HasForeignKey(e => e.Luong)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NhaCC>()
                .Property(e => e.MaNCC)
                .IsUnicode(false);

            modelBuilder.Entity<NhaCC>()
                .HasMany(e => e.LinhKiens)
                .WithRequired(e => e.NhaCC)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NhanVien>()
                .Property(e => e.MaNV)
                .IsUnicode(false);

            modelBuilder.Entity<NhanVien>()
                .Property(e => e.SoDT)
                .IsUnicode(false);

            modelBuilder.Entity<NhanVien>()
                .Property(e => e.UserName)
                .IsUnicode(false);

            modelBuilder.Entity<NhanVien>()
                .Property(e => e.Pass)
                .IsUnicode(false);

            modelBuilder.Entity<NhanVien>()
                .Property(e => e.ChucVu)
                .IsUnicode(false);

            modelBuilder.Entity<NhanVien>()
                .HasMany(e => e.HoaDons)
                .WithRequired(e => e.NhanVien)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PhieuXuat>()
                .Property(e => e.MaKH)
                .IsUnicode(false);

            modelBuilder.Entity<PhieuXuat>()
                .Property(e => e.MaNV)
                .IsUnicode(false);

            modelBuilder.Entity<PhieuXuat>()
                .HasMany(e => e.ChiTietPhieuXuats)
                .WithRequired(e => e.PhieuXuat)
                .WillCascadeOnDelete(false);
        }
    }
}
