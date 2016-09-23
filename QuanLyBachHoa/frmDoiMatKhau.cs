using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using BusinessLogicLayer.BaseBLL;
namespace QuanLyBachHoa
{
    public partial class frmDoiMatKhau : Form
    {
        BaseBLL bll = new BaseBLL();
        private string filePath = Application.StartupPath + "\\User.dat";
        private ReadAccount ra = new ReadAccount();
        public frmDoiMatKhau()
        {
            InitializeComponent();
        }
        // yeu cau nhap day du thong tin
        private void btnSave_Click(object sender, EventArgs e)
        {
            if(txtOldPW.Text.Trim().Length==0)
            {
                lblCheck.Text = "Vui lòng nhập mật khẩu cũ! ^_^";
                txtOldPW.Focus();
                return;
            }
            if (txtNewPW.Text.Trim().Length == 0)
            {
                lblCheck.Text = "Vui lòng nhập mật khẩu mới!";
                txtNewPW.Focus();
                return;
            }
            if (txtConfirmPW.Text.Trim().Length == 0)
            {
                lblCheck.Text = "Vui lòng nhập lại mật khẩu mới! :>";
                txtConfirmPW.Focus();
                return;
            }
            // kiem tra mat khau moi duoc nhap co hop le
            if (txtNewPW.Text.Trim() != txtConfirmPW.Text.Trim())
            {
                lblCheck.Text = "Mật khẩu không trùng nhau! ;( ";
                txtNewPW.ResetText();
                txtConfirmPW.ResetText();
                txtNewPW.Focus();
                return;
            }
            string[] contents = ra.ReadFile(filePath);
            string tdn = contents[0];
            string mk = contents[1];
            try
            {
                if (bll.NhanVien.updateDangNhap(txtOldPW.Text, int.Parse(tdn), txtNewPW.Text))
                    MessageBox.Show("Đổi mật khẩu thành công :D", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                {
                    
                    lblCheck.Text = "Mật khẩu cũ không đúng rùi! -_-";
                    txtConfirmPW.ResetText();
                    txtNewPW.ResetText();
                    txtOldPW.ResetText();
                }
            }
            catch { }
        }
        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                txtNewPW.Focus();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                txtConfirmPW.Focus();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbPW.Checked == true)
            {
                txtConfirmPW.UseSystemPasswordChar = false;
                txtOldPW.UseSystemPasswordChar = false;
                txtNewPW.UseSystemPasswordChar = false;
            }
            else
            {
                txtConfirmPW.UseSystemPasswordChar = true;
                txtOldPW.UseSystemPasswordChar = true;
                txtNewPW.UseSystemPasswordChar = true ;
            }
        }

        private void frmDoiMatKhau_Load(object sender, EventArgs e)
        {
            txtConfirmPW.Focus();
            txtConfirmPW.UseSystemPasswordChar = true;
            txtOldPW.UseSystemPasswordChar = true;
            txtNewPW.UseSystemPasswordChar = true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtConfirmPW_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
              btnSave.Focus();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            txtConfirmPW.ResetText();
            txtNewPW.ResetText();
            txtOldPW.ResetText();
        }
    }
}
