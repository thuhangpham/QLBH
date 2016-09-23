using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Maps
{
    public class PhieuXuatMap : EntityTypeConfiguration<PhieuXuat>
    {
        public PhieuXuatMap()
        {

            HasMany(p => p.ChiTietPhieuXuats).WithRequired().
               HasForeignKey(h => h.PhieuXuatId).
               WillCascadeOnDelete(false);
        }
    }
}
