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
    public partial class frmKiemKe : Form
    {
        BaseBLL bll = new BaseBLL();
        private string filePath = Application.StartupPath + "\\User.dat";
        ReadAccount ra = new ReadAccount(); string[] contents;
        public frmKiemKe()
        {
            InitializeComponent();
        }
        private void DataBind()
        {
            dgvPKK.DataSource = bll.PhieuKiemKe.getPhieuKiemKe();
            try
            {
                int r = dgvPKK.CurrentCell.RowIndex;
                int maPKK = int.Parse(dgvPKK.Rows[r].Cells[0].Value.ToString());
                lblCTPN.Text = "Chi tiết phiếu kiểm kê: " + maPKK;
                dgvCTPKK.DataSource = bll.PhieuKiemKe.getCTPhieuKiemKe(maPKK);
            }
            catch { }
            contents = ra.ReadFile(filePath);
        }
        private void frmKiemKe_Load(object sender, EventArgs e)
        {
            DataBind();
        }

        private void xóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!bll.NhanVien.isAdmin(int.Parse(contents[0])))
            {
                MessageBox.Show("Bạn không phải Admin!!!", "Cảnh báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string err = "";
            int r;
            int maPKK=1;
            DialogResult rs = MessageBox.Show("Bạn chắc chắn muốn xóa phiếu kiểm kê này?", "Thông báo",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (DialogResult.OK == rs)
            {
                try
                {
                    r = dgvPKK.CurrentCell.RowIndex;
                    int.Parse(dgvPKK.Rows[r].Cells[0].Value.ToString());
                    if (bll.PhieuKiemKe.deletePhieuKiemKe(maPKK))
                    {
                        DataBind();
                        MessageBox.Show("Xóa thành công!", "Thông báo",
                             MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else MessageBox.Show("Lỗi!", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch { MessageBox.Show(err,"Lỗi"); }
            }
        }

        private void thêmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new frmEditPhieuKiemKe()).ShowDialog();
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataBind();
        }

        private void dgvPKK_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                int r = dgvPKK.CurrentCell.RowIndex;
                int maPKK = int.Parse(dgvPKK.Rows[r].Cells[0].Value.ToString());
                lblCTPN.Text = "Chi tiết phiếu kiểm kê: " + maPKK;
                dgvCTPKK.DataSource = bll.PhieuKiemKe.getCTPhieuKiemKe(maPKK);
            }
            catch { }
        }
    }
}
