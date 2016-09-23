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
using DataAccessLayer;
namespace QuanLyBachHoa
{
    public partial class frmHoaDon : Form
    {
        BaseBLL bll = new BaseBLL();
        private string filePath = Application.StartupPath + "\\User.dat";
        private ReadAccount ra = new ReadAccount();
        Context context = new Context();
        string[] contents;
        public frmHoaDon()
        {
            InitializeComponent();
        }
        private void DataBind()
        {
            contents = ra.ReadFile(filePath);
            dgvHoaDon.DataSource = bll.HoaDon.getHoaDon();
            try
            {
                int r = dgvHoaDon.CurrentCell.RowIndex;
                int mhd = int.Parse(dgvHoaDon.Rows[r].Cells[0].Value.ToString());
                label1.Text = "Chi tiết hóa đơn bán hàng theo mã hóa đơn: " + mhd;
                dgvFillter.DataSource = bll.HoaDon.getCTHoaDonTheoId(mhd);
            }
            catch { }
        }

        private void frmHoaDon_Load(object sender, EventArgs e)
        {
            DataBind();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DataBind();
        }

        private void tvFillter_DoubleClick(object sender, EventArgs e)
        {
            int r = dgvHoaDon.CurrentCell.RowIndex;
            int mhd = int.Parse(dgvHoaDon.Rows[r].Cells[0].Value.ToString());
            int mkh = int.Parse(dgvHoaDon.Rows[r].Cells[3].Value.ToString());
            string tenkh = dgvHoaDon.Rows[r].Cells[4].Value.ToString();
            string tennv = dgvHoaDon.Rows[r].Cells[2].Value.ToString();
            DateTime ngay = DateTime.Parse(dgvHoaDon.Rows[r].Cells[1].Value.ToString());
            try
            {
                if (tvFillter.SelectedNode.Index == 0)
                {
                    label1.Text = tvFillter.SelectedNode.Text + ": " + mhd;
                    dgvFillter.DataSource = bll.HoaDon.getCTHoaDonTheoId(mhd);
                }
                else if (tvFillter.SelectedNode.Index == 1)
                {
                    label1.Text = tvFillter.SelectedNode.Text + ": " + ngay.ToShortDateString();
                    dgvFillter.DataSource = bll.HoaDon.
                        getHoaDonTheoNgay(DateTime.Parse(ngay.ToShortDateString()));
                }
                else if (tvFillter.SelectedNode.Index == 2)
                {
                    label1.Text = tvFillter.SelectedNode.Text;
                    var ngaySum = context.HoaDons.
                        GroupBy(g => g.Ngay).
                        Select(s => new
                        {
                            s.Key,
                           Tong =
                           s.Sum(t=>t.TongTien)
                });
                    dgvFillter.DataSource = ngaySum.ToList();
                }
                else if (tvFillter.SelectedNode.Index == 3)
                {
                    label1.Text = tvFillter.SelectedNode.Text + ": " + tenkh;
                    dgvFillter.DataSource = bll.HoaDon.getHoaDonTheoKH(mkh);
                }
                else if (tvFillter.SelectedNode.Index == 4)
                {
                    label1.Text = tvFillter.SelectedNode.Text + ": " + tenkh;
                    dgvFillter.DataSource = bll.HoaDon.getHoaDonCTTheoKH(mkh);
                }
                //dgvFillter.DataSource = ds.Tables[0];
            }
            catch (SqlException ex) { MessageBox.Show(ex.Message); }
        }
        void XoaHoaDon()
        {
            if (!bll.NhanVien.isAdmin(int.Parse(contents[0])))
            {
                MessageBox.Show("Bạn không phải Admin!!!", "Cảnh báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DialogResult rs = MessageBox.Show("Bạn chắc chắn muốn xóa!.. :(\n", "Xóa?",
              MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            int r = dgvHoaDon.CurrentCell.RowIndex;
            int mhd = int.Parse(dgvHoaDon.Rows[r].Cells[0].Value.ToString());
            if (rs == DialogResult.Yes)
            {
                if (bll.HoaDon.deleteHoaDon(mhd))
                {
                    MessageBox.Show("Xóa hóa đơn thành công!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DataBind();
                }
                else MessageBox.Show("Xóa hóa đơn lỗi!", "Lỗi rùi",
                       MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        private void xóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            XoaHoaDon();
        }

        private void dgvHoaDon_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            XoaHoaDon();
        }

       
        private void dgvHoaDon_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                int r = dgvHoaDon.CurrentCell.RowIndex;
                int mhd = int.Parse(dgvHoaDon.Rows[r].Cells[0].Value.ToString());
                label1.Text = "Chi tiết hóa đơn bán hàng theo mã hóa đơn : " + mhd;
                dgvFillter.DataSource = bll.HoaDon.getCTHoaDonTheoId(mhd);
            }
            catch { }
        }
         
    }
}
