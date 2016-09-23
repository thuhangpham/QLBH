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
using UserLogin;

namespace QuanLyBachHoa
{
    public partial class frmDangNhap : Form
    {
        private BaseBLL bll = new BaseBLL();
        public frmDangNhap()
        {
            InitializeComponent();
        }
        public string filePath = Application.StartupPath + "\\User.dat",
            SaveUser = Application.StartupPath + "\\SaveUser.dat";

        private void DangNhap_eventLogin(UserLoginControl sender, EventArgs e)
        {

            try
            {
                bool f = bll.NhanVien.checkDangNhap
                    (int.Parse(userLoginControl1.user.Trim()),
                    userLoginControl1.passWord.Trim());
                if (f)
                {//đăng nhập thành công
                    if (userLoginControl1.memorPass.Checked == true)
                        userLoginControl1.WriteToFile
                            (userLoginControl1.user.Trim(), userLoginControl1.passWord.Trim());
                        WriteToFile
                            (userLoginControl1.user.Trim(), userLoginControl1.passWord.Trim());

                    //MessageBox.Show("Dang nhap thanh cong");
                    this.Hide();
                    (new frmMain()).Show();
                }
                else
                {
                    //đăng nhập thất bại
                    MessageBox.Show("Account, Password Is Not Correct", "Lỗi");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void WriteToFile(string user, string pass)
        {
            string[] contents = { user, pass };
            File.WriteAllLines(filePath, contents);
        }
        private void DataBind()
        {
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            DataBind();
            userLoginControl1.filePath = SaveUser;
            userLoginControl1.eventLogin += DangNhap_eventLogin;
            string[] contents;
            try
            {
                if (File.Exists(filePath) == false)
                    File.Create(filePath);
                contents = File.ReadAllLines(SaveUser);
                userLoginControl1.txtMatKhau.Text = contents[1];
                userLoginControl1.txtTenDN.Text = contents[0];
            }
            catch { }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void userLoginControl1_Load(object sender, EventArgs e)
        {
        }
    }
}
