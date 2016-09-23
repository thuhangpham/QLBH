using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Maps
{

    public class NhaCungCapMap : EntityTypeConfiguration<NhaCungCap>
    {
        public NhaCungCapMap()
        {
            HasMany(p => p.PhieuNhaps).WithRequired().
                HasForeignKey(l => l.NhaCungCapId).
                WillCascadeOnDelete(false);
        }
    }
}
