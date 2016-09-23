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
    public partial class frmEditMatHang : Form
    {
        BaseBLL bll = new BaseBLL();
        public bool edit = false;
        public string mnsx, nh;
        public frmEditMatHang()
        {
            InitializeComponent();
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {

            if (txtTenMH.Text.Trim().Length == 0)
            {
                lblIncorrect.Text = "Vui lòng nhập Tên mặt hàng!";
                txtTenMH.Focus();
                return;
            }
            if (txtGiaNhap.Text.Trim().Length == 0)
            {
                lblIncorrect.Text = "Vui lòng nhập giá nhập!";
                txtGiaNhap.Focus();
                return;
            }
            if (txtGiaBan.Text.Trim().Length == 0)
            {
                lblIncorrect.Text = "Vui lòng nhâp giá bán!";
                txtGiaBan.Focus();
                return;
            }
            if (txtDVT.Text.Trim().Length == 0)
            {
                lblIncorrect.Text = "Vui lòng nhập đơn vị tính!";
                txtDVT.Focus();
                return;
            }
            if (txtTrongLuong.Text.Trim().Length == 0)
            {
                lblIncorrect.Text = "Vui lòng nhập trọng lượng!";
                txtTrongLuong.Focus();
                return;
            }
            if (txtHSD.Text.Trim().Length == 0)
            {
                lblIncorrect.Text = "Vui lòng nhập hạn sử dụng!";
                txtHSD.Focus();
                return;
            }
            if (int.Parse(txtGiaNhap.Text)>int.Parse(txtGiaBan.Text))
            {
                lblIncorrect.Text = "Giá nhập phải <= giá bán!!!";
                txtGiaNhap.Focus();
                txtGiaBan.ResetText();
                return;
            }
            if (edit)
            {
                try
                {
                    bll.MatHang.updateMatHang(int.Parse(txtMaHang.Text.ToString()),
                        txtTenMH.Text, txtDVT.Text, double.Parse(txtTrongLuong.Text),
                        txtHSD.Text,
                        int.Parse(cbNuocSX.SelectedValue.ToString()),
                        int.Parse(cbNhomHang.SelectedValue.ToString())
                        , decimal.Parse(txtGiaNhap.Text), decimal.Parse(txtGiaBan.Text), txtGC.Text);
                        MessageBox.Show("Sửa mặt hàng thành công!!!", "Thông báo",
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
                    
                    bll.MatHang.insertMatHang(
                      txtTenMH.Text, txtDVT.Text, double.Parse(txtTrongLuong.Text), txtHSD.Text,
                      int.Parse(cbNuocSX.SelectedValue.ToString()),
                      int.Parse(cbNhomHang.SelectedValue.ToString())
                      , decimal.Parse(txtGiaNhap.Text), decimal.Parse(txtGiaBan.Text), txtGC.Text);
                        MessageBox.Show("Thêm mặt hàng thành công!!!", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                }
                catch { }
            }
        }
        void DataBind()
        {
            //
            cbNuocSX.DataSource = bll.NuocSanXuat.getNuocSanXuat();
            cbNuocSX.ValueMember = "NuocSXId";
            cbNuocSX.DisplayMember = "TenNuoc";
            //
            cbNhomHang.DataSource = bll.NhomHang.getNhomHang();
            cbNhomHang.DisplayMember = "TenNhom";
            cbNhomHang.ValueMember = "NhomHangId";
        }
        private void frmEditMatHang_Load(object sender, EventArgs e)
        {
            //
            DataBind();
            if (edit)
            {
                cbNhomHang.SelectedValue = bll.NhomHang.getNhomHangId(nh);
                cbNuocSX.SelectedValue = bll.NuocSanXuat.getNuocSanXuatId(mnsx);
            }
        }

        private void txtMaHang_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                txtTenMH.Focus();
        }

        private void txtTenMH_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                txtGiaNhap.Focus();
        }

        private void txtGiaNhap_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                txtGiaBan.Focus();
        }

        private void txtGiaBan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                cbNhomHang.Focus();
        }

        private void cbNhomHang_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                txtDVT.Focus();
        }

        private void txtDVT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                txtTrongLuong.Focus();
        }

        private void txtTrongLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                txtHSD.Focus();
        }

        private void txtHSD_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                cbNuocSX.Focus();
        }

        private void cbNuocSX_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                txtGC.Focus();
        }

        private void txtGC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                btnLuu.Focus();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtThemNuocSX_Click(object sender, EventArgs e)
        {
            (new frmEditNuocSX()).Show();
        }

        private void txtRefresh_Click(object sender, EventArgs e)
        {
            DataBind();
        }

    }
}
