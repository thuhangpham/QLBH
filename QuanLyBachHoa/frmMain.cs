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
using DataAccessLayer;
using DataAccessLayer.Models;

namespace QuanLyBachHoa
{
    public partial class frmMain : Form
    {
        BaseBLL bll = new BaseBLL();
        Image closeImageAct, closeImage;
        private string filePath = Application.StartupPath + "\\User.dat";
        private ReadAccount ra = new ReadAccount();
        string[] contents;
        public frmMain()
        {
            InitializeComponent();
        }
        public void AddTapPage(Form frm)
        {
            int index = KTFormTonTai(frm);
            if (index >= 0)
            {
                //tabControl1.TabIndex = index;
                if (tabControl1.SelectedTab == tabControl1.TabPages[index])
                    MessageBox.Show("Ban đang ở cửa sổ \"" + frm.Text+ "\"!");
                else tabControl1.SelectedTab = tabControl1.TabPages[index];
            }
            else
            {
                TabPage tappage = new TabPage(frm.Text);
                tabControl1.TabPages.Add(tappage);
                frm.TopLevel = false;
                frm.Parent = tappage;
                tabControl1.SelectedTab = tabControl1.TabPages[tabControl1.TabCount - 1];
                frm.Show();
                frm.Dock = DockStyle.Fill;
            }
        }
        public int KTFormTonTai(Form frm)
        {
            for (int i = 0; i < tabControl1.TabCount; i++)
            {
                if (tabControl1.TabPages[i].Text == frm.Text.Trim())
                    return i;
            }
            return -1;
        }
        private void tabControl1_MouseClick_1(object sender, MouseEventArgs e)
        {
            // Su kien click dong tabpage
            for (int i = 0; i < tabControl1.TabCount; i++)
            {
                // giong o DrawItem
                Rectangle rect = tabControl1.GetTabRect(i);
                Rectangle imageRec = new Rectangle(rect.Right - closeImage.Width,
                    rect.Top + (rect.Height - closeImage.Height) / 2,
                    closeImage.Width, closeImage.Height);

                if (imageRec.Contains(e.Location))
                    tabControl1.TabPages.Remove(tabControl1.SelectedTab);
            }
        }

        private void tabControl1_DrawItem_1(object sender, DrawItemEventArgs e)
        {
            Brush brBlack = Brushes.Black;
            Rectangle rect = tabControl1.GetTabRect(e.Index);
            Rectangle imageRect = new Rectangle(rect.Right - closeImageAct.Width, 
                rect.Top + (rect.Height - closeImageAct.Height) / 2, 
                closeImageAct.Width, closeImageAct.Height);
            StringFormat strFormat = new StringFormat(StringFormat.GenericDefault);
            //rect.Size = new System.Drawing.Size(rect.Width+20, 30);
             Font f ;
            if (tabControl1.SelectedTab == tabControl1.TabPages[e.Index])
            {
                e.Graphics.DrawImage(closeImageAct, imageRect);
                f = new System.Drawing.Font("Arial", 10, FontStyle.Bold);
                e.Graphics.DrawString("  "+ tabControl1.TabPages[e.Index].Text,
                    f, brBlack, rect, strFormat);
            }
            else
            {
                e.Graphics.DrawImage(closeImage, imageRect);
                f = new System.Drawing.Font("Arial", 9, FontStyle.Strikeout);
                e.Graphics.DrawString("     "+tabControl1.TabPages[e.Index].Text, 
                    this.Font, brBlack, rect, strFormat);
            }
        }
      
        private void frmMain_Load(object sender, EventArgs e)
        {
            contents = ra.ReadFile(filePath);
            loadUser();
            tabControl1.DrawMode = TabDrawMode.OwnerDrawFixed;
            Size mySize = new System.Drawing.Size(20, 20);
            //
            Bitmap btm = new Bitmap(Properties.Resources.close);
            Bitmap bt = new Bitmap(btm, mySize);
            closeImageAct = bt;
            //
            Bitmap btm2 = new Bitmap(Properties.Resources.closeBlack);
            Bitmap bt2 = new Bitmap(btm2, mySize);
            closeImage = bt2;
            tabControl1.Padding = new Point(30);
            //
            frmTroGiup frm = new frmTroGiup();
            frm.TopLevel = false;
            frm.Parent = tabControl1.TabPages["tabPage1"];
            frm.Show();
            frm.Dock = DockStyle.Fill;
            //
        }
       
