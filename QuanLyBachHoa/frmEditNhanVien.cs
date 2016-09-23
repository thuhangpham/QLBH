using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogicLayer.BaseBLL;
namespace QuanLyBachHoa
{
    public partial class frmEditNhanVien : Form
    {
        BaseBLL bll = new BaseBLL();
        public bool edit = false;
        public string cv, gt="Nu";
        public frmEditNhanVien()
        {
            InitializeComponent();
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtTenNV.Text.Trim().Length == 0)
            {
                lblIncorrect.Text = "Vui lòng nhập Tên nhân viên!";
                txtTenNV.Focus();
                return;
            }
            if (txtSDT.Text.Trim().Length == 0)
            {
                lblIncorrect.Text = "Vui lòng nhập Số điện thoại!";
                txtSDT.Focus();
                return;
            }
            if (txtLuong.Text.Trim().Length == 0)
            {
                lblIncorrect.Text = "Vui lòng nhập lương!";
                txtLuong.Focus();
                return;
            }
            if (edit)
            {
                try
                {
                    if(bll.NhanVien.updateNhanVien(int.Parse(txtMaNV.Text.ToString()),
                        int.Parse(cbCV.SelectedValue.ToString()), 
                        txtTenNV.Text, cbGT.SelectedItem.ToString(),
                      txtDiaChi.Text, txtEmail.Text,
                      txtSDT.Text,txtPass.Text,
                      decimal.Parse(txtLuong.Text),cbAdmin.Checked))
                    MessageBox.Show("Sửa nhân viên thành công!!!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else MessageBox.Show("Sửa nhân viên lỗi!!!", "Error",
                       MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    if(bll.NhanVien.insertNhanVien(
                        int.Parse(cbCV.SelectedValue.ToString()), 
                        txtTenNV.Text, cbGT.SelectedItem.ToString(),
                      txtDiaChi.Text, txtEmail.Text, txtSDT.Text, 
                      cbAdmin.Checked,txtPass.Text,
                      decimal.Parse(txtLuong.Text)))
                    MessageBox.Show("Thêm Nhân viên thành công!!!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else MessageBox.Show("Thêm Nhân viên lỗi!!!", "Error",
                     MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
                catch { }
            }
        }
        void DataBind()
        {
            DataSet ds = new DataSet();
            cbCV.DataSource = bll.ChucVu.getChucVu();
            cbCV.ValueMember = "ChucVuId";
            cbCV.DisplayMember = "TenChucVu";
            cbGT.SelectedItem = gt.Trim();
            try
            {
                cbCV.SelectedValue = bll.ChucVu.getChucVuId(cv);
            }
            catch { }

        }
        private void frmEditNhanVien_Load(object sender, EventArgs e)
        {
            txtTenNV.Focus();
            DataBind();
            cbGT.SelectedItem = gt;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
