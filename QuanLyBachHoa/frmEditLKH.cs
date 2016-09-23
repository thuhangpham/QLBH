using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogicLayer.BaseBLL;
namespace QuanLyBachHoa
{
    public partial class frmEditLKH : Form
    {
        BaseBLL bll = new BaseBLL();
        public bool edit = false;
        public frmEditLKH()
        {
            InitializeComponent();
        }

        #region key Press
        private void txtMaKH_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                txtTenLKH.Focus();
        }

        private void txtTenKH_KeyPress(object sender, KeyPressEventArgs e)
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
        #endregion key Press
        //kiem tra da nhap day du thong tin
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtMaLKH.Text.Trim().Length == 0)
            {
                Corect.Text = "Vui lòng nhập Mã loại khách hàng!";
                txtMaLKH.Focus();
                return;
            }
            if (txtTenLKH.Text.Trim().Length == 0)
            {
                Corect.Text = "Vui lòng nhập Tên loại Khách hàng!";
                txtTenLKH.Focus();
                return;
            }
            if (edit)
            {
                try
                {
                    if(bll.LoaiKhachHang.updateLoaiKhachHang(int.Parse(txtMaLKH.Text),
                        txtTenLKH.Text, txtGC.Text))
                    MessageBox.Show("Sửa loại Khách hàng thành công!!!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else MessageBox.Show("Sửa loại Khách hàng lỗi!!!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error );
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                if (bll.LoaiKhachHang.insertLoaiKhachHang(txtTenLKH.Text, txtGC.Text))
                {
                    (new frmKhachHang()).tvLKH.Nodes.Add(txtTenLKH.Text);
                    (new frmKhachHang()).tvLKH.Refresh();
                    MessageBox.Show("Thêm Khách hàng thành công!!!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else MessageBox.Show("Thêm Khách hàng lỗi!!!", "Error",
                       MessageBoxButtons.OK, MessageBoxIcon.Error );
                this.Close();
            }
        }
        private void frmEditLKH_Load(object sender, EventArgs e)
        {
        }
    }
}

