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
    public class NhomHangRepository
    {
        Context context = new Context();
     
        public int Count()
        {
            return context.NhomHangs.Count();
        }
        public List<NhomHang> getNhomHang()
        {
            return context.NhomHangs.ToList();
        }
        public void deleteAll()
        {
            //var tmp = getNhomHang();
            //tmp.ForEach(s => context.NhomHangs.Remove(s));
            //context.SaveChanges();
        }
        public bool deleteNhomHang(int NhomHangId)
        {
             bool f = false;
             try
             {
                 NhomHang mh = new NhomHang();
                 mh = context.NhomHangs.Find(NhomHangId);
                 context.NhomHangs.Remove(mh);
                 context.SaveChanges();
                 f = true;
             }
            catch{}
            return f;
        }
        public bool updateNhomHang(int NhomHangId,
            string TenNhomHang)
        {
             bool f = false;
             try
             {
                 NhomHang mh = new NhomHang();
                 mh = context.NhomHangs.Find(NhomHangId);
                 mh.TenNhom = TenNhomHang;
                 context.SaveChanges();
                 f = true;
             }
             catch { }
             return f;
        }
        public bool insertNhomHang(
         string TenNhomHang)
        {
             bool f = false;
             try
             {
                 context.NhomHangs.Add(new NhomHang
                 {
                     TenNhom = TenNhomHang,
                 });
                 context.SaveChanges();
                 f = true;
             }
             catch { }
             return f;
        }
        public int getNhomHangId(string tenNhom)
        {
            int lmhId = context.NhomHangs.Where(w => w.TenNhom == tenNhom)
              .Select(s => s.NhomHangId).Single();
            return lmhId;
        }

    }
}
