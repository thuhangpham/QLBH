using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLogicLayer.Repository;
using DataAccessLayer.Models;

namespace BusinessLogicLayer.BaseBLL
{
    public class BaseBLL
    {
        #region Các thuộc tính truy cập cơ sở dữ liệu
        /// <summary>
        /// danh sách các chức năng trên form - thêm, xoá, sửa, truy vấn, 
        /// </summary>
        public ChucVuRepository ChucVu { get; set; }
        public HoaDonRepository HoaDon { get; set; }
        public KhachHangRepository KhachHang { get; set; }
        public LoaiKhachHangRepository LoaiKhachHang { get; set; }
        public NhomHangRepository NhomHang {get;set;}
        public MatHangRepository MatHang { get; set; }
        public NuocSanXuatRepository NuocSanXuat { get; set; }
        public NhaCungCapRepository NhaCungCap { get; set; }
        public NhanVienRepository NhanVien { get; set; }
        public PhieuKiemKeRepository PhieuKiemKe { get; set; }
        public PhieuNhapRepository PhieuNhap { get; set; }
        public PhieuXuatRepository PhieuXuat { get; set; }
         #endregion Các thuộc tính truy cập cơ sở dữ liệu
        /// <summary>
        /// Khởi tạo các thuộc tính truy cập cơ sở dữ liệu
        /// </summary>
        public BaseBLL()
        {
            ChucVu = new ChucVuRepository();
            HoaDon = new HoaDonRepository();
            KhachHang = new KhachHangRepository();
            LoaiKhachHang = new LoaiKhachHangRepository();
            NhomHang=new NhomHangRepository();
            MatHang = new MatHangRepository();
            NuocSanXuat = new NuocSanXuatRepository();
            NhaCungCap = new NhaCungCapRepository();
            NhanVien = new NhanVienRepository();
            PhieuKiemKe = new PhieuKiemKeRepository();
            PhieuNhap = new PhieuNhapRepository();
            PhieuXuat = new PhieuXuatRepository();
            // 
        }
           #region Các phương thức tĩnh
        /// <summary>
        /// Tự động tạo dữ liễu mẫu
        /// </summary>
        /// <param name="isDelete"></param>
        public static void CreateData()
        {
            var bll = new BaseBLL();
            // NẾU ĐÃ TẠO THÌ KO TẠO NỮA
            if (bll.NhanVien.Count() > 0) return;
            bll.createAll();
        }
        #endregion
        #region Tạo dữ liệu mẫu
        void createChucVu()
        {
            if(ChucVu.Count()>0) return;
            ChucVu.insertChucVu("Quan Ly");
            ChucVu.insertChucVu("Ban Hang");
            ChucVu.insertChucVu("Kiem Ke");
            ChucVu.insertChucVu("Quan Kho");
        }
          void createLoaiKhachHang()
        {
            if(LoaiKhachHang.Count()>0) return;
              LoaiKhachHang.insertLoaiKhachHang("Thanh vien","");
              LoaiKhachHang.insertLoaiKhachHang("Vip","");
              LoaiKhachHang.insertLoaiKhachHang("Chua Thiet Lap","");
        }
        void createKhachHang()
        {
            if(KhachHang.Count()>0) return;
            KhachHang.insertKhachHang("Le Thi Mai","Nu","123, Le Thi Rieng","123@gmail.com","08298493",1,"");
            KhachHang.insertKhachHang("Le Van Dang","Nam","123, Le Thi Rieng","123@gmail.com","08298493",1,"");
            KhachHang.insertKhachHang("Tran Hong Mai","Nu","123, Le Thi Rieng","123@gmail.com","08298493",1,"");
            KhachHang.insertKhachHang("Nguyen Anh Nhan","Nam","123, Le Thi Rieng","123@gmail.com","08298493",1,"");
            KhachHang.insertKhachHang("Le Thi Mai","Nu","123, Le Thi Rieng","123@gmail.com","08298493",1,"");
            KhachHang.insertKhachHang("Tran Dinh Hung","Nam","TT Hue","123@gmail.com","08298493",2,"");
            KhachHang.insertKhachHang("Le Thi Mai","Nu","123, Le Thi Rieng","123@gmail.com","08298493",3,"");
            KhachHang.insertKhachHang("Lam Van Nguyen","Nam","Q12","123@gmail.com","08298493",3,"");
            KhachHang.insertKhachHang("Lam Khanh Tai","Nam","Binh Duong","123@gmail.com","08298493",2,"");
            KhachHang.insertKhachHang("Nguyen Hong Hoa","Nu","Binh Thanh","123@gmail.com","08298493",2,"");
        }
        void createNhomHang()
        {
            if(NhomHang.Count()>0) return;
            NhomHang.insertNhomHang("Thuc pham");
            NhomHang.insertNhomHang("Do gia dung");
            NhomHang.insertNhomHang("Ta-Giay");
            NhomHang.insertNhomHang("Hoa-My pham");
        }
        void createNuocSX()
        {
            if(NuocSanXuat.Count()>0)return;
            NuocSanXuat.insertNuocSanXuat("Thai Lan");
            NuocSanXuat.insertNuocSanXuat("Viet Nam");
            NuocSanXuat.insertNuocSanXuat("Trung Quoc");
            NuocSanXuat.insertNuocSanXuat("Nhat Ban");
            NuocSanXuat.insertNuocSanXuat("Nga");
        }
        void createMatHang()
        {
            if(MatHang.Count()>0)return;
            MatHang.insertMatHang("Hao hao","Goi",65,"1 nam",1,1,5000,5500,"");
            MatHang.insertMatHang("Pho","Goi",65,"1 nam",1,1,6000,6500,"");
            MatHang.insertMatHang("Dầu ăn","Chai",65,"1 nam",1,1,15000,17500,"");
            MatHang.insertMatHang("Nước mắm","Chai",200,"1 nam",1,1,20000,20500,"");
            MatHang.insertMatHang("kokomi","Goi",65,"1 nam",4,1,5000,5500,"");
            MatHang.insertMatHang("Sữa tươi","Goi",200,"1 nam",4,1,15000,16000,"");
            MatHang.insertMatHang("Chổi", "Cây", 700, "1 nam", 2, 2, 26000, 2700, "");
            MatHang.insertMatHang("Cây lau nhà", "Cây", 1000, "1 nam", 2, 2, 6000, 6500, "");
            MatHang.insertMatHang("Sữa chua", "Hộp", 70, "1 nam", 5, 1, 6000, 6500, "");
            MatHang.insertMatHang("Khăn giấy","Goi",100,"1 nam",4,3,7000,8500,"");
            MatHang.insertMatHang("Khăn ướt","Goi",100,"1 nam",4,3,5000,5500,"");
            MatHang.insertMatHang("Kem chống nắng","Chai",65,"1 nam",3,4,55000,56500,"");
            MatHang.insertMatHang("Sữa rửa mặt","Goi",65,"1 nam",2,4,5000,5500,"");
        }
        void createNhanVien()
        {
            if(NhanVien.Count()>0) return;
            NhanVien.insertNhanVien(1,"Pham Thi Thu Hang","Nu","TT Hue","thuhangpt06@gmail.com","01695597297",true,"123456",1200000);
            NhanVien.insertNhanVien(2,"Huynh Thi Tham","Nu","Binh Dinh","24@gmail.com","09837821",false,"", 5600000);
            NhanVien.insertNhanVien(3,"Ho Thi Truc Vy","Nu","Binh Thuan","24@gmail.com","034543421",false,"",7000000);
            NhanVien.insertNhanVien(4,"Nguyen Van A","Nam","Binh Thuan","24@gmail.com","027423221",false,"",7000000);
        }
        void createNhaCungCap()
        {
            if(NhaCungCap.Count()>0) return;
            NhaCungCap.insertNhaCungCap("Thanh Tin","Quang Nam","tintt@gmail.com","09872383","");
            NhaCungCap.insertNhaCungCap("Thao","Thanh Hoa","thao@gmail.com","09872383","");
        }
        #endregion Tạo dữ liệu mẫu
        
        /// <summary>
        /// Xóa tất cả
        /// </summary>
        void deleteAll()
        {
            ChucVu.deleteAll();
            KhachHang.deleteAll();
            LoaiKhachHang.deleteAll();
            MatHang.deleteAll();
            NhaCungCap.deleteAll();
            NhomHang.deleteAll();
            //NuocSanXuat.deleteAll();
            NhanVien.deleteAll();
        }
        /// <summary>
        /// Tạo mới tất cả
        /// </summary>
        void createAll()
        {
            createChucVu();
            createLoaiKhachHang();
            createKhachHang();
            createNhomHang();
            createNuocSX();
            createMatHang();
            createNhanVien();
            createNhaCungCap();
        }
    }
}
