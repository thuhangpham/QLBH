using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Maps
{
    public class KhachHangMap : EntityTypeConfiguration<KhachHang>
    {
        public KhachHangMap()
        {
            HasMany(p => p.HoaDons).WithRequired().
                HasForeignKey(l => l.KhachHangId).
                WillCascadeOnDelete(false);
        }
    }
}
