using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace UserLogin
{
    public delegate void LoginHandle(UserLoginControl sender, EventArgs e);
    public partial class UserLoginControl : UserControl
    {
        public event LoginHandle eventLogin;
        public string passWord, user, filePath;
        public UserLoginControl()
        {
            InitializeComponent();
        }
        
        public string[] ReadAccountFromFile()
        {
            string[] contents = File.ReadAllLines(filePath);
            return contents;
        }
        //ghi nho lai pass va tai khoan da ghi nho 
        public void WriteToFile(string user, string pass)
        {
            string[] contents = { user, pass };
            File.WriteAllLines(filePath, contents);
        }
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (eventLogin != null)
                // kiem tra nhap day du tai khoan va pass
            {
                if (txtTenDN.Text.Trim().Length == 0)
                {
                    lblIncorrect.Text = "Vui lòng nhập Tên đăng nhập!";
                    txtTenDN.Focus();
                    return;
                }
                if (txtMatKhau.Text.Trim().Length == 0)
                {
                    lblIncorrect.Text = "Vui lòng nhập Mật khẩu!";
                    txtMatKhau.Focus();
                    return;
                }
                passWord = txtMatKhau.Text;
                user = txtTenDN.Text;
                eventLogin(this, e);
            }
        }
        //xoa het thong tin dang nhap 
        private void btnXoa_Click(object sender, EventArgs e)
        {
            txtMatKhau.ResetText();
            txtTenDN.ResetText();
            txtTenDN.Focus();
        }


        private void txtTenDN_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                txtMatKhau.Focus();
        }

        private void txtMatKhau_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                btnDangNhap.Focus();
        }
        //kiem tra tai khoan dang nhap xem co hop le
        private void UserLoginControl_Load(object sender, EventArgs e)
        {
            txtTenDN.Focus();
            txtMatKhau.UseSystemPasswordChar = true;
            memorPass.Checked = false;
        }

        //private void ckbShowPassword_CheckedChanged(object sender, EventArgs e)
        //{
        //    if (ckbShowPassword.Checked == true)
        //        txtMatKhau.UseSystemPasswordChar = false;
        //    else
        //        txtMatKhau.UseSystemPasswordChar = true;
        //}

    }
}
