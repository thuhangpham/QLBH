using DataAccessLayer;
using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Repository
{
   public class PhieuNhapRepository
    {
        Context context = new Context();
        public int Count()
        {
            return context.PhieuNhaps.Count();
        }
       public DataTable getPhieuNhap()
       {
           var ctpns = from pn in context.PhieuNhaps
                       from nv in context.NhanViens
                       from ncc in context.NhaCungCaps
                       where pn.NhanVienId == nv.NhanVienId &&
                       ncc.NhaCungCapId == pn.NhaCungCapId
                       select new
                       {
                           pn.PhieuNhapId,
                           pn.NgayNhap,
                           ncc.TenNhaCungCap,
                           nv.TenNhanVien,
                           pn.TongTien,
                           pn.GhiChu
                       };
           return ctpns.ToDataTable();
       }
       public DataTable getCTPhieuNhap(int MaPN)
       {
           var ctpns = from mh in context.MatHangs
                       from ct in context.ChiTietPhieuNhaps
                       where mh.MatHangId == ct.MatHangId && ct.PhieuNhapId == MaPN
                       select new { mh.MatHangId, mh.TenMatHang, mh.GiaNhap, ct.SoLuong, ct.DonGia };
           return ctpns.ToDataTable();
       }
        public bool insertPhieuNhap(DateTime NgayNhap,
            int MaNCC, decimal TongTien, int MaNV, string GhiChu)
       {
           bool f = false;
           try
           {
               context.PhieuNhaps.Add(new PhieuNhap
               {
                   NgayNhap = NgayNhap,
                   NhaCungCapId = MaNCC,
                   TongTien = TongTien,
                   NhanVienId = MaNV,
                   GhiChu = GhiChu
               });
               context.SaveChanges();
               f = true;
           }
           catch { }
           return f;
       }
        public bool deletePhieuNhap( int MaPN)
        {
              bool f = false;
              try
              {
                  PhieuNhap pn = context.PhieuNhaps.Find(MaPN);
                  context.PhieuNhaps.Remove(pn);
                  context.SaveChanges();
                  f = true;
              }
              catch { }
              return f;
        }
        public bool updatePhieuNhap( int MaPN, DateTime NgayNhap,
             int MaNCC, decimal TongTien, int MaNV, string GhiChu)
        {
              bool f = false;
              try
              {
                  PhieuNhap pn = context.PhieuNhaps.Find(MaPN);
                  pn.NgayNhap = NgayNhap;
                  pn.NhaCungCapId = MaNCC;
                  pn.TongTien = TongTien;
                  pn.NhanVienId = MaNV;
                  pn.GhiChu = GhiChu;
                  context.SaveChanges();
                  f = true;
              }
              catch { }
              return f;
        }
         public bool insertCTPhieuNhap( int MaPN,  
        int MaHang, int SoLuong, decimal DonGia)
        {
               bool f = false;
               try
               {
                   context.ChiTietPhieuNhaps.Add(new ChiTietPhieuNhap
                   {
                       PhieuNhapId = MaPN,
                       MatHangId = MaHang,
                       SoLuong = SoLuong,
                       DonGia = DonGia
                   });
                   context.SaveChanges();
                   f = true;
               }
               catch { }
               return f;
        }
         public int getSoLuong(ref string err,string maMH)
         {
             try
             {
                 var xhang = from ct in context.ChiTietPhieuNhaps
                             from px in context.PhieuNhaps
                             where ct.MatHangId == Convert.ToInt32(maMH)
                             && ct.PhieuNhapId == px.PhieuNhapId
                             select ct.SoLuong;
                 return Int32.Parse(xhang.Sum(s => s).ToString());
             }
             catch (Exception ex) { err = ex.Message; }
             return 0;
         }
    }
}
