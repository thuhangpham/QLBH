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
using System.Threading;
using BusinessLogicLayer.BaseBLL;
using DataAccessLayer;
namespace QuanLyBachHoa
{
    // uy quyen thay doi gia tri textBox
    public delegate void SendKH(string KhachHangId, string TenKhachHang);
    public partial class frmQuanLyBanHang : Form
    {
        ImageList myImageList = new ImageList();
        private string filePath = Application.StartupPath + "\\User.dat";
        ReadAccount ra = new ReadAccount(); string[] contents;
        Context context = new Context();
        BaseBLL bll = new BaseBLL();
        private decimal tong = 0;
        private string KhachHangId = "";
        public frmQuanLyBanHang()
        {
            InitializeComponent();
        }
        private void DataBind()
        {
            dgvMatHang.DataSource = bll.MatHang.getMatHang();
            // do du lieu vao combobox nhan vien
            cbNhanVien.DataSource = bll.NhanVien.getNhanVien();
            cbNhanVien.ValueMember = "NhanVienId";
            cbNhanVien.DisplayMember = "TenNhanVien";

            contents = ra.ReadFile(filePath);
            //if (!bll.NhanVien.isAdmin(int.Parse(contents[0])))
            {
                cbNhanVien.SelectedValue = int.Parse(contents[0]);
                cbNhanVien.Enabled = false;
            }
            myImageList.Images.Add(Properties.Resources.product);
            tvNH.ImageList = myImageList;
        }
        private void frmQuanLyBanHang_Load(object sender, EventArgs e)
        {
            DataBind();
            tvNH_ControlAdded();
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
        // them vao ct hoa don
        private void dgvMatHang_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            btnThem.PerformClick();
        }

        private void tvNH_DoubleClick(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            try
            {
                dgvMatHang.DataSource =
                    bll.MatHang.getMatHangTheoLmh
                    (int.Parse(tvNH.SelectedNode.Tag.ToString().Trim()));
            }
            catch { }
        }
      
        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if(KhachHangId.Trim().Length==0)
            {
                MessageBox.Show("Vui lòng chọn tên khách hàng!","Cảnh báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnSearch.Focus();
                return;
            }
            btnThanhToan.Enabled = false;
            // ma nhan vien
            int mnv = -1;
            mnv = int.Parse(cbNhanVien.SelectedValue.ToString());
            tong = decimal.Parse(txtTong.Text);
            if (
            bll.HoaDon.insertHoaDon(DateTime.Now.Date, int.Parse(KhachHangId), mnv, tong))
            {
                tong = 0;
                for (int i = 0; i < dgvCTHD.Rows.Count; i++)
                {
                    int mahang = int.Parse(dgvCTHD.Rows[i].Cells[0].Value.ToString());
                    string tenhang = dgvCTHD.Rows[i].Cells[1].Value.ToString();
                    string dvt = dgvCTHD.Rows[i].Cells[2].Value.ToString();
                    int sl = int.Parse(dgvCTHD.Rows[i].Cells[4].Value.ToString());
                    decimal dg = decimal.Parse(dgvCTHD.Rows[i].Cells[5].Value.ToString());
                    if (!bll.HoaDon.insertCTHoaDon(context.HoaDons.Max(m => m.HoaDonId)
                        , mahang, sl, dg))
                    {
                        bll.HoaDon.deleteHoaDon(context.HoaDons.Max(m => m.HoaDonId));
                        MessageBox.Show("Không thể thêm hóa đơn!", "Lỗi");
                        return;
                    }
                }
                btnHuy.PerformClick();
                btnHuy.Enabled = false;
                btnThanhToan.Enabled = false;
            }
            else MessageBox.Show("Không thể thêm hóa đơn!","Lỗi");
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataBind();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            btnThanhToan.Enabled = false;
            btnHuy.Enabled = false;
            int r = dgvCTHD.Rows.Count;
            for (int i = 1; i <= r; i++)
            {
                DataGridViewRow row = new DataGridViewRow();
                row = dgvCTHD.Rows[0];
                dgvCTHD.Rows.Remove(row);

            }
            txtTong.Text = "0";
            txtTienKhach.Text = "0";
            txtTienTra.Text = "0";
        }

