using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using BusinessLogicLayer.BaseBLL;
using DataAccessLayer;
namespace QuanLyBachHoa
{
    // uy quyen thay doi gia tri textBox
    public delegate void SendStr(string tHang, string mHang);
    public partial class frmEditPhieuKiemKe : Form
    {
        private string filePath = Application.StartupPath + "\\User.dat";
        ReadAccount ra = new ReadAccount(); string[] contents;
        BaseBLL bll = new BaseBLL();
        Context context = new Context();
        public string maMH = "", tenMH = "";
        public frmEditPhieuKiemKe()
        {
            InitializeComponent();
        }
        private void DataBind()
        {
            cbNhanVien.DataSource = bll.NhanVien.getNhanVien();
            cbNhanVien.ValueMember = "NhanVienId";
            cbNhanVien.DisplayMember = "TenNhanVien";
            contents = ra.ReadFile(filePath);
            if (!bll.NhanVien.isAdmin(int.Parse(contents[0])))
            {
                cbNhanVien.SelectedValue = int.Parse(contents[0]);
                cbNhanVien.Enabled = false;
            }

        }

        private void frmEditPhieuKiemKe_Load(object sender, EventArgs e)
        {
            DataBind();
        }
        /// <summary>
        /// Tao phieu kiem ke cua 1 mat hang
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTaoPKK_Click(object sender, EventArgs e)
        {
            if (maMH.Trim().Length == 0)
            {
                MessageBox.Show("Vui lòng chọn mặt hàng! :)", "Cảnh báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int maPKK,
                   maNV = int.Parse(cbNhanVien.SelectedValue.ToString());
            if (dateTimePicker1.Enabled == false)
            {
                maPKK = context.PhieuKiemKes.Max(m => m.PhieuKiemKeId);
                //int t = context.ChiTietPhieuKiemKes.Where(w => w.PhieuKiemKeId == maPKK &&
                //    w.MatHangId == int.Parse(maMH)).Count();
                var check = context.ChiTietPhieuKiemKes.Where(w => w.PhieuKiemKeId == maPKK)
                    .Select(s => s.MatHangId).ToList();
                foreach (int mh in check)
                    if (mh == int.Parse(maMH))
                    {
                        MessageBox.Show("Mặt hàng đã được kiểm kê.\n " +
                            "Vui lòng chọn Mặt hàng khác!", "Cảnh báo");
                        return;
                    }
            }
            //Kiểm tra
            int slNhap = int.Parse(nudSLNhap.Value.ToString()),
                slXuat = int.Parse(nudSLXuat.Value.ToString()),
                slBan = int.Parse(nudSLBan.Value.ToString()),
                slTon = 0, slTrenQuay = 0;
            if (slNhap == 0 && slXuat == 0 && slBan == 0)
            {
                lblInConrrect.Text = "Vi lòng chọn số lượng -_- ";
                nudSLNhap.Focus(); return;
            }
            if (slNhap < slXuat)
            {
                lblInConrrect.Text = "Lỗi: Số lượng nhập >= Số lượng xuất. -_-";
                nudSLNhap.Focus(); return;
            }
            if (slXuat < slBan)
            {
                lblInConrrect.Text = "Lỗi: Số lượng xuất >= Số lượng bán.";
                nudSLXuat.Focus(); return;
            }
            if (slNhap < slBan + slXuat)
            {
                lblInConrrect.Text = "Lỗi: SL nhập >= SL xuất + SL bán.";
                nudSLXuat.Focus(); return;
            }
            slTon = slNhap - slXuat;
            slTrenQuay = slXuat - slBan;
            //--------------------------------------
            if (dateTimePicker1.Enabled == true)
            {
                if (bll.PhieuKiemKe.insertPhieuKiemKe
                    (DateTime.Parse(dateTimePicker1.Text),
                    maNV, txtGC.Text))
                {
                    maPKK = context.PhieuKiemKes.Max(m => m.PhieuKiemKeId);
                    if (bll.PhieuKiemKe.insertCTPhieuKiemKe(maPKK, int.Parse(maMH),
                        slNhap, slXuat, slBan, slTon, slTrenQuay, txtGC.Text))
                    {
                        MessageBox.Show("Tạo phiếu thành công!!!",
                           "Thông báo");
                        dateTimePicker1.Enabled = false;
                        cbNhanVien.Enabled = false;
                    }
                    else
                    {
                        bll.PhieuKiemKe.deletePhieuKiemKe(maPKK);
                        MessageBox.Show("Tạo phiếu lỗi!!!", "Lỗi");
                    }
                }
                else MessageBox.Show("Tạo phiếu lỗi!!!",
                      "Lỗi");
            }
            else
            {
                maPKK = context.PhieuKiemKes.Max(m => m.PhieuKiemKeId);
                if (bll.PhieuKiemKe.insertCTPhieuKiemKe(maPKK, int.Parse(maMH),
                    slNhap, slXuat, slBan, slTon, slTrenQuay, txtGC.Text))
                {
                    MessageBox.Show("Tạo phiếu thành công!!!",
                       "Thông báo");
                    dateTimePicker1.Enabled = false;
                    cbNhanVien.Enabled = false;
                }
                else
                {
                    bll.PhieuKiemKe.deletePhieuKiemKe(maPKK);
                    MessageBox.Show("Tạo phiếu lỗi!!!", "Lỗi");
                }
            }
        }
        private void btnSearchMH_Click(object sender, EventArgs e)
        {
            lblHethong.Text = "Tham khảo từ hệ thống";
            frmSearchMH frm = new frmSearchMH(SetValue);
            // Ta truyền hàm SetValue qua form 2, và 
            //form 2 khi nhấn nút button bên đó sẽ gọi lại phương thức SetValue
            // bên này
            frm.ShowDialog();
        }
        private void SetValue(String tHang, String mHang)
        {
            txtMH.Text = tHang;
            maMH = mHang;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //if (maMH.Trim().Length == 0)
            //{
            //    MessageBox.Show("Vui lòng chọn mặt hàng!", "Cảnh báo",
            //        MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return;
            //}
            //string err = "";
            //lblHethong.Text = "SL Nhập = " + bll.PhieuNhap.getSoLuong(ref err,maMH)
            //    + "; SL Xuất = " +bll.PhieuXuat.getSoLuong(maMH) +
            //    "; SL Bán = " + bll.HoaDon.getSoLuong(maMH);
            //MessageBox.Show(err);
        }

    }
}
