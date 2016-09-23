using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Models
{
    public class NuocSanXuat
    {
        public NuocSanXuat()
        {
            MatHangs = new HashSet<MatHang>();
        }
        [Key]
        public int NuocSXId { get; set; }
        public string  TenNuoc { get; set; }
        public virtual ICollection<MatHang> MatHangs { get; set; }
    }
}
