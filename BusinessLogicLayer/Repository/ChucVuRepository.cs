using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Models;
using DataAccessLayer;
namespace BusinessLogicLayer.Repository
{
    public class ChucVuRepository
    {
        Context context = new Context();
        public int Count()
        {
            return context.ChucVus.Count();
        }
        public List<ChucVu> getChucVu()
        {
            return context.ChucVus.ToList();
        }
        public bool insertChucVu(string TenChucVu)
        {
            bool f=false;
            try
            {
                var cv =
                    new ChucVu
                    {
                        TenChucVu = TenChucVu
                    };
                context.ChucVus.Add(cv);
                context.SaveChanges();
                f = true;
            }
            catch {  }
            return f;
        }
        public bool deleteChucVu(int chucVuId)
        {
            bool f=false;
            try
            {
                ChucVu cv = new ChucVu();
                cv = context.ChucVus.Find(chucVuId);
                context.ChucVus.Remove(cv);
                context.SaveChanges();
                f = true;
            }
            catch { }
            return f;
        }
        public void deleteAll()
        {
            var tmp = getChucVu();
            tmp.ForEach(s => context.ChucVus.Remove(s));
            context.SaveChanges();
        }
        public bool updateChucVu(int chucVuId, string tenChucVu)
        {
            bool f = false;
            try
            {
                ChucVu cv = new ChucVu();
                cv = context.ChucVus.Find(chucVuId);
                cv.TenChucVu = tenChucVu;
                context.SaveChanges();
                f = true;
            }
            catch { }
            return f;
        }
        public object getChucVuId(string TenChucVu)
        {
            try
            {
                return context.ChucVus.Where(w => w.TenChucVu == TenChucVu).
                    Select(s => s.ChucVuId).Single();
            }
            catch { return null; }
        }
    }
}
