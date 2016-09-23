using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Maps
{
    public class PhieuKiemKeMap : EntityTypeConfiguration<PhieuKiemKe>
    {
        public PhieuKiemKeMap()
        {
            HasMany(p => p.ChiTietPhieuKKs).WithRequired().
               HasForeignKey(h => h.PhieuKiemKeId).
               WillCascadeOnDelete(false);
        }
    }
}
