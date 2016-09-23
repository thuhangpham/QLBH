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
    public partial class frmSearchMH : Form
    {
        BaseBLL bll = new BaseBLL();
        //dùng để truyền hàm delegate bên form chính qua
        public SendStr send;
        //public frmSearchMH()
        //{
        //    InitializeComponent();
        //}
        // Tạo một phương thức khởi tạo mới
        public frmSearchMH(SendStr sender)
        {
            // Phương thức khởi tạo này ta sẽ gọi ở bên form 1
            InitializeComponent();
            this.send = sender;
        }
        private void DataBind()
        {
            dgvMatHang.DataSource = bll.MatHang.getMatHang();
        }
        private void txtSearchMH_TextChanged(object sender, EventArgs e)
        {
            if (txtSearchMH.Text.Trim().Length != 0)
            {
                try
                {
                    dgvMatHang.DataSource = bll.MatHang.getMatHangSearch(txtSearchMH.Text);
                }
                catch { }
            }
            else
                dgvMatHang.DataSource = bll.MatHang.getMatHang();
        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            int r = dgvMatHang.CurrentCell.RowIndex;
            // Tại sự kiện nhấn nút button bên form này,
            // ta sẽ gọi lại hàm delegate
            this.send(dgvMatHang.Rows[r].Cells[1].Value.ToString(),
                dgvMatHang.Rows[r].Cells[0].Value.ToString());
            // ta gọi như trên để gọi làm hàm bên form,
            // và truyền giá trị dgvMatHang.Rows[r].Cells[0].Value.ToString()
            // qua form 
            this.Close();
        }

        private void frmSearchMH_Load(object sender, EventArgs e)
        {
            DataBind();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
