using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Maps
{
    public class LoaiKhachHangMap : EntityTypeConfiguration<LoaiKhachHang>
    {
        public LoaiKhachHangMap()
        {
            HasMany(p => p.KhachHangs).WithRequired().
                HasForeignKey(l => l.LoaiKhachHangId).
                WillCascadeOnDelete(false);
        }
    }
}
