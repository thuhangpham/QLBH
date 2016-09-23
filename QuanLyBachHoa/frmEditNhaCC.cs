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
    public partial class frmEditNhaCC : Form
    {
        BaseBLL bll = new BaseBLL();
        public bool edit = false;
        public frmEditNhaCC()
        {
            InitializeComponent();
        }

        private void frmEditNhaCC_Load(object sender, EventArgs e)
        {

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {

            if (txtTenNCC.Text.Trim().Length == 0)
            {
                lblIncorrect.Text = "Vui lòng nhập Tên nhà cung cấp!";
                txtTenNCC.Focus();
                return;
            }
            if (txtDiaChi.Text.Trim().Length == 0)
            {
                lblIncorrect.Text = "Vui lòng nhập Địa chỉ!";
                txtDiaChi.Focus();
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
                    if (bll.NhaCungCap.updateNhaCungCap(int.Parse(txtMaNCC.Text), txtTenNCC.Text,
                       txtDiaChi.Text, txtEmail.Text, txtSDT.Text, txtGC.Text))
                        MessageBox.Show("Sửa Nhà cung cấp thành công!!!", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else MessageBox.Show("Lỗi!!!","Error");

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
                    if(bll.NhaCungCap.insertNhaCungCap(txtTenNCC.Text,
                        txtDiaChi.Text, txtEmail.Text, txtSDT.Text, txtGC.Text))
                    {
                        MessageBox.Show("Thêm Nhà cung cấp thành công!!!", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else MessageBox.Show("Thêm Nhà cung cấp lỗi!!!", "Error",
                           MessageBoxButtons.OK, MessageBoxIcon.Error );
                }
                catch { }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtTenNCC_KeyPress(object sender, KeyPressEventArgs e)
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
                txtGC.Focus();
        }

        private void txtGC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                btnLuu.Focus();
        }
    }
}
