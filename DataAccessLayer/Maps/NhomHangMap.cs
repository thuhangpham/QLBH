using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Maps
{
    public class NhomHangMap : EntityTypeConfiguration<NhomHang>
    {
        public NhomHangMap()
        {
            Property(p => p.TenNhom)
                     .HasMaxLength(30)
                     .IsRequired();
            HasMany(p => p.MatHangs).WithRequired().
                HasForeignKey(h => h.NhomHangId).
                WillCascadeOnDelete(false);
            // WillCascadeOnDelete: khi nhom hang thi mat hang cung phai xoa
            // neu WillCascadeOnDelete(false) thi khong cho mat hang xoa
            // -> Nhom hang cung khong the xoa
            // WillCascadeOnDelete(true); : Xoa ca dong ho :)))
        }
    }
}
