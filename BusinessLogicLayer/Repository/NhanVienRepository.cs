using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DataAccessLayer;
using DataAccessLayer.Models;
namespace BusinessLogicLayer.Repository
{
    public class NhanVienRepository
    {
        Context context = new Context();
        public int Count()
        {
            return context.NhanViens.Count();
        }
        public string getTenNhanVien(int NhanVienId)
        {
            return context.NhanViens.Where(w => w.NhanVienId == NhanVienId)
                .Select(s => s.TenNhanVien).SingleOrDefault();
        }
        public NhanVien getUser(int NhanVienId)
        {
            return context.NhanViens.Find(NhanVienId);
        }
        public bool isAdmin(int NhanVienId)
        {
            return context.NhanViens.Where(w => w.NhanVienId == NhanVienId)
                .Select(s => s.Admin).SingleOrDefault();
        }
        public bool updateDangNhap(string txtOldPW,int NhanVienId, string txtNewPW)
        {
            bool f = false;
            try {
                NhanVien nv = context.NhanViens.Find(NhanVienId);
                if (checkDangNhap(NhanVienId, txtOldPW))
                {
                    nv.Password = txtNewPW;
                    context.SaveChanges();
                    f = true;
                }
                else f = false;
            }
            catch { }
            return f;
        }

        public bool checkDangNhap(int NhanVienId, string password)
        {
            bool f = false;
            try
            {
                int check = context.NhanViens.Where
                    (w => w.NhanVienId == NhanVienId && w.Password == password)
                    .Count();
                if (check == 1)
                    f =true;
            }
            catch { }
            return f;
        }
        public List<NhanVien> getNhanVienList()
        {
            return context.NhanViens.ToList();
        }
        public DataTable getNhanVien()
        {
            var t =
                   from nv in context.NhanViens
                   from lnv in context.ChucVus
                   where nv.ChucVuId == lnv.ChucVuId
                   select new
                   {
                       nv.NhanVienId,
                       nv.TenNhanVien,
                       lnv.TenChucVu,
                       nv.GioiTinh,
                       nv.DiaChi,
                       nv.Email,
                       nv.SDT,
                       nv.Admin,
                       nv.Password,
                       nv.Luong
                   };
            return t.ToDataTable();
        }

        public void deleteAll()
        {
            var tmp = getNhanVienList();
            tmp.ForEach(s => context.NhanViens.Remove(s));
            context.SaveChanges();
        }
        public bool deleteNhanVien(int NhanVienId)
        {
             bool f = false;
             try
             {
                 NhanVien nv = new NhanVien();
                 nv = context.NhanViens.Find(NhanVienId);
                 context.NhanViens.Remove(nv);
                 context.SaveChanges();
                 f = true;
             }
             catch { }
             return f;
        }
        public int CountAdmin()
        {
            return context.NhanViens.Where(w => w.Admin == true).Count();
        }
        public int getChucVuId(int NhanVienId)
        {
            return context.NhanViens.Where(w => w.NhanVienId == NhanVienId)
                .Select(s => s.ChucVuId).SingleOrDefault();
        }
        public bool updateNhanVien(int NhanVienId, int ChucVuId, string TenNhanVien, string GioiTinh,
            string DiaChi, string Email, string SDT, string Pass, decimal Luong, bool Admin = false)
        {
             bool f = false;
             try
             {
                 NhanVien nv = new NhanVien();
                 nv = context.NhanViens.Find(NhanVienId);
                 nv.TenNhanVien = TenNhanVien;
                 nv.GioiTinh = GioiTinh;
                 nv.DiaChi = DiaChi;
                 nv.Email = Email;
                 nv.SDT = SDT;
                 nv.Admin = Admin;
                 nv.Password = Pass;
                 nv.ChucVuId = ChucVuId;
                 nv.Luong = Luong;
                 context.SaveChanges();
                 f = true;
             }
             catch { }
             return f;
        }
        public bool insertNhanVien(int ChucVuId, string TenNhanVien, string GioiTinh,
            string DiaChi, string Email, string SDT,bool Admin, string Password, decimal Luong)
        {
             bool f = false;
             try
             {
                 context.NhanViens.Add(new NhanVien
                 {
                     TenNhanVien = TenNhanVien,
                     GioiTinh = GioiTinh,
                     DiaChi = DiaChi,
                     Email = Email,
                     SDT = SDT,
                     Admin=Admin,
                     Password=Password,
                     ChucVuId = ChucVuId,
                     Luong = Luong,
                 });
                 context.SaveChanges();
                 f = true;
             }
             catch { }
             return f;
        }
    }
}
