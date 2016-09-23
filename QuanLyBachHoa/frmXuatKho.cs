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
    public partial class frmXuatKho : Form
    {
        BaseBLL bll = new BaseBLL();
        private string filePath = Application.StartupPath + "\\User.dat";
        ReadAccount ra = new ReadAccount(); string[] contents;
        public frmXuatKho()
        {
            InitializeComponent();
        }
        private void DataBind()
        {
            dgvXuatHang.DataSource = bll.PhieuXuat.getPhieuXuat();
            try
            {
                int r = dgvXuatHang.CurrentCell.RowIndex;
                int maPX = int.Parse(dgvXuatHang.Rows[r].Cells[0].Value.ToString());
                lblCTPN.Text = "Chi tiết phiếu xuất: " + maPX;
                dgvCTXuatHang.DataSource = bll.PhieuXuat.getCTPhieuXuat(maPX);
            }
            catch { }
            contents = ra.ReadFile(filePath);
        }
        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataBind();
        }
        //private void xóaToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    if (!bll.NhanVien.isAdmin(int.Parse(contents[0])))
        //    {
        //        MessageBox.Show("Bạn không phải Admin!!!", "Cảnh báo",
        //            MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //        return;
        //    }
        //    string err="";
        //    DialogResult rs = MessageBox.Show("Bạn chắc chắn muốn xóa phiếu xuất này?","Thông báo",
        //        MessageBoxButtons.OKCancel,MessageBoxIcon.Information);
        //    if(DialogResult.OK==rs)
        //    {
        //        try
        //        {
        //            int r = dgvXuatHang.CurrentCell.RowIndex;
        //            int maPX = int.Parse(dgvXuatHang.Rows[r].Cells[0].Value.ToString());
        //            if (bll.PhieuXuat.deletePhieuXuat(maPX))
        //            {
        //                DataBind();
        //                MessageBox.Show("Xóa thành công!", "Thông báo",
        //                     MessageBoxButtons.OK, MessageBoxIcon.Information);
        //            }
        //            else MessageBox.Show("Lỗi!", "Error",
        //                  MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        }
        //        catch { MessageBox.Show(err); }
        //    }
        //}

        private void thêmToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            
            (new frmEditPhieuXuat()).ShowDialog();
        }
        private void dgvNhapHang_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                int r = dgvXuatHang.CurrentCell.RowIndex;
                int maPX = int.Parse(dgvXuatHang.Rows[r].Cells[0].Value.ToString());
                lblCTPN.Text = "Chi tiết phiếu xuất: " + maPX;
                dgvCTXuatHang.DataSource = bll.PhieuXuat.getCTPhieuXuat(maPX);
            }
            catch { }
        }

        private void frmXuatKho_Load(object sender, EventArgs e)
        {
            DataBind();
        }
    }
}
