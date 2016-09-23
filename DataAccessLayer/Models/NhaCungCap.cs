using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Models
{
    public class NhaCungCap
    {
        public NhaCungCap()
        {
            PhieuNhaps = new HashSet<PhieuNhap>();
        }
        [Key]
        public int NhaCungCapId { get; set; }
        public string TenNhaCungCap { get; set; }
        public string DiaChi { get; set; }
        public string Email { get; set; }
        public string SDT { get; set; }
        public string GhiChu { get; set; }
        public virtual ICollection<PhieuNhap> PhieuNhaps { get; set; }

    }
}
