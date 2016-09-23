namespace QuanLyBachHoa
{
    partial class frmKiemKe
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblCTPN = new System.Windows.Forms.Label();
            this.dgvCTPKK = new System.Windows.Forms.DataGridView();
            this.MH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gban = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SLNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SLton = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SLTrenQuay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gchu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvPKK = new System.Windows.Forms.DataGridView();
            this.MaPKK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GhiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.thêmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTPKK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPKK)).BeginInit();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCTPN
            // 
            this.lblCTPN.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCTPN.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblCTPN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblCTPN.Location = new System.Drawing.Point(459, 9);
            this.lblCTPN.Name = "lblCTPN";
            this.lblCTPN.Size = new System.Drawing.Size(242, 23);
            this.lblCTPN.TabIndex = 8;
            this.lblCTPN.Text = "Chi tiết phiếu kiểm kê";
            // 
            // dgvCTPKK
            // 
            this.dgvCTPKK.AllowUserToAddRows = false;
            this.dgvCTPKK.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCTPKK.BackgroundColor = System.Drawing.Color.SeaGreen;
            this.dgvCTPKK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCTPKK.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MH,
            this.gban,
            this.SLNhap,
            this.SL,
            this.DonGia,
            this.SLton,
            this.SLTrenQuay,
            this.gchu});
            this.dgvCTPKK.GridColor = System.Drawing.SystemColors.Window;
            this.dgvCTPKK.Location = new System.Drawing.Point(451, 46);
            this.dgvCTPKK.Name = "dgvCTPKK";
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dgvCTPKK.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvCTPKK.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCTPKK.Size = new System.Drawing.Size(520, 378);
            this.dgvCTPKK.TabIndex = 7;
            // 
            // MH
            // 
            this.MH.DataPropertyName = "TenMatHang";
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.MH.DefaultCellStyle = dataGridViewCellStyle1;
            this.MH.HeaderText = "Mặt hàng";
            this.MH.Name = "MH";
            this.MH.Width = 150;
            // 
            // gban
            // 
            this.gban.DataPropertyName = "GiaBan";
            dataGridViewCellStyle2.Format = "C1";
            dataGridViewCellStyle2.NullValue = null;
            this.gban.DefaultCellStyle = dataGridViewCellStyle2;
            this.gban.HeaderText = "Giá bán";
            this.gban.Name = "gban";
            this.gban.Width = 120;
            // 
            // SLNhap
            // 
            this.SLNhap.DataPropertyName = "SLNhap";
            dataGridViewCellStyle3.NullValue = null;
            this.SLNhap.DefaultCellStyle = dataGridViewCellStyle3;
            this.SLNhap.HeaderText = "SL nhập kho";
            this.SLNhap.Name = "SLNhap";
            // 
            // SL
            // 
            this.SL.DataPropertyName = "SLXuat";
            this.SL.HeaderText = "SL xuất kho";
            this.SL.Name = "SL";
            // 
            // DonGia
            // 
            this.DonGia.DataPropertyName = "SLBan";
            dataGridViewCellStyle4.NullValue = null;
            this.DonGia.DefaultCellStyle = dataGridViewCellStyle4;
            this.DonGia.HeaderText = "SL Bán";
            this.DonGia.Name = "DonGia";
            // 
            // SLton
            // 
            this.SLton.DataPropertyName = "SLTon";
            this.SLton.HeaderText = "SL Tồn kho";
            this.SLton.Name = "SLton";
            // 
            // SLTrenQuay
            // 
            this.SLTrenQuay.DataPropertyName = "SLTrenQuay";
            this.SLTrenQuay.HeaderText = "SL Trên quầy";
            this.SLTrenQuay.Name = "SLTrenQuay";
            // 
            // gchu
            // 
            this.gchu.DataPropertyName = "GhiChu";
            this.gchu.HeaderText = "Ghi chú";
            this.gchu.Name = "gchu";
            this.gchu.Width = 90;
            // 
            // dgvPKK
            // 
            this.dgvPKK.AllowUserToAddRows = false;
            this.dgvPKK.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvPKK.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvPKK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPKK.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaPKK,
            this.NgayNhap,
            this.TenNV,
            this.GhiChu});
            this.dgvPKK.GridColor = System.Drawing.SystemColors.WindowFrame;
            this.dgvPKK.Location = new System.Drawing.Point(0, 46);
            this.dgvPKK.Name = "dgvPKK";
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dgvPKK.RowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvPKK.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPKK.Size = new System.Drawing.Size(445, 377);
            this.dgvPKK.TabIndex = 5;
            this.dgvPKK.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvPKK_MouseClick);
            // 
            // MaPKK
            // 
            this.MaPKK.DataPropertyName = "PhieuKiemKeId";
            this.MaPKK.HeaderText = " Mã PKK";
            this.MaPKK.Name = "MaPKK";
            this.MaPKK.Width = 80;
            // 
            // NgayNhap
            // 
            this.NgayNhap.DataPropertyName = "NgayKK";
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.NgayNhap.DefaultCellStyle = dataGridViewCellStyle6;
            this.NgayNhap.HeaderText = "Ngày";
            this.NgayNhap.Name = "NgayNhap";
            // 
            // TenNV
            // 
            this.TenNV.DataPropertyName = "TenNhanVien";
            this.TenNV.HeaderText = "Nhân viên";
            this.TenNV.Name = "TenNV";
            this.TenNV.Width = 150;
            // 
            // GhiChu
            // 
            this.GhiChu.DataPropertyName = "GhiChu";
            this.GhiChu.HeaderText = "Ghi chú";
            this.GhiChu.Name = "GhiChu";
            this.GhiChu.Width = 70;
            // 
            // menuStrip2
            // 
            this.menuStrip2.AutoSize = false;
            this.menuStrip2.BackColor = System.Drawing.Color.Chocolate;
            this.menuStrip2.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip2.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.menuStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thêmToolStripMenuItem,
            this.refreshToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 3);
            this.menuStrip2.MaximumSize = new System.Drawing.Size(540, 40);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip2.Size = new System.Drawing.Size(445, 35);
            this.menuStrip2.TabIndex = 6;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // thêmToolStripMenuItem
            // 
            this.thêmToolStripMenuItem.Image = global::QuanLyBachHoa.Properties.Resources.add;
            this.thêmToolStripMenuItem.Name = "thêmToolStripMenuItem";
            this.thêmToolStripMenuItem.Size = new System.Drawing.Size(74, 31);
            this.thêmToolStripMenuItem.Text = "Thêm";
            this.thêmToolStripMenuItem.Click += new System.EventHandler(this.thêmToolStripMenuItem_Click);
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Image = global::QuanLyBachHoa.Properties.Resources.refresh;
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(86, 31);
            this.refreshToolStripMenuItem.Text = "Refresh";
            this.refreshToolStripMenuItem.Click += new System.EventHandler(this.refreshToolStripMenuItem_Click);
            // 
            // frmKiemKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(971, 427);
            this.Controls.Add(this.lblCTPN);
            this.Controls.Add(this.dgvCTPKK);
            this.Controls.Add(this.dgvPKK);
            this.Controls.Add(this.menuStrip2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmKiemKe";
            this.Text = "Kiểm kê";
            this.Load += new System.EventHandler(this.frmKiemKe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTPKK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPKK)).EndInit();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblCTPN;
        private System.Windows.Forms.DataGridView dgvCTPKK;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thêmToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgvPKK;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.DataGridViewTextBoxColumn MH;
        private System.Windows.Forms.DataGridViewTextBoxColumn gban;
        private System.Windows.Forms.DataGridViewTextBoxColumn SLNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn SL;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn SLton;
        private System.Windows.Forms.DataGridViewTextBoxColumn SLTrenQuay;
        private System.Windows.Forms.DataGridViewTextBoxColumn gchu;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPKK;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn GhiChu;
    }
}