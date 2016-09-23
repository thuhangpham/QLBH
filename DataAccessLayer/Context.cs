using DataAccessLayer.Maps;
using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class Context : DbContext
    {
        // ten database muon tao
        public Context() : base ("name=QLBachHoaEF3")
        { 
        }
        // Ten table trong Sql: NhaCungCaps
        // quen doi ten namespace :)))

        public DbSet<ChucVu> ChucVus { get; set; }
        public DbSet<NhanVien> NhanViens { get; set; }
        public DbSet<NuocSanXuat> NuocSanXuat { get; set; }
        public DbSet<HoaDon> HoaDons { get; set; }
        public DbSet<NhaCungCap> NhaCungCaps { get; set; }
        public DbSet<NhomHang> NhomHangs { get; set; }
        public DbSet<MatHang> MatHangs { get; set; }
        public DbSet<PhieuXuat> PhieuXuats { get; set; }
        public DbSet<PhieuNhap> PhieuNhaps { get; set; }
        public DbSet<PhieuKiemKe> PhieuKiemKes { get; set; }
        public DbSet<LoaiKhachHang> LoaiKhachHangs { get; set; }
        public DbSet<KhachHang> KhachHangs { get; set; }
        public DbSet<ChiTietHoaDon> ChiTietHoaDons { get; set; }
        public DbSet<ChiTietPhieuKiemKe> ChiTietPhieuKiemKes { get; set; }
        public DbSet<ChiTietPhieuNhap> ChiTietPhieuNhaps { get; set; }
        public DbSet<ChiTietPhieuXuat> ChiTietPhieuXuats { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ChucVuMap());
            modelBuilder.Configurations.Add(new MatHangMap());
            modelBuilder.Configurations.Add(new HoaDonMap());
            modelBuilder.Configurations.Add(new PhieuKiemKeMap());
            modelBuilder.Configurations.Add(new PhieuNhapMap());
            modelBuilder.Configurations.Add(new PhieuXuatMap());
            modelBuilder.Configurations.Add(new NhomHangMap());
            modelBuilder.Configurations.Add(new NhaCungCapMap());
            modelBuilder.Configurations.Add(new NhanVienMap());
            modelBuilder.Configurations.Add(new NuocSanXuatMap());
            modelBuilder.Configurations.Add(new LoaiKhachHangMap());
            modelBuilder.Configurations.Add(new KhachHangMap());
            base.OnModelCreating(modelBuilder);
        }
    }
}
