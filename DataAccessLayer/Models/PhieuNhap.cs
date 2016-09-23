using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Models
{
   public class PhieuNhap
    {
       public PhieuNhap()
       {
           ChiTietPhieuNhaps = new HashSet<ChiTietPhieuNhap>();
       }
       [Key]
        public int PhieuNhapId { get; set; }
        public DateTime NgayNhap { get; set; }
        public int NhaCungCapId { get; set; }
        public decimal TongTien { get; set; }
        public int NhanVienId { get; set; }
        public string  GhiChu { get; set; }
        public virtual ICollection<ChiTietPhieuNhap> ChiTietPhieuNhaps { get; set; }
    }
}
