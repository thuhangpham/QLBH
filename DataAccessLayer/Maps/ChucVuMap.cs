using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Maps
{
    public class ChucVuMap : EntityTypeConfiguration<ChucVu>
    {
        public ChucVuMap()
        {
            Property(p => p.TenChucVu)
                     .HasMaxLength(30)
                     .IsRequired();
            HasMany(p => p.NhanViens).WithRequired().
                HasForeignKey(h => h.ChucVuId).
                WillCascadeOnDelete(false);
        }
    }
}
