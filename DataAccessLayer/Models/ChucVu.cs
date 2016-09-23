using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Models
{
    public class ChucVu
    {
        public ChucVu()
        {
            NhanViens = new HashSet<NhanVien>();
        }
        [Key]
        public int ChucVuId { get; set; }
        public string TenChucVu { get; set; }
        public virtual ICollection<NhanVien> NhanViens { get; set; }
    }
}
