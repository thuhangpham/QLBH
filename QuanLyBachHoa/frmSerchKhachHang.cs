using BusinessLogicLayer.BaseBLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBachHoa
{
    public partial class frmSerchKhachHang : Form
    {
        event SendKH send;
        BaseBLL bll = new BaseBLL();
        public frmSerchKhachHang(SendKH sender)
        {
            InitializeComponent();
            this.send = sender;
        }
        void DataBind()
        {
            dgvKhachHang.DataSource = bll.KhachHang.getKhachHangBanHang();
        }
        private void frmSerchKhachHang_Load(object sender, EventArgs e)
        {
            DataBind();
        }
        
        private void btnChon_Click(object sender, EventArgs e)
        {
            try
            {
                int r = dgvKhachHang.CurrentCell.RowIndex;
                this.send(dgvKhachHang.Rows[r].Cells[0].Value.ToString(),
                    dgvKhachHang.Rows[r].Cells[1].Value.ToString());
                this.Close();
            }
            catch { }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtSearchKH.Text.Trim().Length != 0)
            {
                try
                {
                    dgvKhachHang.DataSource =
                        bll.KhachHang.getKhachHangSearch(txtSearchKH.Text.Trim());
                }
                catch { }
            }
            else dgvKhachHang.DataSource =
                      bll.KhachHang.getKhachHangBanHang();
        }

    }
}
