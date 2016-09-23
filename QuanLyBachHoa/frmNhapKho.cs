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
    public partial class frmNhapKho : Form
    {
        BaseBLL bll = new BaseBLL();
        private string filePath = Application.StartupPath + "\\User.dat";
        ReadAccount ra = new ReadAccount(); string[] contents;
        private void DataBind()
        {
            dgvNhapHang.DataSource = bll.PhieuNhap.getPhieuNhap();
            contents = ra.ReadFile(filePath);
            try
            {
                int r = dgvNhapHang.CurrentCell.RowIndex;
                int maPN = int.Parse(dgvNhapHang.Rows[r].Cells[0].Value.ToString()); 
                lblCTPN.Text = "Chi tiết phiếu nhập: " + maPN;
                dgvCTNhapHang.DataSource = bll.PhieuNhap.getCTPhieuNhap(maPN);
            }
            catch { }
        }
        public frmNhapKho()
        {
            InitializeComponent();
        }

        private void frmNhapKho_Load(object sender, EventArgs e)
        {
            DataBind();
        }

        private void thêmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new frmEditPhieuNhap()).ShowDialog();
        }


        void XoaPN()
        {
            if (!bll.NhanVien.isAdmin(int.Parse(contents[0])))
            {
                MessageBox.Show("Bạn không phải Admin!!!", "Cảnh báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string err = "";
            int r = dgvNhapHang.CurrentCell.RowIndex;
            int mpn = int.Parse(dgvNhapHang.Rows[r].Cells[0].Value.ToString());
            DialogResult rs = MessageBox.Show("Bạn chắc chắn muốn xóa phiếu nhập này?", "Thông báo",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (DialogResult.OK == rs)
            {
                try
                {
                    bll.PhieuNhap.deletePhieuNhap(mpn);
                    DataBind();
                    MessageBox.Show("Đã thỏa lòng mong ước...\n Xóa thành công!", "Thông báo",
                         MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch { MessageBox.Show(err); }
            }
        }


        private void dgvNhapHang_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                int r = dgvNhapHang.CurrentCell.RowIndex;
                int maPN = int.Parse(dgvNhapHang.Rows[r].Cells[0].Value.ToString());
                lblCTPN.Text = "Chi tiết phiếu nhập: " + maPN;
                dgvCTNhapHang.DataSource = bll.PhieuNhap.getCTPhieuNhap(maPN);
            }
            catch { }
        }
        private void dgvNhapHang_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            XoaPN();
        }

        private void toolStripLabel2_Click(object sender, EventArgs e)
        {
            DataBind();
        }

    }
}
