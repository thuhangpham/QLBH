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
    public class PhieuXuatRepository
    {
        Context context = new Context();
        public int Count()
        {
            return context.PhieuXuats.Count();
        }
        public DataTable getPhieuXuat()
        {
            var pxs = from  px in context.PhieuXuats
                      from nv in context.NhanViens
                      where px.NhanVienId == nv.NhanVienId 
                      select  new {px.PhieuXuatId,px.NgayXuat,nv.TenNhanVien,
                px.GhiChu};
            return pxs.ToDataTable();
        }
        public bool insertPhieuXuat( DateTime NgayXuat,
                                        int MaNV, string GhiChu)
        {
            bool f = false;
            try
            {
                context.PhieuXuats.Add(new PhieuXuat
                {
                    NgayXuat = NgayXuat,
                    NhanVienId = MaNV,
                    GhiChu = GhiChu
                });
                context.SaveChanges();
                f = true;
            }
            catch { }
            return f;
        }
       
        public bool deletePhieuXuat( int MaPX)
        {
             bool f = false;
             try
             {
                 PhieuXuat px = context.PhieuXuats.Find(MaPX);
                 context.PhieuXuats.Remove(px);
                 context.SaveChanges();
                 f = true;
             }
             catch { }
             return f;
        }
        public bool updatePhieuXuat(int MaPX, DateTime NgayXuat,
                                          int MaNV, string GhiChu)
        {
             bool f = false;
             try
             {
                 PhieuXuat px = context.PhieuXuats.Find(MaPX);
                 px.NgayXuat = NgayXuat;
                 px.NhanVienId = MaNV;
                 px.GhiChu = GhiChu;
                 context.SaveChanges();
                 f = true;
             }
             catch { }
             return f;
        }
        public bool insertCTPhieuXuat(int MaPX,
       int MaHang, int SoLuong)
        {
             bool f = false;
             try
             {
                 context.ChiTietPhieuXuats.Add(new ChiTietPhieuXuat
                 {
                     PhieuXuatId = MaPX,
                     MatHangId = MaHang,
                     SoLuong = SoLuong,
                 });
                 context.SaveChanges();
                 f = true;
             }
             catch { }
             return f;
        }
        public bool deleteCTPhieuXuat(int MaPX)
        {
             bool f = false;
             try
             {
                 ChiTietPhieuXuat px = context.ChiTietPhieuXuats.Find(MaPX);
                 context.ChiTietPhieuXuats.Remove(px);
                 context.SaveChanges();
                 f = true;
             }
             catch { }
             return f;
        }
        public DataTable getCTPhieuXuat(int MaPX)
        {
            var pxs =
               from mh in context.MatHangs
               from ct in context.ChiTietPhieuXuats
               where mh.MatHangId == ct.MatHangId && ct.PhieuXuatId == MaPX
               select new
               {
                   mh.TenMatHang,
                   mh.DonViTinh,
                   mh.GiaNhap,
                   mh.GiaBan,
                   ct.SoLuong
               };
            return pxs.ToDataTable();
        }
        public int getSoLuong(string maMH)
        {
            try
            {
                var xhang = from ct in context.ChiTietPhieuXuats
                            from px in context.PhieuXuats
                            where ct.MatHangId == Convert.ToInt32(maMH)
                            && ct.PhieuXuatId == px.PhieuXuatId
                            select ct.SoLuong;
                return Convert.ToInt32(xhang.Sum(s => s));
            }
            catch { }
            return 0;
        }
    }
}
