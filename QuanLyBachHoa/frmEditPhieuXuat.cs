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
    public partial class frmEditPhieuXuat : Form
    {
        private string filePath = Application.StartupPath + "\\User.dat";
        ReadAccount ra = new ReadAccount(); string[] contents;
        BaseBLL bll = new BaseBLL();
        Context context = new Context();
        private decimal tong;
        public frmEditPhieuXuat()
        {
            InitializeComponent();
        }
        private void DataBind()
        {
            dgvMatHang.DataSource = bll.MatHang.getMatHangXuat();
            //
            cbNhanVien.DataSource = bll.NhanVien.getNhanVien();
            cbNhanVien.ValueMember = "NhanVienId";
            cbNhanVien.DisplayMember = "TenNhanVien";
            //
            tvNH_ControlAdded();
            contents = ra.ReadFile(filePath);
            if (!bll.NhanVien.isAdmin(int.Parse(contents[0])))
            {
                cbNhanVien.SelectedValue = int.Parse(contents[0]);
                cbNhanVien.Enabled = false;
            } 
        }
        private void tvNH_DoubleClick(object sender, EventArgs e)
        {
            try
            {
               dgvMatHang.DataSource=
                   bll.MatHang.getMatHangTheoNhomXuat
                   (int.Parse(tvNH.SelectedNode.Tag.ToString().Trim()));
            }
            catch (SqlException ex) { MessageBox.Show(ex.Message); }
        }
        private void tvNH_ControlAdded()
        {
            DataSet ds = new DataSet();
            dgvNH.DataSource = bll.NhomHang.getNhomHang();
            int r = dgvNH.Rows.Count;
            tvNH.Refresh();
            int t = tvNH.Nodes.Count;
            for (int i = 0; i < t; i++)
                tvNH.Nodes[0].Remove();
            for (int i = 0; i < r; i++)
            {
                tvNH.Nodes.Add(dgvNH.Rows[i].Cells[1].Value.ToString());
                tvNH.Nodes[i].Tag=dgvNH.Rows[i].Cells[0].Value.ToString();
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Huy()
        {
            int r = dgvCTPX.Rows.Count;
            for (int i = 1; i <= r; i++)
            {
                DataGridViewRow row = new DataGridViewRow();
                row = dgvCTPX.Rows[0];
                dgvCTPX.Rows.Remove(row); 
            }

            txtTong.Text = "0";
        }
        private void btnHuy_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn có muốn xóa toàn bộ mặt hàng đã thêm", "Thông báo",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (DialogResult.OK == rs)
            {
                btnHuy.Enabled = false;
                btnLuu.Enabled = false;
                Huy();
            }
        }
        private void btnThemMH_Click(object sender, EventArgs e)
        {
            try
            {
                // dong hien tai
                int RowIndex = dgvMatHang.CurrentCell.RowIndex;
                int sl = (int)numericUpDown1.Value;
                int i;
                DataGridViewRow row = new DataGridViewRow();
                DataGridViewCell cell;
                cell = new DataGridViewTextBoxCell();
                cell.Value = dgvMatHang.Rows[RowIndex].Cells[0].Value.ToString();
                // kiem tra trung mat hang da them
                for (i = 0; i < dgvCTPX.RowCount; i++)
                {
                    if (dgvCTPX.Rows[i].Cells[0].Value.ToString() == cell.Value.ToString())
                    {
                        sl = (int.Parse(dgvCTPX.Rows[i].Cells[5].Value.ToString()) + sl);
                        dgvCTPX.Rows[i].Cells[5].Value = sl + "";
                        // TONG SO LUONG DA THEM
                        tong = 0;
                        for (int j = 0; j < dgvCTPX.Rows.Count; j++)
                            tong += decimal.Parse(dgvCTPX.Rows[j].Cells[5].Value.ToString());
                        txtTong.Text = tong.ToString();
                        return;
                    }
                }
                // ma hang
                cell = new DataGridViewTextBoxCell();
                cell.Value = dgvMatHang.Rows[RowIndex].Cells[0].Value.ToString();
                row.Cells.Add(cell);
                // ten mat hang
                cell = new DataGridViewTextBoxCell();
                cell.Value = dgvMatHang.Rows[RowIndex].Cells[1].Value.ToString();
                row.Cells.Add(cell);
                // dvt
                cell = new DataGridViewTextBoxCell();
                cell.Value = dgvMatHang.Rows[RowIndex].Cells[2].Value.ToString();
                row.Cells.Add(cell);
                // gia nhap
                cell = new DataGridViewTextBoxCell();
                cell.Value = dgvMatHang.Rows[RowIndex].Cells[3].Value.ToString();
                row.Cells.Add(cell);
                // gia ban
                cell = new DataGridViewTextBoxCell();
                cell.Value = dgvMatHang.Rows[RowIndex].Cells[4].Value.ToString();
                row.Cells.Add(cell);
                // so luong
                cell = new DataGridViewTextBoxCell();
                cell.Value = sl.ToString();
                row.Cells.Add(cell);
                dgvCTPX.Rows.Add(row);

                tong = 0;
                for (int j = 0; j < dgvCTPX.Rows.Count; j++)
                    tong += decimal.Parse(dgvCTPX.Rows[j].Cells[5].Value.ToString());
                txtTong.Text = tong.ToString();

                btnHuy.Enabled = true;
                btnLuu.Enabled = true;
            }
            catch { }
        }

        // btn Lưu
        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            btnLuu.Enabled = false;
            // r dem tu 0
            // ma nhan vien
            int mnv = -1;
            mnv = int.Parse(cbNhanVien.SelectedValue.ToString());
            if (bll.PhieuXuat.insertPhieuXuat(DateTime.Parse(dateTimePicker1.Text), mnv, txtGC.Text))
            {
                tong = 0;
                for (int i = 0; i < dgvCTPX.Rows.Count; i++)
                {
                    int mahang = int.Parse(dgvCTPX.Rows[i].Cells[0].Value.ToString());
                    int sl = int.Parse(dgvCTPX.Rows[i].Cells[5].Value.ToString());
                    if (!bll.PhieuXuat.insertCTPhieuXuat
                        (context.PhieuXuats.Max(p => p.PhieuXuatId),
                        mahang, sl))
                    {
                        bll.PhieuXuat.deletePhieuXuat(context.PhieuXuats.Max(p => p.PhieuXuatId));
                        MessageBox.Show("Lỗi!", "Error");
                        return;
                    }
                }
                Huy();
                btnHuy.Enabled = false;
                btnLuu.Enabled = false;
            }
            else MessageBox.Show("Lỗi!","Error");
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmEditPhieuXuat_Load(object sender, EventArgs e)
        {
            DataBind();
            cbNhanVien.SelectedValue = int.Parse(contents[0]);
            cbNhanVien.Enabled = false;

        }

        private void dgvCTPX_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                DialogResult rs = MessageBox.Show("Bạn chắc chán muốn xóa mặt hàng này!", "Xóa?", MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Question);
                if (DialogResult.OK == rs)
                {
                    dgvCTPX.Rows.Remove(dgvCTPX.Rows[dgvCTPX.CurrentCell.RowIndex]);
                    tong = 0;
                    for (int j = 0; j < dgvCTPX.Rows.Count; j++)
                        tong += decimal.Parse(dgvCTPX.Rows[j].Cells[5].Value.ToString());
                    txtTong.Text = tong.ToString();
                }
            }
            catch { }
        }

        private void dgvMatHang_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            btnThemMH.PerformClick();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtSearchMH.Text.Trim().Length != 0)
            {
                try
                {
                    dgvMatHang.DataSource =
                        bll.MatHang.getMatHangSearchNhap(txtSearchMH.Text);
                }
                catch { }
            }
            else
            {
                dgvMatHang.DataSource = bll.MatHang.getMatHang();
            }
        }
    }
}