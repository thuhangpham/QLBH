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
    public class MatHangRepository
    {
        Context context = new Context();
        public int Count()
        {
            return context.MatHangs.Count();
        }
        public List<MatHang> getMatHangList()
        {
            return context.MatHangs.ToList();
        }
        public DataTable getMatHang()
        {
            var t =
                   from mh in context.MatHangs
                   from lmh in context.NhomHangs
                   where mh.NhomHangId == lmh.NhomHangId
                   select new
                   {
                       mh.MatHangId,
                       mh.TenMatHang,
                       mh.DonViTinh,
                       mh.GiaBan,
                       lmh.TenNhom,
                       mh.GhiChu,
                   };
            //var dt = new DataTable();
            //dt.Columns.Add(new DataColumn("MatHangId"));
            //dt.Columns.Add(new DataColumn("TenMatHang"));
            //dt.Columns.Add(new DataColumn("DonViTinh"));
            //dt.Columns.Add(new DataColumn("GiaBan"));
            //dt.Columns.Add(new DataColumn("TenNhom"));
            //dt.Columns.Add(new DataColumn("GhiChu"));
            //foreach (var mh in t.ToList())
            //{
            //    dt.LoadDataRow(new object[] {
            //      mh.MatHangId,
            //           mh.TenMatHang,
            //           mh.DonViTinh,
            //           mh.GiaBan,
            //           mh.TenNhom,
            //           mh.GhiChu,
            //    }, true);
            //}
            return t.ToDataTable();
        }

        public DataTable getMatHangTheoLmh(int NhomHangId)
        {
            var mhs = from mh in context.MatHangs
                      from nh in context.NhomHangs
                      where mh.NhomHangId == NhomHangId && nh.NhomHangId == NhomHangId
                      select new
                        {
                            mh.MatHangId,
                            mh.TenMatHang,
                            mh.DonViTinh,
                            mh.GiaBan,
                            nh.TenNhom,
                            mh.GhiChu,
                        };
            return mhs.ToDataTable();
        }
        public bool deleteMatHang(int MatHangId)
        {
            bool f = false;
            try
            {
                MatHang mh = new MatHang();
                mh = context.MatHangs.Find(MatHangId);
                context.MatHangs.Remove(mh);
                context.SaveChanges();
                f = true;
            }
            catch { }
            return f;
        }
        public void deleteAll()
        {
            var tmp = getMatHangList();
            tmp.ForEach(s => context.MatHangs.Remove(s));
            context.SaveChanges();
        }
        public bool updateMatHang(int MatHangId, string TenMatHang, string DonViTinh, double TrongLuong,
             string HSD, int NuocSXId, int NhomHangId, decimal GiaNhap, decimal GiaBan, string GhiChu)
        {
            bool f = false;
            try
            {
                MatHang mh = new MatHang();
                mh = context.MatHangs.Find(MatHangId);
                mh.TenMatHang = TenMatHang;
                mh.DonViTinh = DonViTinh;
                mh.GiaBan = GiaBan;
                mh.GiaNhap = GiaNhap;
                mh.HSD = HSD;
                mh.TrongLuong = TrongLuong;
                mh.NuocSXId = NuocSXId;
                mh.NhomHangId = NhomHangId;
                mh.GhiChu = GhiChu;
                context.SaveChanges();
                f = true;
            }
            catch { }
            return f;
        }
        public bool insertMatHang(string TenMatHang, string DonViTinh, double TrongLuong,
             string HSD, int NuocSXId, int NhomHangId, decimal GiaNhap, decimal GiaBan, string GhiChu)
        {
            bool f = false;
            try
            {
                context.MatHangs.Add(new MatHang
                {
                    TenMatHang = TenMatHang,
                    DonViTinh = DonViTinh,
                    GiaBan = GiaBan,
                    GiaNhap = GiaNhap,
                    HSD = HSD,
                    TrongLuong = TrongLuong,
                    NuocSXId = NuocSXId,
                    NhomHangId = NhomHangId,
                    GhiChu = GhiChu,
                });
                context.SaveChanges();
                f = true;
            }
            catch { }
            return f;
        }
        public DataTable getMatHangNhap()
        {
            var t =
                  from mh in context.MatHangs
                  from lmh in context.NhomHangs
                  where mh.NhomHangId == lmh.NhomHangId
                  select new
                  {
                      mh.MatHangId,
                      mh.TenMatHang,
                      mh.DonViTinh,
                      mh.GiaNhap,
                      lmh.TenNhom,
                      mh.GhiChu,
                  };
            //var dt = new DataTable();
            //dt.Columns.Add(new DataColumn("MatHangId"));
            //dt.Columns.Add(new DataColumn("TenMatHang"));
            //dt.Columns.Add(new DataColumn("DonViTinh"));
            //dt.Columns.Add(new DataColumn("GiaNhap"));
            //dt.Columns.Add(new DataColumn("TenNhom"));
            //dt.Columns.Add(new DataColumn("GhiChu"));
            //foreach (var mh in t.ToList())
            //{
            //    dt.LoadDataRow(new object[] {
            //      mh.MatHangId,
            //           mh.TenMatHang,
            //           mh.DonViTinh,
            //           mh.GiaNhap,
            //           mh.TenNhom,
            //           mh.GhiChu,
            //    }, true);
            //}
            return t.ToDataTable();
        }
        public DataTable getMatHangXuat()
        {
            var t =
                  from mh in context.MatHangs
                  select new
                  {
                      mh.MatHangId,
                      mh.TenMatHang,
                      mh.DonViTinh,
                      mh.GiaNhap,
                      mh.GiaBan,
                      mh.GhiChu,
                  };
            return t.ToDataTable();
        }
        public DataTable getMatHangTheoNhomXuat(int NhomHangId)
        {
            var t =
              from mh in context.MatHangs
              from lmh in context.NhomHangs
              where mh.NhomHangId == NhomHangId
              select new
              {
                  mh.MatHangId,
                  mh.TenMatHang,
                  mh.DonViTinh,
                  mh.GiaNhap,
                  mh.GiaBan,
                  mh.GhiChu,
              };
            return t.ToDataTable();
        }
        public DataTable getMatHangTheoNhomNhap(int NhomHangId)
        {
            var t =
             from mh in context.MatHangs
             from lmh in context.NhomHangs
             where mh.NhomHangId == NhomHangId
             select new
             {
                 mh.MatHangId,
                 mh.TenMatHang,
                 mh.DonViTinh,
                 mh.GiaNhap,
                 mh.GhiChu,
             };
            return t.ToDataTable();
        }
        public DataTable getMatHangFull()
        {
            var t =
            from mh in context.MatHangs
            from lmh in context.NhomHangs
            from nsx in context.NuocSanXuat
            where mh.NhomHangId == lmh.NhomHangId &&
            mh.NuocSXId == nsx.NuocSXId
            select new
            {
                mh.MatHangId,
                mh.TenMatHang,
                mh.DonViTinh,
                mh.GiaNhap,
                mh.GiaBan,
                mh.TrongLuong,
                mh.HSD,
                nsx.TenNuoc,
                lmh.TenNhom,
                mh.GhiChu,
            };
            return t.ToDataTable();
        }
        public DataTable getMatHangTheoNhomHangFull(int NhomHangId)
        {
            var t =
           from mh in context.MatHangs
           from lmh in context.NhomHangs
           from nsx in context.NuocSanXuat
           where mh.NhomHangId == lmh.NhomHangId &&
           mh.NuocSXId == nsx.NuocSXId && mh.NhomHangId == NhomHangId
           select new
           {
               mh.MatHangId,
               mh.TenMatHang,
               mh.DonViTinh,
               mh.GiaNhap,
               mh.GiaBan,
               mh.TrongLuong,
               mh.HSD,
               nsx.TenNuoc,
               lmh.TenNhom,
               mh.GhiChu,
           };
            return t.ToDataTable();
        }
        public DataTable getMatHangSearch(string strMH)
        {
            var t = from mh in context.MatHangs
                    from nh in context.NhomHangs
                    where mh.TenMatHang.Contains(strMH) && mh.NhomHangId == nh.NhomHangId
                    select new { mh.MatHangId,mh.TenMatHang,
                        mh.DonViTinh,mh.GiaBan,nh.TenNhom,mh.GhiChu};

            return t.ToDataTable();
        }
        public DataTable getMatHangSearchNhap(string strMH)
        {
            var t =
          from mh in context.MatHangs
          from lmh in context.NhomHangs
          where mh.NhomHangId == lmh.NhomHangId && mh.TenMatHang.Contains(strMH)
          select new
          {
              mh.MatHangId,
              mh.TenMatHang,
              mh.DonViTinh,
              mh.GiaNhap,
              lmh.TenNhom,
              mh.GhiChu,
          };
            return t.ToDataTable();
        }
        public bool updateMatHangGiaNhap(int MatHangId, decimal GiaNhap)
        {
            bool f = false;
            try
            {
                MatHang mh = context.MatHangs.Find(MatHangId);
                mh.GiaNhap = GiaNhap;
                context.SaveChanges();
                f = true;
            }
            catch { }
            return f;
        }
        public bool updateMatHangGiaBan(int MatHangId, decimal GiaBan)
        {
            bool f = false;
            try
            {
                MatHang mh = context.MatHangs.Find(MatHangId);
                mh.GiaBan = GiaBan;
                context.SaveChanges();
                f = true;
            }
            catch { }
            return f;
        }


    }
}
