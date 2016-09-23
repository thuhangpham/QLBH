using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBachHoa
{
    public partial class frmTroGiup : Form
    {
        ImageList imgList = new ImageList();
        public frmTroGiup()
        {
            InitializeComponent();
        }
        void chuChay()
        {
            try
            {
                while (label3.Left>= -label3.Width)
                {
                    while (label3.Location.X >= -label3.Width)
                    {
                        Application.DoEvents();
                        label3.Location = new Point(label3.Location.X - 1,
                            label3.Location.Y);
                        Thread.Sleep(10);
                    }
                    if (label3.Location.X < -label3.Width)
                        label3.Location = new Point(this.Width, label3.Location.Y);
                }
            }
            catch { }

        }
        private void frmTroGiup_Load(object sender, EventArgs e)
        {
            label3.Location = new Point(this.Width - 10, label3.Location.Y);
            chuChay();
        }
    }
}