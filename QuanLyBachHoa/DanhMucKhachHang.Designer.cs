namespace QuanLyBachHoa
{
    partial class frmKhachHang
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKhachHang));
            this.tvLKH = new System.Windows.Forms.TreeView();
            this.cMenuLKH = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.suaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xóaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tcKH = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgvKH = new System.Windows.Forms.DataGridView();
            this.MaKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GhiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cMenuKH = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.thêmMớiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sửaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.thêmToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.sửaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xóaToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.refresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.thêmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sửaToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.xóaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvLKH = new System.Windows.Forms.DataGridView();
            this.cMenuLKH.SuspendLayout();
            this.tcKH.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKH)).BeginInit();
            this.cMenuKH.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLKH)).BeginInit();
            this.SuspendLayout();
            // 
            // tvLKH
            // 
            this.tvLKH.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tvLKH.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.tvLKH.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tvLKH.ContextMenuStrip = this.cMenuLKH;
            this.tvLKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tvLKH.Indent = 30;
            this.tvLKH.ItemHeight = 40;
            this.tvLKH.Location = new System.Drawing.Point(0, 32);
            this.tvLKH.Name = "tvLKH";
            this.tvLKH.Size = new System.Drawing.Size(304, 375);
            this.tvLKH.TabIndex = 0;
            this.tvLKH.TabStop = false;
            this.tvLKH.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvLKH_AfterSelect);
            this.tvLKH.DoubleClick += new System.EventHandler(this.tvLKH_DoubleClick);
            // 
            // cMenuLKH
            // 
            this.cMenuLKH.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.suaToolStripMenuItem,
            this.xóaToolStripMenuItem});
            this.cMenuLKH.Name = "cMenuLKH";
            this.cMenuLKH.Size = new System.Drawing.Size(95, 48);
            // 
            // suaToolStripMenuItem
            // 
            this.suaToolStripMenuItem.Image = global::QuanLyBachHoa.Properties.Resources.sua;
            this.suaToolStripMenuItem.Name = "suaToolStripMenuItem";
            this.suaToolStripMenuItem.Size = new System.Drawing.Size(94, 22);
            this.suaToolStripMenuItem.Text = "Sửa";
            this.suaToolStripMenuItem.Click += new System.EventHandler(this.suaToolStripMenuItem_Click);
            // 
            // xóaToolStripMenuItem
            // 
            this.xóaToolStripMenuItem.Image = global::QuanLyBachHoa.Properties.Resources.xoa;
            this.xóaToolStripMenuItem.Name = "xóaToolStripMenuItem";
            this.xóaToolStripMenuItem.Size = new System.Drawing.Size(94, 22);
            this.xóaToolStripMenuItem.Text = "Xóa";
            // 
            // tcKH
            // 
            this.tcKH.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tcKH.Controls.Add(this.tabPage2);
            this.tcKH.Location = new System.Drawing.Point(307, 0);
            this.tcKH.Name = "tcKH";
            this.tcKH.SelectedIndex = 0;
            this.tcKH.Size = new System.Drawing.Size(344, 407);
            this.tcKH.TabIndex = 2;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgvKH);
            this.tabPage2.Controls.Add(this.menuStrip2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(336, 381);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Khách Hàng";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvKH
            // 
            this.dgvKH.AllowUserToAddRows = false;
            this.dgvKH.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvKH.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvKH.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgvKH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKH.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaKH,
            this.TenKH,
            this.Phai,
            this.DiaChi,
            this.email,
            this.SDT,
            this.LKH,
            this.GhiChu});
            this.dgvKH.ContextMenuStrip = this.cMenuKH;
            this.dgvKH.GridColor = System.Drawing.Color.Gray;
            this.dgvKH.Location = new System.Drawing.Point(3, 39);
            this.dgvKH.Name = "dgvKH";
            this.dgvKH.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvKH.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvKH.RowHeadersWidth = 50;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dgvKH.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvKH.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKH.Size = new System.Drawing.Size(333, 342);
            this.dgvKH.TabIndex = 1;
            this.dgvKH.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvKH_CellMouseDoubleClick);
            // 
            // MaKH
            // 
            this.MaKH.DataPropertyName = "KhachHangId";
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DeepSkyBlue;
            this.MaKH.DefaultCellStyle = dataGridViewCellStyle1;
            this.MaKH.HeaderText = "Mã khách hàng";
            this.MaKH.Name = "MaKH";
            this.MaKH.ReadOnly = true;
            // 
            // TenKH
            // 
            this.TenKH.DataPropertyName = "TenKhachHang";
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.TenKH.DefaultCellStyle = dataGridViewCellStyle2;
            this.TenKH.HeaderText = "Khách hàng";
            this.TenKH.Name = "TenKH";
            this.TenKH.ReadOnly = true;
            this.TenKH.Width = 200;
            // 
            // Phai
            // 
            this.Phai.DataPropertyName = "GioiTinh";
            this.Phai.HeaderText = "Giới tính";
            this.Phai.Name = "Phai";
            this.Phai.ReadOnly = true;
            // 
            // DiaChi
            // 
            this.DiaChi.DataPropertyName = "DiaChi";
            this.DiaChi.HeaderText = "Địa chỉ";
            this.DiaChi.Name = "DiaChi";
            this.DiaChi.ReadOnly = true;
            this.DiaChi.Width = 200;
            // 
            // email
            // 
            this.email.DataPropertyName = "Email";
            this.email.HeaderText = "Email";
            this.email.Name = "email";
            this.email.ReadOnly = true;
            this.email.Width = 150;
            // 
            // SDT
            // 
            this.SDT.DataPropertyName = "SDT";
            this.SDT.HeaderText = "SDT";
            this.SDT.Name = "SDT";
            this.SDT.ReadOnly = true;
            this.SDT.Width = 120;
            // 
            // LKH
            // 
            this.LKH.DataPropertyName = "TenLoaiKhachHang";
            this.LKH.HeaderText = "Nhóm khách hàng";
            this.LKH.Name = "LKH";
            this.LKH.ReadOnly = true;
            this.LKH.Width = 130;
            // 
            // GhiChu
            // 
            this.GhiChu.DataPropertyName = "GhiChu";
            this.GhiChu.HeaderText = "Ghi chú";
            this.GhiChu.Name = "GhiChu";
            this.GhiChu.ReadOnly = true;
            // 
            // cMenuKH
            // 
            this.cMenuKH.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thêmMớiToolStripMenuItem,
            this.sửaToolStripMenuItem1});
            this.cMenuKH.Name = "cMenuKH";
            this.cMenuKH.Size = new System.Drawing.Size(153, 70);
            this.cMenuKH.Opening += new System.ComponentModel.CancelEventHandler(this.cMenuKH_Opening);
            // 
            // thêmMớiToolStripMenuItem
            // 
            this.thêmMớiToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("thêmMớiToolStripMenuItem.Image")));
            this.thêmMớiToolStripMenuItem.Name = "thêmMớiToolStripMenuItem";
            this.thêmMớiToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.thêmMớiToolStripMenuItem.Text = "Thêm mới";
            this.thêmMớiToolStripMenuItem.Click += new System.EventHandler(this.thêmMớiToolStripMenuItem_Click);
            // 
            // sửaToolStripMenuItem1
            // 
            this.sửaToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("sửaToolStripMenuItem1.Image")));
            this.sửaToolStripMenuItem1.Name = "sửaToolStripMenuItem1";
            this.sửaToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.sửaToolStripMenuItem1.Text = "Sửa";
            this.sửaToolStripMenuItem1.Click += new System.EventHandler(this.sửaToolStripMenuItem1_Click);
            // 
            // menuStrip2
            // 
            this.menuStrip2.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.menuStrip2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thêmToolStripMenuItem1,
            this.sửaToolStripMenuItem,
            this.xóaToolStripMenuItem2,
            this.refresToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(3, 3);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(330, 29);
            this.menuStrip2.TabIndex = 0;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // thêmToolStripMenuItem1
            // 
            this.thêmToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("thêmToolStripMenuItem1.Image")));
            this.thêmToolStripMenuItem1.Name = "thêmToolStripMenuItem1";
            this.thêmToolStripMenuItem1.Size = new System.Drawing.Size(109, 25);
            this.thêmToolStripMenuItem1.Text = "Thêm mới";
            this.thêmToolStripMenuItem1.Click += new System.EventHandler(this.thêmToolStripMenuItem1_Click);
            // 
            // sửaToolStripMenuItem
            // 
            this.sửaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("sửaToolStripMenuItem.Image")));
            this.sửaToolStripMenuItem.Name = "sửaToolStripMenuItem";
            this.sửaToolStripMenuItem.Size = new System.Drawing.Size(107, 25);
            this.sửaToolStripMenuItem.Text = "Chỉnh sửa";
            this.sửaToolStripMenuItem.Click += new System.EventHandler(this.sửaToolStripMenuItem_Click);
            // 
            // xóaToolStripMenuItem2
            // 
            this.xóaToolStripMenuItem2.Image = ((System.Drawing.Image)(resources.GetObject("xóaToolStripMenuItem2.Image")));
            this.xóaToolStripMenuItem2.Name = "xóaToolStripMenuItem2";
            this.xóaToolStripMenuItem2.Size = new System.Drawing.Size(64, 25);
            this.xóaToolStripMenuItem2.Text = "Xóa";
            this.xóaToolStripMenuItem2.Click += new System.EventHandler(this.xóaToolStripMenuItem2_Click);
            // 
            // refresToolStripMenuItem
            // 
            this.refresToolStripMenuItem.Image = global::QuanLyBachHoa.Properties.Resources.refresh;
            this.refresToolStripMenuItem.Name = "refresToolStripMenuItem";
            this.refresToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.refresToolStripMenuItem.Size = new System.Drawing.Size(91, 25);
            this.refresToolStripMenuItem.Text = "Refresh";
            this.refresToolStripMenuItem.Click += new System.EventHandler(this.refresToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(374, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 3;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Cornsilk;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thêmToolStripMenuItem,
            this.sửaToolStripMenuItem2,
            this.xóaToolStripMenuItem1,
            this.refreshToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(304, 29);
            this.menuStrip1.TabIndex = 4;
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
            // sửaToolStripMenuItem2
            // 
            this.sửaToolStripMenuItem2.Image = global::QuanLyBachHoa.Properties.Resources.sua;
            this.sửaToolStripMenuItem2.Name = "sửaToolStripMenuItem2";
            this.sửaToolStripMenuItem2.Size = new System.Drawing.Size(64, 25);
            this.sửaToolStripMenuItem2.Text = "Sửa";
            this.sửaToolStripMenuItem2.Click += new System.EventHandler(this.xóaToolStripMenuItem_Click);
            // 
            // xóaToolStripMenuItem1
            // 
            this.xóaToolStripMenuItem1.Image = global::QuanLyBachHoa.Properties.Resources.xoa;
            this.xóaToolStripMenuItem1.Name = "xóaToolStripMenuItem1";
            this.xóaToolStripMenuItem1.Size = new System.Drawing.Size(64, 25);
            this.xóaToolStripMenuItem1.Text = "Xóa";
            this.xóaToolStripMenuItem1.Click += new System.EventHandler(this.xóaToolStripMenuItem1_Click);
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Image = global::QuanLyBachHoa.Properties.Resources.refresh;
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(91, 25);
            this.refreshToolStripMenuItem.Text = "Refresh";
            this.refreshToolStripMenuItem.Click += new System.EventHandler(this.refreshToolStripMenuItem_Click);
            // 
            // dgvLKH
            // 
            this.dgvLKH.AllowUserToAddRows = false;
            this.dgvLKH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLKH.Location = new System.Drawing.Point(52, 99);
            this.dgvLKH.Name = "dgvLKH";
            this.dgvLKH.Size = new System.Drawing.Size(196, 159);
            this.dgvLKH.TabIndex = 2;
            // 
            // frmKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(652, 407);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tcKH);
            this.Controls.Add(this.tvLKH);
            this.Controls.Add(this.dgvLKH);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmKhachHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh Mục Khách Hàng";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmKhachHang_Load);
            this.cMenuLKH.ResumeLayout(false);
            this.tcKH.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKH)).EndInit();
            this.cMenuKH.ResumeLayout(false);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLKH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tcKH;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem thêmToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem sửaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xóaToolStripMenuItem2;
        private System.Windows.Forms.DataGridView dgvKH;
        private System.Windows.Forms.ContextMenuStrip cMenuKH;
        private System.Windows.Forms.ToolStripMenuItem thêmMớiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sửaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem refresToolStripMenuItem;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.TreeView tvLKH;
        private System.Windows.Forms.ContextMenuStrip cMenuLKH;
        private System.Windows.Forms.ToolStripMenuItem suaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xóaToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phai;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn LKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn GhiChu;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem thêmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sửaToolStripMenuItem2;
        private System.Windows.Forms.DataGridView dgvLKH;
        private System.Windows.Forms.ToolStripMenuItem xóaToolStripMenuItem1;

    }
}