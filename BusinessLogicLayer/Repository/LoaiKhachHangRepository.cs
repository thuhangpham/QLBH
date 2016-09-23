using DataAccessLayer;
using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Repository
{
    public class LoaiKhachHangRepository
    {
        Context context = new Context();
        public int Count()
        {
            return context.LoaiKhachHangs.Count();
        }
        public List<LoaiKhachHang> getLoaiKhachHang()
        {
            return context.LoaiKhachHangs.ToList();
        }
        public void deleteAll()
        {
            var tmp = getLoaiKhachHang();
            tmp.ForEach(s => context.LoaiKhachHangs.Remove(s));
            context.SaveChanges();
        }
        public bool deleteLoaiKhachHang(int loaiKhachHangId)
        {
            bool f = false;
            try
            {
                LoaiKhachHang kh = new LoaiKhachHang();
                kh = context.LoaiKhachHangs.Find(loaiKhachHangId);
                context.LoaiKhachHangs.Remove(kh);
                context.SaveChanges();
                f = true;
            }
            catch { }
            return f;

        }
        public bool updateLoaiKhachHang(int loaiKhachHangId,
            string TenLoaiKhachHang, string GhiChu)
        {
            bool f = false;
            try
            {
                LoaiKhachHang kh = new LoaiKhachHang();
                kh = context.LoaiKhachHangs.Find(loaiKhachHangId);
                kh.TenLoaiKhachHang = TenLoaiKhachHang;
                kh.GhiChu = GhiChu;
                context.SaveChanges();
                f = true;
            }
            catch { }
            return f;
        }
        public bool insertLoaiKhachHang(
         string TenLoaiKhachHang, string GhiChu)
        {
            bool f = false;
            try
            {
                context.LoaiKhachHangs.Add(new LoaiKhachHang
                {
                    TenLoaiKhachHang = TenLoaiKhachHang,
                    GhiChu = GhiChu
                });
                context.SaveChanges();
                f = true;
            }
            catch { }
            return f;
        }
        public string getGhiChuLoaiKhachHang(int loaiKhachHangId)
        {
            string str = context.LoaiKhachHangs.Where(w => w.LoaiKhachHangId == loaiKhachHangId)
                .Select(s => s.GhiChu).Single();
            return str;
        }
        public int getLoaiKhachHangId(string tenLoaiKh)
        {
            int lkhId = context.LoaiKhachHangs.Where(w => w.TenLoaiKhachHang == tenLoaiKh)
              .Select(s => s.LoaiKhachHangId).Single();
            return lkhId;
        }
    }
}
