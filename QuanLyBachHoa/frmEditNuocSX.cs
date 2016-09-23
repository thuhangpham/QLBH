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
    public partial class frmEditNuocSX : Form
    {
        BaseBLL bll = new BaseBLL();
        bool them = false;
        private int mnh = 1;
        public frmEditNuocSX()
        {
            InitializeComponent();
        }
        void DataBind()
        {
            dataGridView1.DataSource = bll.NuocSanXuat.getNuocSanXuat();
            //for (int i = 0; i < dataGridView1.Rows.Count; i++)
            //    foreach (NuocSanXuatRecycle mh in bll.NuocSXRecycle.getNuocSanXuatRecycle())
            //        if (dataGridView1.Rows[i].Cells[1].Value.ToString() == mh.NuocSXR.ToString())
            //            dataGridView1.Rows.Remove(dataGridView1.Rows[i]);
        }

        private void frmEditNuocSX_Load(object sender, EventArgs e)
        {
            DataBind();
        }

        private void thêmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            them = true;
            label1.Text = "&Thêm nước sản xuất:";
            txtTenNuocSX.ResetText();
            tabControl1.SelectedTab = tabControl1.TabPages[0];
        }

        private void sửaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Text = "&Sửa nước sản xuất:";
            try
            {
                int r = dataGridView1.CurrentCell.RowIndex;
                mnh = int.Parse(dataGridView1.Rows[r].Cells[1].Value.ToString());
                txtTenNuocSX.Text = dataGridView1.Rows[r].Cells[1].Value.ToString();
                tabControl1.SelectedTab = tabControl1.TabPages[1];
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnLuu_Click_1(object sender, EventArgs e)
        {
            if (them)
            {
                //kiem tra nhap thong tin
                if (txtTenNuocSX.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Vui lòng nhập tên nước sản xuất ...", "Cảnh báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtTenNuocSX.Focus();
                    return;
                }
                if (bll.NuocSanXuat.insertNuocSanXuat(txtTenNuocSX.Text))
                {
                    them = false;
                    MessageBox.Show("Thêm nước \"" + txtTenNuocSX.Text + "\" thành công!", "Thông báo");
                    DataBind();
                    tabControl1.SelectedTab = tabControl1.TabPages[0];
                }
                else MessageBox.Show("Loi");
            }
            else
            {
                bll.NuocSanXuat.updateNuocSanXuat(mnh, txtTenNuocSX.Text);
                MessageBox.Show("Sửa nước thành công!", "Thông báo");
                DataBind();
                tabControl1.SelectedTab = tabControl1.TabPages[0];
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void xóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                int r = dataGridView1.CurrentCell.RowIndex;
                mnh = int.Parse(dataGridView1.Rows[r].Cells[1].Value.ToString());
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            DialogResult rs = MessageBox.Show("Bạn thật sự muốn xóa!", "Xóa",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (DialogResult.OK == rs)
            {
                if(bll.NuocSanXuat.deleteNuocSanXuat(mnh))
                {
                //bll.NuocSXRecycle.InsertNuocSanXuatRecycle(mnh);
                //dataGridView1.Rows.Remove
                //    (dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex]);
                    MessageBox.Show("Xóa nước sản xuất thành công!", "Thông báo");
                    //DataBind();
                    //tabControl1.SelectedTab = tabControl1.TabPages[1];
                }
                else MessageBox.Show("Bạn không thể xóa nước sản xuất này!", "Cảnh báo",
                    MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }

        }
    }
}
