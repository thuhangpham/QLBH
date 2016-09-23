using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Maps
{
    public class NuocSanXuatMap : EntityTypeConfiguration<NuocSanXuat>
    {
        public NuocSanXuatMap()
        {
            Property(p => p.TenNuoc)
                     .HasMaxLength(30)
                     .IsRequired();
            HasMany(p => p.MatHangs).WithRequired().
                HasForeignKey(h => h.NuocSXId).
                WillCascadeOnDelete(false);
        }
    }
}
