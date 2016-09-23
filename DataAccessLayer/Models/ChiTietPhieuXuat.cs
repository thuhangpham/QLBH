using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Models
{
    public class ChiTietPhieuXuat
    {
        [Key, Column(Order=0)]
        public int PhieuXuatId { get; set; }
         [Key, Column(Order = 1)]
        public int MatHangId { get; set; }
        public int SoLuong { get; set; }
    }
}
