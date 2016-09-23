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
    public partial class frmNhanVien : Form
    {
        BaseBLL bll = new BaseBLL();
        private string filePath = Application.StartupPath + "\\User.dat";
        private ReadAccount ra = new ReadAccount();
        public string manv = "";
        bool sua = false; string[] contents;
        public frmNhanVien()
        {
            InitializeComponent();
        }
        private void DataBind()
        {
            dgv.DataSource = bll.NhanVien.getNhanVien();
            contents = ra.ReadFile(filePath);
            //for (int i = 0; i < dgv.Rows.Count; i++)
            //{

            //    foreach (NhanVienRecycle mh in bll.NhanVienRecycle.getNhanVienRecycle())
            //    {
            //        if (dgv.Rows[i].Cells[0].Value.ToString() == mh.NhanVienR.ToString())
            //            dgv.Rows.Remove(dgv.Rows[i]);
            //    }
            //}
        }
        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            DataBind();
        }

        private void thêmToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (!bll.NhanVien.isAdmin(int.Parse(contents[0])))
            {
                MessageBox.Show("Bạn không phải Admin!!!", "Cảnh báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            frmEditNhanVien frm = new frmEditNhanVien();
            frm.ShowDialog();

        }
        void SuaNhanVien()
        {
            if (!bll.NhanVien.isAdmin(int.Parse(contents[0])))
            {
                MessageBox.Show("Bạn không phải Admin, không có quyền sửa!!!", "Cảnh báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            sua = true;
            frmEditNhanVien frm = new frmEditNhanVien();
            frm.edit = sua;
            int r = dgv.CurrentCell.RowIndex;
            frm.cv = dgv.Rows[r].Cells[2].Value.ToString();
            frm.txtMaNV.Text = dgv.Rows[r].Cells[0].Value.ToString();
            frm.txtTenNV.Text = dgv.Rows[r].Cells[1].Value.ToString();
            frm.txtDiaChi.Text = dgv.Rows[r].Cells[4].Value.ToString();
            frm.txtEmail.Text = dgv.Rows[r].Cells[5].Value.ToString();
            frm.txtSDT.Text = dgv.Rows[r].Cells[6].Value.ToString();
            frm.txtPass.Text = dgv.Rows[r].Cells[8].Value.ToString();
            frm.txtLuong.Text = dgv.Rows[r].Cells[9].Value.ToString();
            frm.gt = dgv.Rows[r].Cells[3].Value.ToString();
            frm.cbAdmin.Checked = Boolean.Parse(dgv.Rows[r].Cells[7].Value.ToString());
            if (bll.NhanVien.CountAdmin() < 2 &&
               int.Parse(frm.txtMaNV.Text) == int.Parse(contents[0]))
                frm.cbAdmin.Enabled = false;

            frm.ShowDialog();
        }
        private void sửaToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            SuaNhanVien();
        }

        private void xíaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!bll.NhanVien.isAdmin(int.Parse(contents[0])))
            {
                MessageBox.Show("Bạn không phải Admin!!!", "Cảnh báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                int r = dgv.CurrentCell.RowIndex;
                int mnv = int.Parse(dgv.Rows[r].Cells[0].Value.ToString());

                if (int.Parse(contents[0]) == mnv)
                {
                    MessageBox.Show("Bạn không thể xóa Chính mình!", "Cảnh báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                DialogResult rs = MessageBox.Show("Bạn chắn muốn xóa?", "Xóa?",
                   MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    if (bll.NhanVien.deleteNhanVien(mnv))
                    {
                        MessageBox.Show("Xóa Nhân viên thành công!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else MessageBox.Show("Không thể xóa nhân viên này!", "Thông báo",
                        MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }
            }
            catch { }
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataBind();
        }

        private void dgv_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            SuaNhanVien();
        }
    }
}
