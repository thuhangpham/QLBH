using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Models
{
    public class PhieuKiemKe
    {
        public PhieuKiemKe()
        {
            ChiTietPhieuKKs = new HashSet<ChiTietPhieuKiemKe>();
        }
        [Key]
        public int PhieuKiemKeId { get; set; }
        public DateTime NgayKK { get; set; }
        public int NhanVienId { get; set; }
        public string GhiChu { get; set; }
        public virtual ICollection<ChiTietPhieuKiemKe> ChiTietPhieuKKs { get; set; }
    }
}
