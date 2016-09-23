using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Models
{
    public class MatHang
    {
        public MatHang()
        {
            ChiTietHoaDons = new HashSet<ChiTietHoaDon>();
            ChiTietPhieuKKs = new HashSet<ChiTietPhieuKiemKe>();
            ChiTietPhieuNhaps = new HashSet<ChiTietPhieuNhap>();
            ChiTietPhieuXuats = new HashSet<ChiTietPhieuXuat>();
        }
        [Key]
        public int MatHangId { get; set; }
        public string TenMatHang { get; set; }
        public string DonViTinh { get; set; }
        public double TrongLuong { get; set; }
        public string HSD { get; set; }
        public int NuocSXId { get; set; }
        public int NhomHangId { get; set; }
        public decimal GiaNhap { get; set; }
        public decimal GiaBan { get; set; }
        public string GhiChu { get; set; }
        public virtual ICollection<ChiTietHoaDon> ChiTietHoaDons { get; set; }
        public virtual ICollection<ChiTietPhieuKiemKe> ChiTietPhieuKKs { get; set; }
        public virtual ICollection<ChiTietPhieuNhap> ChiTietPhieuNhaps { get; set; }
        public virtual ICollection<ChiTietPhieuXuat> ChiTietPhieuXuats { get; set; }

    }
}
