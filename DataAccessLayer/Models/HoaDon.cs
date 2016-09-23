using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Models
{
   public class HoaDon
    {
       public HoaDon()
       {
           ChiTietHoaDons = new HashSet<ChiTietHoaDon>();
       }
       [Key]
        public int HoaDonId { get; set; }
        public DateTime Ngay { get; set; }
        public int KhachHangId { get; set; }
        public int NhanVienId { get; set; }
        public decimal TongTien { get; set; }
        public virtual ICollection<ChiTietHoaDon> ChiTietHoaDons { get; set; }
    }
}
