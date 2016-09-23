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
    public class HoaDonRepository
    {
        Context context = new Context();
        public int Count()
        {
            return context.HoaDons.Count();
        }
        public List<HoaDon> getHoaDonList()
        {
            return context.HoaDons.ToList();
        }
        public DataTable getHoaDon()
        {
            var hds = from hd in context.HoaDons
                      from nv in context.NhanViens
                      from kh in context.KhachHangs
                      where hd.KhachHangId == kh.KhachHangId &&
                      nv.NhanVienId == hd.NhanVienId
                      select new
                      {
                          hd.HoaDonId,
                          hd.Ngay,
                          nv.TenNhanVien,
                          kh.KhachHangId,
                          kh.TenKhachHang,
                          hd.TongTien
                      };
            return hds.ToDataTable();
        }
        public DataTable getHoaDonCTTheoKH(int KhachHangId)
        {
            var hds = from hd in context.HoaDons
                      from nv in context.NhanViens
                      from ct in context.ChiTietHoaDons
                      from mh in context.MatHangs
                      where hd.KhachHangId == KhachHangId && ct.HoaDonId == hd.HoaDonId
                      && mh.MatHangId == ct.MatHangId && nv.NhanVienId == hd.NhanVienId
                      select new
                      {
                          hd.HoaDonId,
                          nv.TenNhanVien,
                          mh.TenMatHang,
                          mh.GiaBan,
                          ct.SoLuong,
                          mh.DonViTinh,
                          ct.DonGia
                      };
            return hds.ToDataTable();
        }
        public void deleteAll()
        {
            var tmp = getHoaDonList();
            tmp.ForEach(s => context.HoaDons.Remove(s));
            context.SaveChanges();
        }
        public DataTable getHoaDonTheoNgay(DateTime ngay)
        {
            var hds = from hd in context.HoaDons
                      from nv in context.NhanViens
                      from kh in context.KhachHangs
                      where hd.KhachHangId == kh.KhachHangId &&
                      hd.Ngay==ngay &&
                      nv.NhanVienId == hd.NhanVienId
                      select new
                      {
                          hd.HoaDonId,
                          hd.Ngay,
                          nv.TenNhanVien,
                          kh.TenKhachHang,
                          hd.TongTien
                      };
            return hds.ToDataTable();
        }
        public DataTable getCTHoaDonTheoId(int hoaDonId)
        {
            var hds =
                      (from ct in context.ChiTietHoaDons
                      from mh in context.MatHangs
                      where mh.MatHangId == ct.MatHangId && ct.HoaDonId==hoaDonId
                      select new
                      {
                          mh.TenMatHang,
                          mh.DonViTinh,
                          mh.GiaBan,
                          ct.SoLuong,
                          ct.DonGia
                      }).Distinct();
            return hds.ToDataTable();
        }
        public DataTable getHoaDonTheoKH(int KhachHangId)
        {
            var hds = from hd in context.HoaDons
                      from nv in context.NhanViens
                      from kh in context.KhachHangs
                      where hd.KhachHangId == kh.KhachHangId && 
                      kh.KhachHangId==KhachHangId&&
                      nv.NhanVienId == hd.NhanVienId
                      select new
                      {
                          hd.HoaDonId,
                          hd.Ngay,
                          nv.TenNhanVien,
                          kh.TenKhachHang,
                          hd.TongTien
                      };
            return hds.ToDataTable();
        }
        public bool insertHoaDon(
            DateTime Ngay, int MaKH, int MaNV, Decimal TongTien)
        {
            bool f = false;
            try
            {
                context.HoaDons.Add(
                    new HoaDon
                    {
                        Ngay = Ngay,
                        KhachHangId = MaKH,
                        NhanVienId = MaNV,
                        TongTien = TongTien
                    });
                context.SaveChanges();
                f = true;
            }
            catch { }
            return f;
        }
        public bool deleteHoaDon(int MaHD)
        {
            bool f = false;
            try
            {
                HoaDon hd = context.HoaDons.Find(MaHD);
                context.HoaDons.Remove(hd);
                context.SaveChanges();
                f = true;
            }
            catch { }
            return f;
        }
        public bool updateHoaDon(int MaHD, DateTime Ngay, int MaKH,
            int MaNV, Decimal TongTien)
        {
            bool f = false;
            try
            {
                HoaDon hd = context.HoaDons.Find(MaHD);
                hd.Ngay = Ngay;
                hd.KhachHangId = MaKH;
                hd.NhanVienId = MaNV;
                hd.TongTien = TongTien;
                context.SaveChanges();
                f = true;
            }
            catch { }
            return f;
        }
        public bool insertCTHoaDon(int MaHD, int MaHang, int SoLuong, Decimal DonGia)
        {
            bool f = false;
            try
            {
                context.ChiTietHoaDons.Add(new ChiTietHoaDon
                {
                    HoaDonId = MaHD,
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
        //public int getSoLuong(string maMH)
        //{
        //    try
        //    {
        //        var xhang = from ct in context.ChiTietHoaDons
        //                    from px in context.HoaDons
        //                    where ct.MatHangId == Convert.ToInt32(maMH)
        //                    && ct.HoaDonId == px.HoaDonId
        //                    select ct.SoLuong;
        //        return Convert.ToInt32(xhang.Sum(s => s));
        //    }
        //    catch { }
        //    return 0;
        //}
    }
}
