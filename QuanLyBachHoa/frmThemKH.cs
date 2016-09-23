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
namespace QuanLyBachHoa
{
    public partial class frmThemKH : Form
    {
        BaseBLL bll = new BaseBLL();
        frmKhachHang frmkh = new frmKhachHang();
        public bool edit = false;
        public string gt="Nu", lkh;
        public frmThemKH()
        {
            InitializeComponent();
        }
        //bool LoadKH()
        //{
        //    List<LoaiKhachHangRecycle> t = bll.LoaiKhachHangRecycle.
        //        getLoaiKhachHangRecycle();
        //    foreach (LoaiKhachHangRecycle n in t)
        //        if (n.LoaiKhachHangR == bll.LoaiKhachHang.getLoaiKhachHangId(lkh))
        //            return false;
        //    return true;
        //}
        private void btnLuu_Click(object sender, EventArgs e)
        {

            if (txtTenKH.Text.Trim().Length == 0)
            {
                lblIncorrect.Text = "Vui lòng nhập Tên Khách hàng!";
                txtTenKH.Focus();
                return;
            }
            if (txtSDT.Text.Trim().Length == 0)
            {
                lblIncorrect.Text = "Vui lòng nhập Số điện thoại!";
                txtSDT.Focus();
                return;
            }
            if (edit)
            {
                try
                {
                    if(bll.KhachHang.updateKhachHang(int.Parse(txtMaKH.Text), txtTenKH.Text, cbGT.SelectedItem.ToString(),
                             txtDiaChi.Text, txtEmail.Text, txtSDT.Text, int.Parse(cbLKH.SelectedValue.ToString()), txtGC.Text))
                    MessageBox.Show("Sửa Khách hàng thành công!!!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else MessageBox.Show("Sửa Khách hàng loi!!!", "Thông báo",
                     MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                try
                {
                    if(bll.KhachHang.insertKhachHang(txtTenKH.Text, cbGT.SelectedItem.ToString(),
                         txtDiaChi.Text, txtEmail.Text, txtSDT.Text,
                         int.Parse(cbLKH.SelectedValue.ToString()), txtGC.Text))
                    MessageBox.Show("Thêm Khách hàng thành công!!!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else MessageBox.Show("Thêm Khách hàng loi", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }
        }

        private void txtMaKH_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                txtTenKH.Focus();
        }

        private void txtTenKH_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                cbGT.Focus();
        }

        private void txtGT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                txtDiaChi.Focus();
        }

        private void txtDiaChi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                txtEmail.Focus();
        }

        private void txtEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                txtSDT.Focus();
        }

        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                cbLKH.Focus();
        }

        private void cbLKH_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                btnLuu.Focus();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void frmThemKH_Load(object sender, EventArgs e)
        {
            cbGT.SelectedItem = gt.Trim();
            //
            cbLKH.DataSource = bll.LoaiKhachHang.getLoaiKhachHang();
            cbLKH.DisplayMember = "TenLoaiKhachHang";
            cbLKH.ValueMember = "LoaiKhachHangId";
            cbLKH.SelectedValue = bll.LoaiKhachHang.getLoaiKhachHangId(lkh);
            txtMaKH.Enabled = false;
            //if (edit)
            //    cbLKH.Enabled = LoadKH();
        }
    }
}
