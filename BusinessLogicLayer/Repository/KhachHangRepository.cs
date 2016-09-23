using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using DataAccessLayer.Models;
using System.Data;
using System.Data.SqlClient;

namespace BusinessLogicLayer.Repository
{
    public class KhachHangRepository
    {
        Context context = new Context();
        public int Count()
        {
            return context.KhachHangs.Count();
        }
        public List<KhachHang> getKhachHangList()
        {
            return context.KhachHangs.ToList();
        }
        public DataTable getKhachHang()
        {
            var t =
                   from kh in context.KhachHangs
                   from lkh in context.LoaiKhachHangs
                   where kh.LoaiKhachHangId == lkh.LoaiKhachHangId
                   select new
                   {
                       kh.KhachHangId,
                       kh.TenKhachHang,
                       kh.GioiTinh,
                       kh.DiaChi,
                       kh.Email,
                       kh.SDT,
                       lkh.TenLoaiKhachHang,
                       kh.GhiChu
                   };
            //var dt = new DataTable();
            //dt.Columns.Add(new DataColumn("KhachHangId"));
            //dt.Columns.Add(new DataColumn("TenKhachHang"));
            //dt.Columns.Add(new DataColumn("GioiTinh"));
            //dt.Columns.Add(new DataColumn("DiaChi"));
            //dt.Columns.Add(new DataColumn("Email"));
            //dt.Columns.Add(new DataColumn("SDT"));
            //dt.Columns.Add(new DataColumn("TenLoaiKhachHang"));
            //dt.Columns.Add(new DataColumn("GhiChu"));
            //foreach (var item in t.ToList())
            //{
            //    dt.LoadDataRow(new object[] {
            //        item.KhachHangId,
            //        item.TenKhachHang,
            //        item.GioiTinh,
            //        item.DiaChi,
            //        item.Email,
            //        item.SDT,
            //        item.TenLoaiKhachHang,
            //        item.GhiChu
            //    }, true);
            //}
            return t.ToDataTable();
        }
        public void deleteAll()
        {
            var tmp = getKhachHangList();
            tmp.ForEach(s => context.KhachHangs.Remove(s));
            context.SaveChanges();
        }
        public bool deleteKhachHang(int khachHangId)
        {
            bool f = false;
            try
            {
                KhachHang kh = new KhachHang();
                kh = context.KhachHangs.Find(khachHangId);
                context.KhachHangs.Remove(kh);
                context.SaveChanges();
                f = true;
            }
            catch { }
            return f;
        }
        public bool updateKhachHang(int khachHangId, string TenKhachHang, string GioiTinh,
            string DiaChi, string Email, string SDT, int LoaiKhachHangId, string GhiChu)
        {
            bool f = false;
            try
            {
                KhachHang kh = new KhachHang();
                kh = context.KhachHangs.Find(khachHangId);
                kh.TenKhachHang = TenKhachHang;
                kh.GioiTinh = GioiTinh;
                kh.DiaChi = DiaChi;
                kh.Email = Email;
                kh.SDT = SDT;
                kh.LoaiKhachHangId = LoaiKhachHangId;
                kh.GhiChu = GhiChu;
                context.SaveChanges();
                f = true;
            }
            catch { }
            return f;
        }
        public bool insertKhachHang(string TenKhachHang, string GioiTinh,
            string DiaChi, string Email, string SDT, int LoaiKhachHangId, string GhiChu)
        {
            bool f = false;
            try
            {
                context.KhachHangs.Add(new KhachHang
                {
                    TenKhachHang = TenKhachHang,
                    GioiTinh = GioiTinh,
                    DiaChi = DiaChi,
                    Email = Email,
                    SDT = SDT,
                    LoaiKhachHangId = LoaiKhachHangId,
                    GhiChu = GhiChu
                });
                context.SaveChanges();
                f = true;
            }
            catch { }
            return f;
        }
        public DataTable getKhachHangBanHang()
        {
            var khs = from kh in context.KhachHangs
                      from lkh in context.LoaiKhachHangs
                      where
                      kh.LoaiKhachHangId == lkh.LoaiKhachHangId
                      select new
                      {
                          kh.KhachHangId,
                          kh.TenKhachHang,
                          kh.GioiTinh,
                          kh.SDT,
                          lkh.TenLoaiKhachHang,
                          kh.GhiChu
                      };
            return khs.ToDataTable();

        }
        public DataTable getKhachHangTheoLKH(int LoaiKhachHangId)
        {
             var t =
                   from kh in context.KhachHangs
                   from lkh in context.LoaiKhachHangs
                   where (kh.LoaiKhachHangId == lkh.LoaiKhachHangId && 
                   lkh.LoaiKhachHangId==LoaiKhachHangId)
                   select new
                   {
                       kh.KhachHangId,
                       kh.TenKhachHang,
                       kh.GioiTinh,
                       kh.DiaChi,
                       kh.Email,
                       kh.SDT,
                       lkh.TenLoaiKhachHang,
                       kh.GhiChu
                   };
            return t.ToDataTable();
        }

        public DataTable getKhachHangSearch(string strKH)
        {
            var khs = from kh in context.KhachHangs
                      from lkh in context.LoaiKhachHangs
                      where kh.TenKhachHang.Contains(strKH) && 
                      kh.LoaiKhachHangId==lkh.LoaiKhachHangId
                      select new { kh.KhachHangId,kh.TenKhachHang,kh.GioiTinh,
                      kh.SDT,lkh.TenLoaiKhachHang,kh.GhiChu};
            return khs.ToDataTable();
        }
      
    }
}
