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
    public partial class frmChucVu : Form
    {
        private string filePath = Application.StartupPath + "\\User.dat";
        ReadAccount ra = new ReadAccount(); string[] contents;
        BaseBLL bll = new BaseBLL();
        bool them = true;
        private int macv = 1;
        private void DataBind()
        {
            
            dataGridView1.DataSource = bll.ChucVu.getChucVu();
            // xoa dl thung rac
            //for (int i = 0; i < dataGridView1.Rows.Count; i++)
            //    foreach (ChucVuRecycle mh in bll.ChucVuRecycle.getChucVuRecycle())
            //        if (dataGridView1.Rows[i].Cells[1].Value.ToString() == mh.ChucVuR.ToString())
            //            dataGridView1.Rows.Remove(dataGridView1.Rows[i]);
        }
        public frmChucVu()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmChucVu_Load(object sender, EventArgs e)
        {
            contents = ra.ReadFile(filePath);
            DataBind();
            // chi admin moi co quyen cap nhat 
            if (!bll.NhanVien.isAdmin(int.Parse(contents[0])))
            {
                txtUser.Enabled = false;
                btnSave.Enabled = false;
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (them)
            {
                if (txtUser.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Vui lòng nhập tên chức vụ ...", "Cảnh báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtUser.Focus();
                    return;
                }
                if (bll.ChucVu.insertChucVu(txtUser.Text))
                    MessageBox.Show("Thêm chức vụ \"" + txtUser.Text + "\" thành công!", "Thông báo");
                else MessageBox.Show("Thêm chức vụ \"" + txtUser.Text + "\" Lỗi!", "Thông báo");
                DataBind();
                them = false;
                tabControl1.SelectedTab = tabControl1.TabPages[0];
            }
            else
            {
                if (bll.ChucVu.updateChucVu(macv, txtUser.Text))
                    MessageBox.Show("Sửa chức vụ thành công!", "Thông báo");
                else MessageBox.Show("Sửa chức vụ xuất Lỗi!", "Thông báo");
                DataBind();
                tabControl1.SelectedTab = tabControl1.TabPages[0];
            }
        }

        private void sửaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            them = false;
            if (!bll.NhanVien.isAdmin(int.Parse(contents[0])))
            {
                MessageBox.Show("Bạn không phải Admin!!!", "Cảnh báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            label2.Text = "&Sửa chức vụ: ";
            try
            {
                int r = dataGridView1.CurrentCell.RowIndex;
                macv = int.Parse(dataGridView1.Rows[r].Cells[0].Value.ToString());
                txtUser.Text = dataGridView1.Rows[r].Cells[1].Value.ToString();
                tabControl1.SelectedTab = tabControl1.TabPages[0];
            }
            catch { }
        }

        private void thêmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            them = true;
            if (!bll.NhanVien.isAdmin(int.Parse(contents[0])))
            {
                MessageBox.Show("Bạn không phải Admin!!!", "Cảnh báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            label2.Text = "&Thêm chức vụ: ";
            txtUser.ResetText();
            tabControl1.SelectedTab = tabControl1.TabPages[1];
        }

        private void xoasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                int r = dataGridView1.CurrentCell.RowIndex;
                macv = int.Parse(dataGridView1.Rows[r].Cells[0].Value.ToString());
            }
            catch { return; }
            if (!bll.NhanVien.isAdmin(int.Parse(contents[0])))
            {
                MessageBox.Show("Bạn không phải Admin!!!", "Cảnh báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (macv==bll.NhanVien.getChucVuId(int.Parse(contents[0])))
            {
                MessageBox.Show("Bạn không thể xóa chức vụ này!!!", "Cảnh báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult rs = MessageBox.Show("Bạn thật sự muốn xóa!", "Xóa",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (DialogResult.OK == rs)
            {
                if(bll.ChucVu.deleteChucVu(macv))
                //bll.ChucVuRecycle.InsertChucVuRecycle(macv);
                //DataGridViewRow dr = dataGridView1.Rows[dataGridView1.CurrentRow.Index];
                //dataGridView1.Rows.Remove(dr);
                MessageBox.Show("Xóa chức vụ thành công!", "Thông báo");
               // DataBind();
                else
                {
                    MessageBox.Show("Bạn không thể xóa chức vụ này(ràng buộc với nhân viên)!");
                }
            }

        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataBind();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            txtUser.ResetText();
        }

    }
}
