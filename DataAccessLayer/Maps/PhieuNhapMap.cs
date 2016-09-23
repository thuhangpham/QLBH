using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Maps
{
    public class PhieuNhapMap : EntityTypeConfiguration<PhieuNhap>
    {
        public PhieuNhapMap()
        {

            HasMany(p => p.ChiTietPhieuNhaps).WithRequired().
               HasForeignKey(h => h.PhieuNhapId).
               WillCascadeOnDelete(false);
        }
    }
}
