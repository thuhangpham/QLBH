using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Models
{
 public   class ChiTietPhieuKiemKe
    {
      [Key, Column(Order = 0)]
     public int PhieuKiemKeId { get; set; }
      [Key, Column(Order = 1)]
     public int MatHangId { get; set; }
     public int SLNhap { get; set; }
     public int SLXuat { get; set; }
     public int SLBan { get; set; }
     public int SLTon { get; set; }
     public int SLTrenQuay { get; set; }
     public string GhiChu { get; set; }
    }
}
