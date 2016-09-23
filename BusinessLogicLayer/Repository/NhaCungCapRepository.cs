using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using DataAccessLayer.Models;
using System.Data;

namespace BusinessLogicLayer.Repository
{
    public class NhaCungCapRepository
    {
        Context context = new Context();
        public int Count()
        {
            return context.NhaCungCaps.Count();
        }
        public DataTable getNhaCungCap()
        {
            return context.NhaCungCaps.ToList().ToDataTable();
        }
             
        public void deleteAll()
        {
            //DataTable tmp = getNhaCungCap();
            //int t=tmp.Rows.Count;
            //for (int i = 0; i < t;i++)
            //    tmp.Rows.RemoveAt(0);
            //context.SaveChanges();
        }
        public bool deleteNhaCungCap(int NhaCungCapId)
        {
             bool f = false;
             try
             {
                 NhaCungCap ncc = new NhaCungCap();
                 ncc = context.NhaCungCaps.Find(NhaCungCapId);
                 context.NhaCungCaps.Remove(ncc);
                 context.SaveChanges();
                 f = true;
             }
             catch { }
             return f;

        }
        public bool updateNhaCungCap(int NhaCungCapId, string TenNhaCungCap,
                   string DiaChi, string Email,
                   string SDT, string GhiChu)
        {
             bool f = false;
             try
             {
                 NhaCungCap ncc = new NhaCungCap();
                 ncc = context.NhaCungCaps.Find(NhaCungCapId);
                 ncc.TenNhaCungCap = TenNhaCungCap;
                 ncc.DiaChi = DiaChi;
                 ncc.Email = Email;
                 ncc.SDT = SDT;
                 ncc.GhiChu = GhiChu;
                 context.SaveChanges();
                 f = true;
             }
             catch { }
             return f;
        }
        public bool insertNhaCungCap(string TenNhaCungCap,
                   string DiaChi, string Email,
                   string SDT, string GhiChu)
        {
             bool f = false;
             try
             {
                 context.NhaCungCaps.Add(new NhaCungCap
                 {
                     TenNhaCungCap = TenNhaCungCap,
                     DiaChi = DiaChi,
                     Email = Email,
                     SDT = SDT,
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
