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
    public class PhieuKiemKeRepository
    {
        Context context = new Context();
        public int Count()
        {
            return context.PhieuKiemKes.Count();
        }
        public DataTable getPhieuKiemKe()
        {
            var cts = from ct in context.PhieuKiemKes
                      from nv in context.NhanViens
                      where ct.NhanVienId == nv.NhanVienId
                      select new { ct.PhieuKiemKeId,ct.NgayKK, nv.TenNhanVien,ct.GhiChu };
            //var dt = new DataTable();
            //dt.Columns.Add("PhieuKiemKeId");
            //dt.Columns.Add("NgayKK");
            //dt.Columns.Add("TenNhanVien");
            //dt.Columns.Add("GhiChu");
            //foreach (var item in cts)
            //    dt.LoadDataRow(new object[]{
            //        item.ct.PhieuKiemKeId,
            //        item.ct.NgayKK,
            //       item.nv.TenNhanVien,
            //       item.ct.GhiChu
            //    }, true);
            return cts.ToDataTable();
        }
        public DataTable getCTPhieuKiemKe(int MaPKK)
        {
            var cts = from ct in context.ChiTietPhieuKiemKes
                      from mh in context.MatHangs
                      where ct.MatHangId == mh.MatHangId && ct.PhieuKiemKeId == MaPKK
                      select new
                      {
                          mh.TenMatHang,
                          mh.GiaBan,
                          ct.SLNhap,
                          ct.SLXuat,
                          ct.SLBan,
                          ct.SLTon,
                          ct.SLTrenQuay,
                          ct.GhiChu,
                      };
            return cts.ToDataTable();
        }

        public bool insertPhieuKiemKe(DateTime NgayKK,
                                          int MaNV, string GhiChu)
        {
            bool f = false;
            try
            {
                context.PhieuKiemKes.Add(new PhieuKiemKe
                {
                    NgayKK = NgayKK,
                    NhanVienId = MaNV,
                    GhiChu = GhiChu
                });
                context.SaveChanges();
                f = true;
            }
            catch { }
            return f;
        }

        public bool deletePhieuKiemKe(int MaPKK)
        {
            bool f = false;
            try
            {
                context.PhieuKiemKes.Remove(context.PhieuKiemKes.Find(MaPKK));
                context.SaveChanges();
                f = true;
            }
            catch { }
            return f;
        }
        public bool updatePhieuKiemKe(int MaPKK, DateTime NgayKK,
                                          int MaNV, string GhiChu)
        {
            bool f = false;
            try
            {
                PhieuKiemKe pkk = context.PhieuKiemKes.Find(MaPKK);
                pkk.NgayKK = NgayKK;
                pkk.NhanVienId = MaNV;
                pkk.GhiChu = GhiChu;
                context.SaveChanges();
                f = true;
            }
            catch { }
            return f;
        }
        /// <summary>
        /// Chi tiet phieu kiem ke
        /// </summary>
        /// <param name="MaPKK"></param>
        /// <param name="MaHang"></param>
        /// <param name="SLNhap"></param>
        /// <param name="SLXuat"></param>
        /// <param name="SLBan"></param>
        /// <param name="SLTon"></param>
        /// <param name="SLTrenQuay"></param>
        /// <param name="GhiChu"></param>
        public bool insertCTPhieuKiemKe(int MaPKK,
      int MaHang, int SLNhap, int SLXuat, int SLBan,
          int SLTon, int SLTrenQuay, string GhiChu)
        {
            bool f = false;
            try
            {
                context.ChiTietPhieuKiemKes.Add(new ChiTietPhieuKiemKe
                {
                    PhieuKiemKeId = MaPKK,
                    MatHangId = MaHang,
                    SLNhap = SLNhap,
                    SLXuat = SLXuat,
                    SLBan = SLBan,
                    SLTon = SLTon,
                    SLTrenQuay = SLTrenQuay,
                    GhiChu = GhiChu
                });
                context.SaveChanges();
                f = true;
            }
            catch { }
            return f;
        }

    }
}
