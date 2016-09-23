using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Models
{
   public class LoaiKhachHang
    {
       public LoaiKhachHang()
       {
           KhachHangs = new HashSet<KhachHang>();
       }
       [Key]
        public int LoaiKhachHangId { get; set; }
        public string  TenLoaiKhachHang { get; set; }
        public string GhiChu { get; set; }
        public virtual ICollection<KhachHang> KhachHangs { get; set; }
    }
}
