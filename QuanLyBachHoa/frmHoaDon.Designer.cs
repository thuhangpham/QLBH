namespace QuanLyBachHoa
{
    partial class frmHoaDon
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Chi tiết hóa đơn bán hàng theo mã hóa đơn");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Chi tiết hóa đơn theo ngày");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Tổng doanh thu theo ngày");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Hóa đơn của khách hàng");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Chi tiết hóa đơn của khách hàng");
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvHoaDon = new System.Windows.Forms.DataGridView();
            this.MaHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ngay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaKh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tvFillter = new System.Windows.Forms.TreeView();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvFillter = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFillter)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvHoaDon
            // 
            this.dgvHoaDon.AllowUserToAddRows = false;
            this.dgvHoaDon.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvHoaDon.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvHoaDon.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvHoaDon.ColumnHeadersHeight = 30;
            this.dgvHoaDon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaHD,
            this.Ngay,
            this.TenNV,
            this.MaKh,
            this.TenKH,
            this.TongTien});
            this.dgvHoaDon.Location = new System.Drawing.Point(1, 27);
            this.dgvHoaDon.Name = "dgvHoaDon";
            this.dgvHoaDon.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dgvHoaDon.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvHoaDon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHoaDon.Size = new System.Drawing.Size(267, 267);
            this.dgvHoaDon.TabIndex = 0;
            this.dgvHoaDon.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvHoaDon_CellMouseDoubleClick);
            this.dgvHoaDon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvHoaDon_MouseClick);
            // 
            // MaHD
            // 
            this.MaHD.DataPropertyName = "HoaDonId";
            this.MaHD.HeaderText = "Mã hóa đơn";
            this.MaHD.Name = "MaHD";
            this.MaHD.Width = 80;
            // 
            // Ngay
            // 
            this.Ngay.DataPropertyName = "Ngay";
            dataGridViewCellStyle1.NullValue = null;
            this.Ngay.DefaultCellStyle = dataGridViewCellStyle1;
            this.Ngay.HeaderText = "Ngày";
            this.Ngay.Name = "Ngay";
            this.Ngay.Width = 130;
            // 
            // TenNV
            // 
            this.TenNV.DataPropertyName = "TenNhanVien";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.TenNV.DefaultCellStyle = dataGridViewCellStyle2;
            this.TenNV.HeaderText = "Nhân viên";
            this.TenNV.Name = "TenNV";
            this.TenNV.Width = 200;
            // 
            // MaKh
            // 
            this.MaKh.DataPropertyName = "KhachHangId";
            this.MaKh.HeaderText = "Mã khách hàng";
            this.MaKh.Name = "MaKh";
            // 
            // TenKH
            // 
            this.TenKH.DataPropertyName = "TenKhachHang";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.TenKH.DefaultCellStyle = dataGridViewCellStyle3;
            this.TenKH.HeaderText = "Khách hàng";
            this.TenKH.Name = "TenKH";
            this.TenKH.Width = 205;
            // 
            // TongTien
            // 
            this.TongTien.DataPropertyName = "TongTien";
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Format = "C1";
            dataGridViewCellStyle4.NullValue = null;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.TongTien.DefaultCellStyle = dataGridViewCellStyle4;
            this.TongTien.HeaderText = "Tổng tiền";
            this.TongTien.Name = "TongTien";
            this.TongTien.Width = 160;
            // 
            // tvFillter
            // 
            this.tvFillter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tvFillter.BackColor = System.Drawing.Color.LightSteelBlue;
            this.tvFillter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tvFillter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tvFillter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tvFillter.Indent = 45;
            this.tvFillter.ItemHeight = 50;
            this.tvFillter.Location = new System.Drawing.Point(264, -1);
            this.tvFillter.Name = "tvFillter";
            treeNode1.Name = "MaHD";
            treeNode1.Tag = "0";
            treeNode1.Text = "Chi tiết hóa đơn bán hàng theo mã hóa đơn";
            treeNode2.Name = "Ngay";
            treeNode2.Tag = "1";
            treeNode2.Text = "Chi tiết hóa đơn theo ngày";
            treeNode3.Name = "TongNgay";
            treeNode3.Tag = "2";
            treeNode3.Text = "Tổng doanh thu theo ngày";
            treeNode4.Name = "hoadonKH";
            treeNode4.Tag = "3";
            treeNode4.Text = "Hóa đơn của khách hàng";
            treeNode5.Name = "CThoadonKH";
            treeNode5.Tag = "4";
            treeNode5.Text = "Chi tiết hóa đơn của khách hàng";
            this.tvFillter.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode5});
            this.tvFillter.Size = new System.Drawing.Size(437, 483);
            this.tvFillter.TabIndex = 2;
            this.tvFillter.DoubleClick += new System.EventHandler(this.tvFillter_DoubleClick);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(1, 297);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "Lọc dữ liệu";
            // 
            // dgvFillter
            // 
            this.dgvFillter.AllowUserToAddRows = false;
            this.dgvFillter.AllowUserToResizeRows = false;
            this.dgvFillter.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvFillter.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvFillter.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dgvFillter.ColumnHeadersHeight = 30;
            this.dgvFillter.Location = new System.Drawing.Point(1, 337);
            this.dgvFillter.Name = "dgvFillter";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFillter.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvFillter.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFillter.Size = new System.Drawing.Size(267, 145);
            this.dgvFillter.TabIndex = 5;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.DarkSalmon;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.MaximumSize = new System.Drawing.Size(1100, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(702, 28);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Image = global::QuanLyBachHoa.Properties.Resources.refresh;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(86, 24);
            this.toolStripMenuItem1.Text = "Refresh";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // frmHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ClientSize = new System.Drawing.Size(702, 485);
            this.Controls.Add(this.tvFillter);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.dgvHoaDon);
            this.Controls.Add(this.dgvFillter);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmHoaDon";
            this.Text = "Danh mục hóa đơn";
            this.Load += new System.EventHandler(this.frmHoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFillter)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView tvFillter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvHoaDon;
        private System.Windows.Forms.DataGridView dgvFillter;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ngay;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKh;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongTien;
    }
}