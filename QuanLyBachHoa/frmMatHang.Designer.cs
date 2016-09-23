namespace QuanLyBachHoa
{
    partial class frmMatHang
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMatHang));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvMatHang = new System.Windows.Forms.DataGridView();
            this.mHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tMH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dvitinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrongLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HSD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nuocSX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoaiMH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gchu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tvNH = new System.Windows.Forms.TreeView();
            this.tcMH = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.thêmToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.sửaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xóaToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.refresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.thêmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sửaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.xóaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvNH = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatHang)).BeginInit();
            this.tcMH.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNH)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMatHang
            // 
            this.dgvMatHang.AllowUserToAddRows = false;
            this.dgvMatHang.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMatHang.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvMatHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMatHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mHang,
            this.tMH,
            this.Dvitinh,
            this.GiaNhap,
            this.gia,
            this.TrongLuong,
            this.HSD,
            this.nuocSX,
            this.LoaiMH,
            this.gchu});
            this.dgvMatHang.Location = new System.Drawing.Point(3, 39);
            this.dgvMatHang.Name = "dgvMatHang";
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dgvMatHang.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvMatHang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMatHang.Size = new System.Drawing.Size(380, 235);
            this.dgvMatHang.TabIndex = 25;
            this.dgvMatHang.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvMatHang_CellMouseDoubleClick);
            // 
            // mHang
            // 
            this.mHang.DataPropertyName = "MatHangId";
            this.mHang.HeaderText = "Mã hàng";
            this.mHang.Name = "mHang";
            // 
            // tMH
            // 
            this.tMH.DataPropertyName = "TenMatHang";
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.tMH.DefaultCellStyle = dataGridViewCellStyle6;
            this.tMH.HeaderText = "Tên mặt hàng";
            this.tMH.Name = "tMH";
            this.tMH.Width = 150;
            // 
            // Dvitinh
            // 
            this.Dvitinh.DataPropertyName = "DonViTinh";
            this.Dvitinh.HeaderText = "Đơn vị tính";
            this.Dvitinh.Name = "Dvitinh";
            // 
            // GiaNhap
            // 
            this.GiaNhap.DataPropertyName = "GiaNhap";
            dataGridViewCellStyle7.Format = "C1";
            dataGridViewCellStyle7.NullValue = null;
            this.GiaNhap.DefaultCellStyle = dataGridViewCellStyle7;
            this.GiaNhap.HeaderText = "Giá nhập";
            this.GiaNhap.Name = "GiaNhap";
            // 
            // gia
            // 
            this.gia.DataPropertyName = "GiaBan";
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Format = "C1";
            dataGridViewCellStyle8.NullValue = null;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.DeepSkyBlue;
            this.gia.DefaultCellStyle = dataGridViewCellStyle8;
            this.gia.HeaderText = "Giá bán";
            this.gia.Name = "gia";
            // 
            // TrongLuong
            // 
            this.TrongLuong.DataPropertyName = "TrongLuong";
            this.TrongLuong.HeaderText = "Trọng lượng";
            this.TrongLuong.Name = "TrongLuong";
            // 
            // HSD
            // 
            this.HSD.DataPropertyName = "HSD";
            this.HSD.HeaderText = "HSD";
            this.HSD.Name = "HSD";
            // 
            // nuocSX
            // 
            this.nuocSX.DataPropertyName = "TenNuoc";
            this.nuocSX.HeaderText = "TenNuoc";
            this.nuocSX.Name = "nuocSX";
            // 
            // LoaiMH
            // 
            this.LoaiMH.DataPropertyName = "TenNhom";
            this.LoaiMH.HeaderText = "Nhóm hàng";
            this.LoaiMH.Name = "LoaiMH";
            this.LoaiMH.Width = 80;
            // 
            // gchu
            // 
            this.gchu.DataPropertyName = "GhiChu";
            this.gchu.HeaderText = "Ghi chú";
            this.gchu.Name = "gchu";
            // 
            // tvNH
            // 
            this.tvNH.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tvNH.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tvNH.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tvNH.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tvNH.FullRowSelect = true;
            this.tvNH.Indent = 35;
            this.tvNH.ItemHeight = 35;
            this.tvNH.Location = new System.Drawing.Point(5, 28);
            this.tvNH.Name = "tvNH";
            this.tvNH.Size = new System.Drawing.Size(301, 278);
            this.tvNH.TabIndex = 24;
            this.tvNH.TabStop = false;
            this.tvNH.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.tvNH_MouseDoubleClick);
            // 
            // tcMH
            // 
            this.tcMH.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tcMH.Controls.Add(this.tabPage2);
            this.tcMH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tcMH.Location = new System.Drawing.Point(308, 0);
            this.tcMH.Name = "tcMH";
            this.tcMH.SelectedIndex = 0;
            this.tcMH.Size = new System.Drawing.Size(394, 306);
            this.tcMH.TabIndex = 33;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.menuStrip2);
            this.tabPage2.Controls.Add(this.dgvMatHang);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(386, 277);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Mặt Hàng";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // menuStrip2
            // 
            this.menuStrip2.BackColor = System.Drawing.Color.YellowGreen;
            this.menuStrip2.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thêmToolStripMenuItem1,
            this.sửaToolStripMenuItem,
            this.xóaToolStripMenuItem2,
            this.refresToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(3, 3);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(380, 33);
            this.menuStrip2.TabIndex = 0;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // thêmToolStripMenuItem1
            // 
            this.thêmToolStripMenuItem1.Image = global::QuanLyBachHoa.Properties.Resources.Plus__Orange;
            this.thêmToolStripMenuItem1.Name = "thêmToolStripMenuItem1";
            this.thêmToolStripMenuItem1.Size = new System.Drawing.Size(124, 29);
            this.thêmToolStripMenuItem1.Text = "Thêm mới";
            this.thêmToolStripMenuItem1.Click += new System.EventHandler(this.thêmToolStripMenuItem1_Click);
            // 
            // sửaToolStripMenuItem
            // 
            this.sửaToolStripMenuItem.Image = global::QuanLyBachHoa.Properties.Resources.sua;
            this.sửaToolStripMenuItem.Name = "sửaToolStripMenuItem";
            this.sửaToolStripMenuItem.Size = new System.Drawing.Size(124, 29);
            this.sửaToolStripMenuItem.Text = "Chỉnh sửa";
            this.sửaToolStripMenuItem.Click += new System.EventHandler(this.sửaToolStripMenuItem_Click);
            // 
            // xóaToolStripMenuItem2
            // 
            this.xóaToolStripMenuItem2.Image = global::QuanLyBachHoa.Properties.Resources.xoa;
            this.xóaToolStripMenuItem2.Name = "xóaToolStripMenuItem2";
            this.xóaToolStripMenuItem2.Size = new System.Drawing.Size(72, 29);
            this.xóaToolStripMenuItem2.Text = "Xóa";
            this.xóaToolStripMenuItem2.Click += new System.EventHandler(this.xóaToolStripMenuItem2_Click);
            // 
            // refresToolStripMenuItem
            // 
            this.refresToolStripMenuItem.Image = global::QuanLyBachHoa.Properties.Resources.refresh;
            this.refresToolStripMenuItem.Name = "refresToolStripMenuItem";
            this.refresToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.refresToolStripMenuItem.Size = new System.Drawing.Size(103, 29);
            this.refresToolStripMenuItem.Text = "Refresh";
            this.refresToolStripMenuItem.Click += new System.EventHandler(this.refresToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.SandyBrown;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thêmToolStripMenuItem,
            this.sửaToolStripMenuItem1,
            this.xóaToolStripMenuItem,
            this.refreshToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(1, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(304, 29);
            this.menuStrip1.TabIndex = 34;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // thêmToolStripMenuItem
            // 
            this.thêmToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("thêmToolStripMenuItem.Image")));
            this.thêmToolStripMenuItem.Name = "thêmToolStripMenuItem";
            this.thêmToolStripMenuItem.Size = new System.Drawing.Size(77, 25);
            this.thêmToolStripMenuItem.Text = "Thêm";
            this.thêmToolStripMenuItem.Click += new System.EventHandler(this.thêmToolStripMenuItem_Click);
            // 
            // sửaToolStripMenuItem1
            // 
            this.sửaToolStripMenuItem1.Image = global::QuanLyBachHoa.Properties.Resources.sua;
            this.sửaToolStripMenuItem1.Name = "sửaToolStripMenuItem1";
            this.sửaToolStripMenuItem1.Size = new System.Drawing.Size(64, 25);
            this.sửaToolStripMenuItem1.Text = "Sửa";
            this.sửaToolStripMenuItem1.Click += new System.EventHandler(this.sửaToolStripMenuItem1_Click);
            // 
            // xóaToolStripMenuItem
            // 
            this.xóaToolStripMenuItem.Image = global::QuanLyBachHoa.Properties.Resources.xoa;
            this.xóaToolStripMenuItem.Name = "xóaToolStripMenuItem";
            this.xóaToolStripMenuItem.Size = new System.Drawing.Size(64, 25);
            this.xóaToolStripMenuItem.Text = "Xóa";
            this.xóaToolStripMenuItem.Click += new System.EventHandler(this.xóaToolStripMenuItem_Click);
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Image = global::QuanLyBachHoa.Properties.Resources.refresh;
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(91, 25);
            this.refreshToolStripMenuItem.Text = "Refresh";
            this.refreshToolStripMenuItem.Click += new System.EventHandler(this.refresToolStripMenuItem_Click);
            // 
            // dgvNH
            // 
            this.dgvNH.AllowUserToAddRows = false;
            this.dgvNH.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvNH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNH.Location = new System.Drawing.Point(65, 64);
            this.dgvNH.Name = "dgvNH";
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dgvNH.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvNH.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNH.Size = new System.Drawing.Size(141, 142);
            this.dgvNH.TabIndex = 26;
            // 
            // frmMatHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(703, 306);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.tcMH);
            this.Controls.Add(this.tvNH);
            this.Controls.Add(this.dgvNH);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMatHang";
            this.Text = "Danh mục mặt hàng";
            this.Load += new System.EventHandler(this.frmMatHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatHang)).EndInit();
            this.tcMH.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMatHang;
        public System.Windows.Forms.TreeView tvNH;
        private System.Windows.Forms.TabControl tcMH;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem thêmToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem sửaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xóaToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem refresToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn mHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn tMH;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dvitinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn gia;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrongLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn HSD;
        private System.Windows.Forms.DataGridViewTextBoxColumn nuocSX;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoaiMH;
        private System.Windows.Forms.DataGridViewTextBoxColumn gchu;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem thêmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sửaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgvNH;
        private System.Windows.Forms.ToolStripMenuItem xóaToolStripMenuItem;
    }
}