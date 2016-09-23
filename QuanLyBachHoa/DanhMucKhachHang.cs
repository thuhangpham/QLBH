using BusinessLogicLayer.Repository;
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
    public partial class frmKhachHang : Form
    {
        ImageList myImageList = new ImageList();
        private string filePath = Application.StartupPath + "\\User.dat";
        ReadAccount ra = new ReadAccount(); string[] contents;
        private BaseBLL bll = new BaseBLL();
        private bool sua = false;
        private bool sualkh = false;
        // truyen du lieu
        public frmKhachHang()
        {
            InitializeComponent();
        }
        private void DataBind()
        {
            contents = ra.ReadFile(filePath);
            dgvKH.DataSource = bll.KhachHang.getKhachHang();
            tvLKH_ControlAdded();
            myImageList.Images.Add(Properties.Resources.user);
            tvLKH.ImageList = myImageList;

        }
        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            DataBind();
        }
        #region thêm, sua, xoa khach hang
        void ThemKH()
        {
            frmThemKH frm = new frmThemKH();
            frm.txtMaKH.Enabled = false;
            frm.cbGT.SelectedItem = "Nu";
            //
            frm.cbLKH.DataSource = bll.LoaiKhachHang.getLoaiKhachHang();
            frm.cbLKH.DisplayMember = "TenLoaiKhachHang";
            frm.cbLKH.ValueMember = "LoaiKhachHangId";
            frm.ShowDialog();
        }
        private void thêmToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ThemKH();
        }

        private void thêmMớiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThemKH();
        }

        private void refresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataBind();
        }
        private void SuaKH()
        {
            sua = true;
            frmThemKH frm = new frmThemKH();
            frm.edit = sua;
            frm.txtMaKH.Enabled = false;
            int r = dgvKH.CurrentCell.RowIndex;
            frm.txtMaKH.Text = dgvKH.Rows[r].Cells[0].Value.ToString();
            frm.txtTenKH.Text = dgvKH.Rows[r].Cells[1].Value.ToString();
            frm.gt = dgvKH.Rows[r].Cells[2].Value.ToString();
            frm.txtDiaChi.Text = dgvKH.Rows[r].Cells[3].Value.ToString();
            frm.txtEmail.Text = dgvKH.Rows[r].Cells[4].Value.ToString();
            frm.txtSDT.Text = dgvKH.Rows[r].Cells[5].Value.ToString();
            frm.lkh = dgvKH.Rows[r].Cells[6].Value.ToString();
            frm.txtGC.Text = dgvKH.Rows[r].Cells[7].Value.ToString();
            frm.Show();
        }
        private void sửaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SuaKH();
        }

        private void sửaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SuaKH();
        }

        private void tvLKH_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                dgvKH.DataSource = bll.KhachHang.
                    getKhachHangTheoLKH
                    (int.Parse(tvLKH.SelectedNode.Tag.ToString().Trim()));
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

        }

        private void thêmToolStripMenuItem_Click(object sender, EventArgs e)
        {

            (new frmEditLKH()).Show();
        }

        private void xóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SuaLKH();
        }

        private void XoaKH()
        {
            try
            {
                int r = dgvKH.CurrentCell.RowIndex;
                int mkh = int.Parse(dgvKH.Rows[r].Cells[0].Value.ToString());
                DialogResult rs = MessageBox.Show("Bạn chắc chắn muốn xóa!", "Xóa?",
                   MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (rs == DialogResult.Yes)
                {
                    if (bll.KhachHang.deleteKhachHang(mkh))
                    {
                    //bll.KhachHangRecycle.InsertKhachHangRecycle(mkh);
                    //dgvKH.Rows.Remove(dgvKH.Rows[dgvKH.CurrentCell.RowIndex]);
                    MessageBox.Show("Xóa Khách hàng thành công!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DataBind();
                    }
                    else MessageBox.Show("Xóa Khách hàng loi!", "Error",
                       MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch { }
        }
        private void xóaToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            XoaKH();
        }

        private void xóaToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            XoaKH();
        }


        #endregion thêm, sua, xoa khach hang
        #region edit Loại kh
        private void SuaLKH()
        {
            sualkh = true;
            frmEditLKH frm = new frmEditLKH();
            frm.edit = sualkh;
            try
            {
                frm.txtTenLKH.Text = tvLKH.SelectedNode.Text.ToString();
                frm.txtMaLKH.Text = tvLKH.SelectedNode.Tag.ToString();
                //MessageBox.Show(malkh.ToString());
                frm.txtGC.Text = bll.LoaiKhachHang.getGhiChuLoaiKhachHang
                    (int.Parse(tvLKH.SelectedNode.Tag.ToString()));
                frm.txtMaLKH.Enabled = false;
                frm.Show();
            }
            catch { }
        }
        private void XoaLKH()
        {
            if (!bll.NhanVien.isAdmin(int.Parse(contents[0])))
            {
                MessageBox.Show("Bạn không phải Admin!!!", "Cảnh báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                int r = tvLKH.SelectedNode.Index;
                DialogResult rs = MessageBox.Show("Bạn chắc chắn Xóa? -_-\n",
                    "Xóa?",
                   MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    if (bll.LoaiKhachHang.deleteLoaiKhachHang(int.Parse(tvLKH.SelectedNode.Tag.ToString())))
                    {
                    //bll.LoaiKhachHangRecycle.InsertLoaiKhachHangRecycle
                    //    (int.Parse(tvLKH.SelectedNode.Tag.ToString()));
                   // tvLKH.Nodes.Remove(tvLKH.SelectedNode);
                    MessageBox.Show("Xóa Loại Khách hàng thành công!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DataBind();
                    }
                    else MessageBox.Show("Không thể xóa loại khách hàng này!", "Warning",
                           MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch { }
        }
        #endregion edit Loại kh

        private void suaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SuaLKH();
        }

        
        private void tvLKH_ControlAdded()
        {
            try
            {
                dgvLKH.DataSource = bll.LoaiKhachHang.getLoaiKhachHang();
                int r = dgvLKH.Rows.Count;
                tvLKH.Refresh();
                int t = tvLKH.Nodes.Count;
                for (int i = 0; i < t; i++)
                    tvLKH.Nodes[0].Remove();
                for (int i = 0; i < r; i++)
                {
                    tvLKH.Nodes.Add(dgvLKH.Rows[i].Cells[1].Value.ToString());
                    tvLKH.Nodes[i].Tag = dgvLKH.Rows[i].Cells[0].Value.ToString();
                }
            }
            catch { }
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // cap nhat va hien thi danh sach moi
            DataBind();
        }

        private void tvLKH_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            XoaLKH();
        }

        private void sửaToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            SuaLKH();
        }

        private void dgvKH_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            SuaKH();
        }

        private void xóaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            XoaLKH();
        }

        private void cMenuKH_Opening(object sender, CancelEventArgs e)
        {

        }

    }
}
