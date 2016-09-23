using DataAccessLayer;
using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Repository
{
    public class NuocSanXuatRepository
    {
        Context context = new Context();
        public int Count()
        {
            return context.NuocSanXuat.Count();
        }
        public DataTable getNuocSanXuat()
        {
            return context.NuocSanXuat.ToList().ToDataTable();
        }
        public bool insertNuocSanXuat( string TenNuoc)
        {
             bool f = false;
             try
             {
                 context.NuocSanXuat.Add(new NuocSanXuat
                 {
                     TenNuoc = TenNuoc
                 });
                 context.SaveChanges();
                 f = true;
             }
             catch { }
             return f;
        }
        public void deleteAll()
        {
            //var tmp = getNuocSanXuat();
            //tmp.ForEach(s => context.NuocSanXuat.Remove(s));
            //context.SaveChanges();
        }
        public bool deleteNuocSanXuat(int NuocSanXuatId)
        {
             bool f = false;
             try
             {
                 context.NuocSanXuat.Remove(context.NuocSanXuat.Find(NuocSanXuatId));
                 context.SaveChanges();
                 f = true;
             }
             catch { }
             return f;
        }
        public bool updateNuocSanXuat(int NuocSanXuatId, string TenNuoc)
        { bool f = false;
        try
        {
            NuocSanXuat nsx = context.NuocSanXuat.Find(NuocSanXuatId);
            nsx.TenNuoc = TenNuoc;
            context.SaveChanges();
            f = true;
        }
        catch { }
        return f;
        }
        public int getNuocSanXuatId(string NuocSanXuat)
        {
            return context.NuocSanXuat.Where(s => s.TenNuoc == NuocSanXuat).
                Select(w => w.NuocSXId).Single();
        }
    }
}