        private void btnTienKhach_TextChanged(object sender, EventArgs e)
        {
            try
            {
                decimal tong = decimal.Parse(txtTong.Text);
                decimal tientra = decimal.Parse(txtTienKhach.Text);
                txtTienTra.Text = (tientra - tong).ToString();
            }
            catch { }
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                int RowIndex = dgvMatHang.CurrentCell.RowIndex;
                int sl = (int)nudSL.Value;
                decimal dg = 1;
                int i;
                DataGridViewRow row = new DataGridViewRow();
                DataGridViewCell cell;
                cell = new DataGridViewTextBoxCell();
                for (i = 0; i < dgvCTHD.RowCount; i++)
                {
                    cell = new DataGridViewTextBoxCell();
                    cell.Value = dgvMatHang.Rows[RowIndex].Cells[0].Value.ToString();
                    if (dgvCTHD.Rows[i].Cells[0].Value.ToString() == cell.Value.ToString())
                    {
                        sl = (int.Parse(dgvCTHD.Rows[i].Cells[4].Value.ToString()) + sl);
                        dg = sl * decimal.Parse(dgvCTHD.Rows[i].Cells[3].Value.ToString());
                        dgvCTHD.Rows[i].Cells[4].Value = sl.ToString();
                        dgvCTHD.Rows[i].Cells[5].Value = dg.ToString();
                        tong = 0;

                        for (int j = 0; j < dgvCTHD.Rows.Count; j++)
                        {
                            tong += decimal.Parse(dgvCTHD.Rows[j].Cells[5].Value.ToString());
                            txtTong.Text = tong.ToString();
                            txtTienKhach.Text = tong.ToString();
                        }
                        return;
                    }
                }
                // ma
                cell = new DataGridViewTextBoxCell();
                cell.Value = dgvMatHang.Rows[RowIndex].Cells[0].Value.ToString();
                row.Cells.Add(cell);
                // tenmh
                cell = new DataGridViewTextBoxCell();
                cell.Value = dgvMatHang.Rows[RowIndex].Cells[1].Value.ToString();
                row.Cells.Add(cell);
                // dvt
                cell = new DataGridViewTextBoxCell();
                cell.Value = dgvMatHang.Rows[RowIndex].Cells[2].Value.ToString();
                row.Cells.Add(cell);
                // gia ban
                cell = new DataGridViewTextBoxCell();
                cell.Value = dgvMatHang.Rows[RowIndex].Cells[3].Value.ToString();
                row.Cells.Add(cell);
                // so luong
                cell = new DataGridViewTextBoxCell();
                cell.Value = sl.ToString();
                row.Cells.Add(cell);
                // dom gia
                cell = new DataGridViewTextBoxCell();
                cell.Value = dgvMatHang.Rows[RowIndex].Cells[3].Value.ToString();
                row.Cells.Add(cell);
                dgvCTHD.Rows.Add(row);
                //
                tong = 0;
                for (int j = 0; j < dgvCTHD.Rows.Count; j++)
                {
                    tong = decimal.Parse(dgvCTHD.Rows[j].Cells[5].Value.ToString()) + tong;
                    txtTong.Text = tong.ToString();
                    txtTienKhach.Text = tong.ToString();
                }
                btnThanhToan.Enabled = true;
                btnHuy.Enabled = true;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void dgvKhachHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvCTHD_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                DialogResult rs = MessageBox.Show("Bạn chắc chán muốn xóa mặt hàng này?", "Xóa?", MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Question);
                if (DialogResult.OK == rs)
                {
                    dgvCTHD.Rows.Remove(dgvCTHD.Rows[dgvCTHD.CurrentCell.RowIndex]);
                    tong = 0;
                    for (int j = 0; j <dgvCTHD.Rows.Count; j++)
                    {
                        tong += decimal.Parse(dgvCTHD.Rows[j].Cells[5].Value.ToString());
                    }
                        txtTong.Text = tong.ToString();
                        txtTienKhach.Text = tong.ToString();

                }
            }
            catch { }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            frmSerchKhachHang frm = new frmSerchKhachHang(setValue);
            frm.ShowDialog();
        }
        public void setValue(string KhachHangId, string TenKhachHang)
        {
            txtKH.Text = TenKhachHang;
            this.KhachHangId = KhachHangId;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            DataBind();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dgvMatHang.DataSource = bll.MatHang.getMatHangSearch(txtSearchMH.Text);
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            (new frmThemKH()).ShowDialog();
        }
 

    }
}
