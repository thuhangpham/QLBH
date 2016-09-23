using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Maps
{
    public class NhanVienMap : EntityTypeConfiguration<NhanVien>
    {
        public NhanVienMap()
        {
            HasMany(p => p.HoaDons).WithRequired().
                HasForeignKey(l => l.NhanVienId).
                WillCascadeOnDelete(false);

            HasMany(p => p.PhieuNhaps).WithRequired().
                HasForeignKey(l => l.NhanVienId).
                WillCascadeOnDelete(false);

            HasMany(p => p.PhieuKiemKes).WithRequired().
                HasForeignKey(l => l.NhanVienId).
                WillCascadeOnDelete(false);

            HasMany(p => p.PhieuXuats).WithRequired().
               HasForeignKey(l => l.NhanVienId).
               WillCascadeOnDelete(false);
        }
    }
}
