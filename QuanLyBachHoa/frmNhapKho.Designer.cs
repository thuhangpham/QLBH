namespace QuanLyBachHoa
{
    partial class frmNhapKho
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvNhapHang = new System.Windows.Forms.DataGridView();
            this.MaPN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNhaCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GhiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCTNhapHang = new System.Windows.Forms.DataGridView();
            this.MH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblCTPN = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhapHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTNhapHang)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvNhapHang
            // 
            this.dgvNhapHang.AllowUserToAddRows = false;
            this.dgvNhapHang.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvNhapHang.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvNhapHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhapHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaPN,
            this.NgayNhap,
            this.TenNhaCC,
            this.TenNV,
            this.TongTien,
            this.GhiChu});
            this.dgvNhapHang.GridColor = System.Drawing.SystemColors.WindowFrame;
            this.dgvNhapHang.Location = new System.Drawing.Point(0, 28);
            this.dgvNhapHang.Name = "dgvNhapHang";
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dgvNhapHang.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvNhapHang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNhapHang.Size = new System.Drawing.Size(752, 323);
            this.dgvNhapHang.TabIndex = 1;
            this.dgvNhapHang.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvNhapHang_CellMouseDoubleClick);
            this.dgvNhapHang.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvNhapHang_MouseClick);
            // 
            // MaPN
            // 
            this.MaPN.DataPropertyName = "PhieuNhapId";
            this.MaPN.HeaderText = " Mã PN";
            this.MaPN.Name = "MaPN";
            this.MaPN.Width = 70;
            // 
            // NgayNhap
            // 
            this.NgayNhap.DataPropertyName = "NgayNhap";
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.NgayNhap.DefaultCellStyle = dataGridViewCellStyle1;
            this.NgayNhap.HeaderText = "Ngày";
            this.NgayNhap.Name = "NgayNhap";
            // 
            // TenNhaCC
            // 
            this.TenNhaCC.DataPropertyName = "TenNhaCungCap";
            this.TenNhaCC.HeaderText = "Nhà cung cấp";
            this.TenNhaCC.Name = "TenNhaCC";
            this.TenNhaCC.Width = 150;
            // 
            // TenNV
            // 
            this.TenNV.DataPropertyName = "TenNhanVien";
            this.TenNV.HeaderText = "Nhân viên";
            this.TenNV.Name = "TenNV";
            this.TenNV.Width = 130;
            // 
            // TongTien
            // 
            this.TongTien.DataPropertyName = "TongTien";
            dataGridViewCellStyle2.Format = "C1";
            dataGridViewCellStyle2.NullValue = null;
            this.TongTien.DefaultCellStyle = dataGridViewCellStyle2;
            this.TongTien.HeaderText = "Tổng tiền";
            this.TongTien.Name = "TongTien";
            this.TongTien.Width = 130;
            // 
            // GhiChu
            // 
            this.GhiChu.DataPropertyName = "GhiChu";
            this.GhiChu.HeaderText = "Ghi chú";
            this.GhiChu.Name = "GhiChu";
            this.GhiChu.Width = 130;
            // 
            // dgvCTNhapHang
            // 
            this.dgvCTNhapHang.AllowUserToAddRows = false;
            this.dgvCTNhapHang.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCTNhapHang.BackgroundColor = System.Drawing.Color.LightSeaGreen;
            this.dgvCTNhapHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCTNhapHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MH,
            this.GiaNhap,
            this.SL,
            this.DonGia});
            this.dgvCTNhapHang.GridColor = System.Drawing.SystemColors.Window;
            this.dgvCTNhapHang.Location = new System.Drawing.Point(758, 38);
            this.dgvCTNhapHang.Name = "dgvCTNhapHang";
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dgvCTNhapHang.RowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvCTNhapHang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCTNhapHang.Size = new System.Drawing.Size(235, 315);
            this.dgvCTNhapHang.TabIndex = 3;
            // 
            // MH
            // 
            this.MH.DataPropertyName = "TenMatHang";
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.MH.DefaultCellStyle = dataGridViewCellStyle4;
            this.MH.HeaderText = "Mặt hàng";
            this.MH.Name = "MH";
            this.MH.Width = 180;
            // 
            // GiaNhap
            // 
            this.GiaNhap.DataPropertyName = "GiaNhap";
            dataGridViewCellStyle5.Format = "C1";
            dataGridViewCellStyle5.NullValue = null;
            this.GiaNhap.DefaultCellStyle = dataGridViewCellStyle5;
            this.GiaNhap.HeaderText = "Giá nhập";
            this.GiaNhap.Name = "GiaNhap";
            this.GiaNhap.Width = 180;
            // 
            // SL
            // 
            this.SL.DataPropertyName = "SoLuong";
            this.SL.HeaderText = "Số lượng";
            this.SL.Name = "SL";
            // 
            // DonGia
            // 
            this.DonGia.DataPropertyName = "DonGia";
            dataGridViewCellStyle6.Format = "C1";
            dataGridViewCellStyle6.NullValue = null;
            this.DonGia.DefaultCellStyle = dataGridViewCellStyle6;
            this.DonGia.HeaderText = "Đơn giá";
            this.DonGia.Name = "DonGia";
            this.DonGia.Width = 150;
            // 
            // lblCTPN
            // 
            this.lblCTPN.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCTPN.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblCTPN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblCTPN.Location = new System.Drawing.Point(765, 9);
            this.lblCTPN.Name = "lblCTPN";
            this.lblCTPN.Size = new System.Drawing.Size(228, 23);
            this.lblCTPN.TabIndex = 4;
            this.lblCTPN.Text = "Chi tiết phiếu Nhập";
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolStripSeparator1,
            this.toolStripLabel2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 2);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(752, 30);
            this.toolStrip1.TabIndex = 5;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Image = global::QuanLyBachHoa.Properties.Resources.add;
            this.toolStripLabel1.IsLink = true;
            this.toolStripLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(59, 27);
            this.toolStripLabel1.Text = "Thêm";
            this.toolStripLabel1.Click += new System.EventHandler(this.thêmToolStripMenuItem_Click);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Image = global::QuanLyBachHoa.Properties.Resources.refresh_ogrange;
            this.toolStripLabel2.IsLink = true;
            this.toolStripLabel2.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(70, 27);
            this.toolStripLabel2.Text = "Refresh";
            this.toolStripLabel2.Click += new System.EventHandler(this.toolStripLabel2_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 30);
            // 
            // frmNhapKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(993, 353);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.lblCTPN);
            this.Controls.Add(this.dgvCTNhapHang);
            this.Controls.Add(this.dgvNhapHang);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmNhapKho";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phiếu nhập kho";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmNhapKho_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhapHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTNhapHang)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvNhapHang;
        private System.Windows.Forms.DataGridView dgvCTNhapHang;
        private System.Windows.Forms.Label lblCTPN;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPN;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNhaCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn GhiChu;
        private System.Windows.Forms.DataGridViewTextBoxColumn MH;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn SL;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGia;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;

    }
}