        private void danhMụcKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddTapPage((new frmKhachHang()));
        }
        private void danhMụcNhàCungCấpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddTapPage((new frmNhaCC()));
        }

        private void nhânViênToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (!bll.NhanVien.isAdmin(int.Parse(contents[0])))
            {
                MessageBox.Show("Bạn không phải Admin!!!", "Cảnh báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            AddTapPage(new frmNhanVien());
        }

        private void quảnLýBánHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddTapPage((new frmQuanLyBanHang()));
        }

        private void đổiMậtKhẩuToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            (new frmDoiMatKhau()).ShowDialog();
        }

        private void đăngXuấtToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            (new frmDangNhap()).ShowDialog();
        }

        private void thoátToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void danhMụcMặtHàngToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AddTapPage((new frmMatHang()));
        }

        private void nhậpHàngToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AddTapPage(new frmNhapKho());
        }

        private void xuấtHàngToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AddTapPage(new frmXuatKho());
        }

        private void kiểmKêToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AddTapPage(new frmKiemKe());
        }

        private void quảnLýBánHàngToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AddTapPage((new frmQuanLyBanHang()));
        }
        private void ClickEventQLBH(Control sender, EventArgs e)
        {
            AddTapPage((new frmQuanLyBanHang()));
        }
        private void hướngDẫnSửDụngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddTapPage((new frmTroGiup()));
        }
        private void chứcVụToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new frmChucVu()).ShowDialog();
        }
        private void buttonDMHoaDon_Click(object sender, EventArgs e)
        {
            AddTapPage((new frmHoaDon()));
        }
        void loadUser()
        {
            lblXinChao.Text = "Xin chào: " + bll.NhanVien.
               getTenNhanVien(int.Parse(contents[0]));
            int t = lblXinChao.Width;
            lblXinChao.Location = new Point(Width - t - 30, lblXinChao.Location.Y);
        }
        private void lblXinChao_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            NhanVien nv = bll.NhanVien.getUser(int.Parse(contents[0]));
            frmEditNhanVien frm = new frmEditNhanVien();
            frm.txtMaNV.Text = nv.NhanVienId.ToString();
            frm.txtTenNV.Text = nv.TenNhanVien;
            frm.txtDiaChi.Text = nv.DiaChi;
            frm.txtSDT.Text = nv.SDT;
            frm.txtEmail.Text = nv.Email;
            frm.txtLuong.Text = nv.Luong.ToString();
            frm.txtPass.Text = nv.Password;
            frm.txtPass.UseSystemPasswordChar = true;
            frm.txtPass.Enabled = false;
            frm.cbAdmin.Checked = nv.Admin;
            frm.cbCV.SelectedValue = nv.ChucVuId;
            frm.gt = nv.GioiTinh;
            frm.cbCV.SelectedValue=nv.ChucVuId;
            frm.cbAdmin.Enabled = false;
            frm.cbCV.Enabled = false;
            frm.edit = true;
            frm.txtLuong.Enabled = false;
            frm.btnLuu.Visible = false;
            frm.label8.Visible = false;
            if (bll.NhanVien.isAdmin(int.Parse(contents[0])))
            {
                frm.txtLuong.Enabled = true;
                frm.cbCV.Enabled = true;
                if (bll.NhanVien.CountAdmin() > 1)
                    frm.cbAdmin.Enabled = true;
            }
            frm.ShowDialog();
        }
        //public bool checkExisForm(Form fr)
        //{
        //   foreach(Form frm in this.MdiChildren)
        //    {
        //        if (frm.Text == fr.Text)
        //        {
        //            return true;
        //        }
        //    }
        //    return false;
        //}
        //public void active(Form fr)
        //{
        //    foreach (Form frm in this.MdiChildren)
        //    {
        //        if (frm.Text == fr.Text)
        //        {
        //            frm.Activate();
        //            break;
        //        }
        //    }
        //}
        private void toolStripLabel4_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn chắc chắn muốn thoát?","Thoát?"
                ,MessageBoxButtons.OKCancel,MessageBoxIcon.Question);
            if (DialogResult.OK == rs)
                Application.Exit();
        }

        private void toolStripLabel6_Click(object sender, EventArgs e)
        {

        }

        //private void timer1_Tick(object sender, EventArgs e)
        //{
        //    string st = this.Text;
        //    this.Text =st.Substring(st.Length - 1)+
        //        st.Substring(0, st.Length - 1);
        //}
    }
}
