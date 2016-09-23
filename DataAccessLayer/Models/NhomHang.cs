using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Models
{
    public class NhomHang
    {
        public NhomHang()
        {
            MatHangs = new HashSet<MatHang>();
        }
        public int NhomHangId { get; set; }
        public string TenNhom { get; set; }
        public virtual ICollection<MatHang> MatHangs { get; set; }
    }
}
