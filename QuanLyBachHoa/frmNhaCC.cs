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
    public partial class frmNhaCC : Form
    {
        event SendKH send; 
        BaseBLL bll = new BaseBLL();
        public frmNhaCC()
        {
            InitializeComponent();
        }
        public frmNhaCC(SendKH sender)
        {
            InitializeComponent();
            this.send = sender;
        }
        private void DataBind()
        {
            dgvNhaCC.DataSource = bll.NhaCungCap.getNhaCungCap();
        }

        private void frmNhaCC_Load(object sender, EventArgs e)
        {
            DataBind();
        }

        private void thêmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new frmEditNhaCC()).ShowDialog();
        }
        void SuaNCC()
        {
            try
            {
                frmEditNhaCC frm = new frmEditNhaCC();
                frm.edit = true;
                int r = dgvNhaCC.CurrentCell.RowIndex;
                frm.txtMaNCC.Text = dgvNhaCC.Rows[r].Cells[1].Value.ToString();
                frm.txtTenNCC.Text = dgvNhaCC.Rows[r].Cells[2].Value.ToString();
                frm.txtDiaChi.Text = dgvNhaCC.Rows[r].Cells[3].Value.ToString();
                frm.txtEmail.Text = dgvNhaCC.Rows[r].Cells[4].Value.ToString();
                frm.txtSDT.Text = dgvNhaCC.Rows[r].Cells[5].Value.ToString();
                frm.txtGC.Text = dgvNhaCC.Rows[r].Cells[6].Value.ToString();
                frm.ShowDialog();
            }
            catch { }
        }
        private void sửaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SuaNCC();
        }

        private void refresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataBind();
        }

        private void xóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                int r = dgvNhaCC.CurrentCell.RowIndex;
                int mncc = int.Parse(dgvNhaCC.Rows[r].Cells[1].Value.ToString());
                DialogResult rs = MessageBox.Show("Bạn chắc chắn muốn đưa dữ liệu vào thùng rác ...", "Xóa?",
                   MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (rs == DialogResult.Yes)
                {
                    if (bll.NhaCungCap.deleteNhaCungCap(mncc))
                    {
                        DataBind();
                    MessageBox.Show("Xóa Nhà cung cấp thành công!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else MessageBox.Show("Lỗi!");
                }
            }
            catch { }
        }

        private void dgvNhaCC_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            SuaNCC();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Chon_Click(object sender, EventArgs e)
        {
            int r = dgvNhaCC.CurrentCell.RowIndex;
            this.send(dgvNhaCC.Rows[r].Cells[1].Value.ToString(), 
                dgvNhaCC.Rows[r].Cells[2].Value.ToString());
            this.Close();
        }
    }
}
