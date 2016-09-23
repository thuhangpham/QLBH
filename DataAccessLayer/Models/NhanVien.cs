using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Models
{
    public class NhanVien
    {
        public NhanVien()
        {
            HoaDons = new HashSet<HoaDon>();
            PhieuKiemKes = new HashSet<PhieuKiemKe>();
            PhieuNhaps = new HashSet<PhieuNhap>();
            PhieuXuats = new HashSet<PhieuXuat>();
        }
        [Key]
        public int NhanVienId { get; set; }
        public int ChucVuId { get; set; }
        public string TenNhanVien { get; set; }
        public string GioiTinh { get; set; }
        public string DiaChi { get; set; }
        public string Email { get; set; }
        public string SDT { get; set; }
        public bool Admin { get; set; }
        public string Password { get; set; }
        public Decimal Luong { get; set; }
        public virtual ICollection<HoaDon> HoaDons { get; set; }
        public virtual ICollection<PhieuKiemKe> PhieuKiemKes { get; set; }
        public virtual ICollection<PhieuNhap> PhieuNhaps { get; set; }
        public virtual ICollection<PhieuXuat> PhieuXuats { get; set; }
    }
}
