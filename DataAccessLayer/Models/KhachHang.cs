using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Models
{
    public class KhachHang
    {
        public KhachHang()
        {
            HoaDons = new HashSet<HoaDon>();
        }
        [Key]
        public int KhachHangId { get; set; }
        public string TenKhachHang { get; set; }
        public string GioiTinh { get; set; }
        public string DiaChi { get; set; }
        public string Email { get; set; }
        public string SDT { get; set; }
        public int LoaiKhachHangId { get; set; }
        public string GhiChu { get; set; }
        public virtual ICollection<HoaDon> HoaDons { get; set; }
    }
}
