using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Maps
{
    public class MatHangMap : EntityTypeConfiguration<MatHang>
    {
        public MatHangMap()
        {
            HasMany(p => p.ChiTietHoaDons).WithRequired().
                HasForeignKey(h => h.MatHangId).
                WillCascadeOnDelete(false);

            HasMany(p => p.ChiTietPhieuKKs).WithRequired().
            HasForeignKey(h => h.MatHangId).
            WillCascadeOnDelete(false);

            HasMany(p => p.ChiTietPhieuNhaps).WithRequired().
            HasForeignKey(h => h.MatHangId).
            WillCascadeOnDelete(false);

            HasMany(p => p.ChiTietPhieuXuats).WithRequired().
            HasForeignKey(h => h.MatHangId).
            WillCascadeOnDelete(false);
        }
    }
}
