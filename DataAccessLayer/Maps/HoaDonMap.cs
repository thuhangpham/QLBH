using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Maps
{
    public class HoaDonMap : EntityTypeConfiguration<HoaDon>
    {
        public HoaDonMap()
        {
            HasMany(p => p.ChiTietHoaDons).WithRequired().
                HasForeignKey(h => h.HoaDonId).
                WillCascadeOnDelete(false);
        }
    }
}
