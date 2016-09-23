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
using DataAccessLayer.Models;
namespace QuanLyBachHoa
{
    public partial class frmMatHang : Form
    {
        ImageList myImageList = new ImageList();
        BaseBLL bll = new BaseBLL();
        private bool sua = false;
        string filePath = Application.StartupPath + "\\MatHang.dat";
        public frmMatHang()
        {
            InitializeComponent();
        }
        private void DataBind()
        {
            dgvMatHang.DataSource = bll.MatHang.getMatHangFull();
            dgvNH.DataSource = bll.NhomHang.getNhomHang();
            tvNH_ControlAdded();
            myImageList.Images.Add(Properties.Resources.product);
            tvNH.ImageList = myImageList;

        }
        private void tvNH_ControlAdded()
        {
            int t = tvNH.Nodes.Count;
            int r = dgvNH.Rows.Count;

            for (int i = 0; i < t; i++)
                tvNH.Nodes[0].Remove();
            for (int i = 0; i < r; i++)
            {
                tvNH.Nodes.Add(dgvNH.Rows[i].Cells[1].Value.ToString());
                tvNH.Nodes[i].Tag = dgvNH.Rows[i].Cells[0].Value.ToString();
            }
            //for (int i = 0; i < tvNH.Nodes.Count; i++)
            //{

            //    foreach (NhomHangRecycle mh
            //        in bll.NhomHangRecycle.getNhomHangRecycle())
            //        if (tvNH.Nodes[i].Tag.ToString() == mh.NhomHangR.ToString())
            //            tvNH.Nodes.Remove(tvNH.Nodes[i]);
            //}
        }

        private void frmMatHang_Load(object sender, EventArgs e)
        {
            DataBind();
            try
            {
                tvNH.SelectedNode = tvNH.Nodes[0];
            }
            catch { }
        }

        private void tvNH_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                dgvMatHang.DataSource = bll.MatHang.
                    getMatHangTheoNhomHangFull(int.Parse(tvNH.SelectedNode.Tag.ToString().Trim()));
            }
            catch { }
        }
        private void SuaMH()
        {
            sua = true;
            frmEditMatHang frm = new frmEditMatHang();
            frm.edit = sua;
            int r = dgvMatHang.CurrentCell.RowIndex;
            //non
            //frm.txtTenMH.DataBindings.Clear();
            //frm.txtTenMH.DataBindings.Add("Text", dsmh.Tables[0], "TenMH");
            frm.txtMaHang.Text = dgvMatHang.Rows[r].Cells[0].Value.ToString();
            frm.txtTenMH.Text = dgvMatHang.Rows[r].Cells[1].Value.ToString();
            frm.txtDVT.Text = dgvMatHang.Rows[r].Cells[2].Value.ToString();
            frm.txtGiaNhap.Text = dgvMatHang.Rows[r].Cells[3].Value.ToString();
            frm.txtGiaBan.Text = dgvMatHang.Rows[r].Cells[4].Value.ToString();
            frm.txtTrongLuong.Text = dgvMatHang.Rows[r].Cells[5].Value.ToString();
            frm.txtHSD.Text = dgvMatHang.Rows[r].Cells[6].Value.ToString();
            frm.mnsx = dgvMatHang.Rows[r].Cells[7].Value.ToString();
            frm.nh = dgvMatHang.Rows[r].Cells[8].Value.ToString();
            frm.txtGC.Text = dgvMatHang.Rows[r].Cells[9].Value.ToString();
            frm.ShowDialog();
        }
        private void thêmToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmEditMatHang frm = new frmEditMatHang();
            frm.ShowDialog();
        }

        private void sửaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SuaMH();
        }

        private void refresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataBind();
        }


        private void thêmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new frmEditLoaiMatHang()).ShowDialog();
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataBind();
        }

        private void xóaToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            string mmh = "";
            try
            {
                mmh = (dgvMatHang.Rows[dgvMatHang.CurrentRow.Index]
                    .Cells[0].Value.ToString());
            }
            catch { return; }
            if (mmh != "")
            {
                DialogResult rs = MessageBox.Show("Bạn chắc chắn muốn xóa!", "Xóa?",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    if (bll.MatHang.deleteMatHang(int.Parse(mmh)))
                    {
                        MessageBox.Show("Xóa mặt hàng thành công!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                        DataBind();
                    }
                    else MessageBox.Show("Mặt hàng này không thể xóa!", "Error",
                  MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void sửaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmEditLoaiMatHang frm = new frmEditLoaiMatHang();
            frm.edit = true;
            frm.txtTenNhomHang.Text = tvNH.SelectedNode.Text;
            frm.maNH = tvNH.SelectedNode.Tag.ToString();
            frm.ShowDialog();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void dgvMatHang_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            SuaMH();
        }

        private void xóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn chắc chắn ?", "Xóa?",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            int mnh = int.Parse(tvNH.SelectedNode.Tag.ToString());
            if (rs == DialogResult.Yes)
            {
                if (bll.NhomHang.deleteNhomHang(mnh))
                    //                bll.NhomHangRecycle.InsertNhomHangRecycle
                    //                 (int.Parse(tvNH.SelectedNode.Tag.ToString()));
                    //            tvNH.Nodes.Remove(tvNH.SelectedNode);
                    MessageBox.Show("Xóa nhóm hàng thành công!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Không thể xóa nhóm hàng này!", "Thông báo",
                                 MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
    }
}
