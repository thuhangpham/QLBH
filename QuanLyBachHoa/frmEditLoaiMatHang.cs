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
    public partial class frmEditLoaiMatHang : Form
    {
        BaseBLL bll = new BaseBLL();
        public bool edit = false;
        public string maNH = "";
        public frmEditLoaiMatHang()
        {
            InitializeComponent();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (!edit)
            {
                if (txtTenNhomHang.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Vui lòng nhập tên nhóm hàng...", "Cảnh báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtTenNhomHang.Focus();
                    return;
                }
                bll.NhomHang.insertNhomHang(txtTenNhomHang.Text);
                MessageBox.Show("Thêm nhóm hàng thành công!", "Thông báo");
                this.Close();
            }
            else
            {
                bll.NhomHang.updateNhomHang(int.Parse(maNH), txtTenNhomHang.Text);
                MessageBox.Show("Sửa nhóm hàng thành công!", "Thông báo");
                this.Close();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
