using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Models
{
    public class PhieuXuat
    {
        public PhieuXuat()
        {
            ChiTietPhieuXuats = new HashSet<ChiTietPhieuXuat>();
        }
        [Key]
        public int PhieuXuatId { get; set; }
        public DateTime NgayXuat { get; set; }
        public int NhanVienId { get; set; }
        public string GhiChu { get; set; }
        public virtual ICollection<ChiTietPhieuXuat> ChiTietPhieuXuats { get; set; }
    }
}
