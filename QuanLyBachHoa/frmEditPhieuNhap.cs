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
using DataAccessLayer.Models;
namespace QuanLyBachHoa
{
    public partial class frmEditPhieuNhap : Form
    {
        private string filePath = Application.StartupPath + "\\User.dat";
        ReadAccount ra = new ReadAccount(); string[] contents;
        BaseBLL bll = new BaseBLL();
        Context context = new Context();
        string maNCC = "" ;
        public frmEditPhieuNhap()
        {
            InitializeComponent();

        }
        private void DataBind()
        {
            dgvMatHang.DataSource = bll.MatHang.getMatHangNhap();
            //
            //
            //
            cbNhanVien.DataSource = bll.NhanVien.getNhanVien();
            cbNhanVien.ValueMember = "NhanVienId";
            cbNhanVien.DisplayMember = "TenNhanVien";
            tvNH_ControlAdded();
            contents = ra.ReadFile(filePath);
            //if (!bll.NhanVien.isAdmin(int.Parse(contents[0])))
            //{
               
            //} 
        }

        private void frmEditPhieuNhap_Load(object sender, EventArgs e)
        {
            DataBind();
            cbNhanVien.SelectedValue = int.Parse(contents[0]);
            cbNhanVien.Enabled = false; 
        }
        private void tvNH_DoubleClick(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            try
            {
                dgvMatHang.DataSource = bll.MatHang.getMatHangTheoLmh
                    (int.Parse(tvNH.SelectedNode.Tag.ToString()));
            }
            catch (SqlException ex) { MessageBox.Show(ex.Message); }
        }
        private void tvNH_ControlAdded()
        {
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

        private void button1_Click(object sender, EventArgs e)
        {
            frmEditNhanVien frm = new frmEditNhanVien();
            frm.cbGT.SelectedItem = "Nu";
            frm.Show();
        }
        private void Huy()
        {
            int r = dgvCTPN.Rows.Count;
            for (int i = 1; i <= r; i++)
            {
                DataGridViewRow row = new DataGridViewRow();
                row = dgvCTPN.Rows[0];
                dgvCTPN.Rows.Remove(row);

            }

            txtTong.Text = "0";
        }
        private void btnHuy_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn có muốn xóa toàn bộ mặt hàng đã thêm", "Thông báo");
            if (DialogResult.OK == rs)
            {
                btnHuy.Enabled = false;
                btnThanhToan.Enabled = false;
                Huy();
            }
        }
        decimal tong;
        private void btnThemMH_Click(object sender, EventArgs e)
        {
            try
            {
                // dong hien tai
                int RowIndex = dgvMatHang.CurrentCell.RowIndex;
                // lay gia nhap o dgv mat hang
                decimal gianhap = decimal.Parse(dgvMatHang.Rows[RowIndex].Cells[3].Value.ToString());
                int mh = int.Parse(dgvMatHang.Rows[RowIndex].Cells[0].Value.ToString());
                // neu chon thay doi gia nhap
                if (nudGiaNhap.Enabled == true)
                    gianhap = decimal.Parse(nudGiaNhap.Value.ToString());
                // update gia nhap, gia ban
                if (gianhap.ToString() != dgvMatHang.Rows[RowIndex].Cells[3].Value.ToString())
                {
                    // neu gia ban < gia nhap thi reset lai = gia nhap
                    MatHang mhang = context.MatHangs.Find(mh);
                    decimal gb = mhang.GiaBan;
                    if (gb < gianhap)
                        bll.MatHang.updateMatHangGiaBan(mh, gianhap);
                    bll.MatHang.updateMatHangGiaNhap(mh, gianhap);
                }
                int sl = (int)numericUpDown1.Value;
                decimal dg = 1;
                int i;
                DataGridViewRow row = new DataGridViewRow();
                DataGridViewCell cell;
                cell = new DataGridViewTextBoxCell();
                if (nudGiaNhap.Enabled == true)
                    dgvMatHang.DataSource = bll.MatHang.getMatHangNhap();
                for (i = 0; i < dgvCTPN.RowCount; i++)
                {
                    cell.Value = dgvMatHang.Rows[RowIndex].Cells[0].Value.ToString();
                    if (dgvCTPN.Rows[i].Cells[0].Value.ToString() == cell.Value.ToString())
                    {
                        sl = (int.Parse(dgvCTPN.Rows[i].Cells[3].Value.ToString()) + sl);
                        dg = sl * gianhap;
                        dgvCTPN.Rows[i].Cells[3].Value = sl.ToString();
                        dgvCTPN.Rows[i].Cells[4].Value = dg.ToString();
                        tong = 0;

                        for (int j = 0; j < dgvCTPN.Rows.Count; j++)
                            tong += decimal.Parse(dgvCTPN.Rows[j].Cells[4].Value.ToString());
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
                // gia nhap
                cell = new DataGridViewTextBoxCell();
                cell.Value = gianhap;
                row.Cells.Add(cell);
                // so luong
                cell = new DataGridViewTextBoxCell();
                cell.Value = sl.ToString();
                row.Cells.Add(cell);
                // don gia
                cell = new DataGridViewTextBoxCell();
                cell.Value = (sl * gianhap).ToString();
                row.Cells.Add(cell);
                dgvCTPN.Rows.Add(row);

                tong = 0;
                for (int j = 0; j < dgvCTPN.Rows.Count; j++)
                    tong += decimal.Parse(dgvCTPN.Rows[j].Cells[4].Value.ToString());
                txtTong.Text = tong.ToString();

                btnHuy.Enabled = true;
                btnThanhToan.Enabled = true;
                nudGiaNhap.Enabled = false;
            }
            catch { }
            // them 
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if(maNCC=="")
            {
                MessageBox.Show("Vui lòng chọn nhà cung cấp!","Thông báo");
                return;
            }
            btnThanhToan.Enabled = false;
            int mnv = -1, mncc = -1;
            mnv = int.Parse(cbNhanVien.SelectedValue.ToString());
            mncc = int.Parse(maNCC);
            tong = decimal.Parse(txtTong.Text);
            if (bll.PhieuNhap.insertPhieuNhap(
                DateTime.Parse(dateTimePicker1.Text), mncc, tong, mnv, txtGC.Text))
            {
                tong = 0;
                for (int i = 0; i < dgvCTPN.Rows.Count; i++)
                {
                    int mahang = int.Parse(dgvCTPN.Rows[i].Cells[0].Value.ToString());
                    string tenhang = dgvCTPN.Rows[i].Cells[1].Value.ToString();
                    decimal dg = decimal.Parse(dgvCTPN.Rows[i].Cells[4].Value.ToString());
                    int sl = int.Parse(dgvCTPN.Rows[i].Cells[3].Value.ToString());
                    bll.PhieuNhap.insertCTPhieuNhap
                        (context.PhieuNhaps.Max(m => m.PhieuNhapId), mahang, sl, dg);
                }
                Huy();
                btnHuy.Enabled = false;
                btnThanhToan.Enabled = false;
            }
            else MessageBox.Show("Lỗi","Eror");
        }

        private void btnThemNCC_Click(object sender, EventArgs e)
        {
            ( new frmEditNhaCC()).Show();
        }

        private void btnGiaNhap_Click(object sender, EventArgs e)
        {
            nudGiaNhap.Value = decimal.Parse(
                dgvMatHang.Rows[dgvMatHang.
                CurrentCell.RowIndex].Cells[3].Value.ToString());

            nudGiaNhap.Enabled = true;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            DataBind();
        }

        private void dgvCTPN_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                DialogResult rs = MessageBox.Show("Bạn chắc chán muốn xóa mặt hàng này!", "Xóa?", MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Question);
                if (DialogResult.OK == rs)
                {
                    dgvCTPN.Rows.Remove(dgvCTPN.Rows[dgvCTPN.CurrentCell.RowIndex]);
                    tong = 0;
                    for (int j = 0; j < dgvCTPN.Rows.Count; j++)
                        tong += decimal.Parse(dgvCTPN.Rows[j].Cells[4].Value.ToString());
                    txtTong.Text = tong.ToString();
                }
            }
            catch { }
        }

        private void dgvMatHang_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            btnThemMH.PerformClick();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (txtSearchMH.Text.Trim().Length != 0)
                try
                {
                    dgvMatHang.DataSource =
                        bll.MatHang.getMatHangSearchNhap(txtSearchMH.Text);
                }
                catch { }
            else
                dgvMatHang.DataSource = bll.MatHang.getMatHang();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmNhaCC frm = new frmNhaCC(setValue);
            frm.Chon.Enabled = true;
            frm.thoat.Enabled = true;
            frm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            frm.ShowDialog();
        }
        public void setValue(string NhaCCId, string TenNhaCC)
        {
            maNCC = NhaCCId;
            txtNcc.Text = TenNhaCC;
        }
    }
}
