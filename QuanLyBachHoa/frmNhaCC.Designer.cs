namespace QuanLyBachHoa
{
    partial class frmNhaCC
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvNhaCC = new System.Windows.Forms.DataGridView();
            this.MaNCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GhiCHu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.thêmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sửaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xóaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Chon = new System.Windows.Forms.ToolStripMenuItem();
            this.thoat = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhaCC)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvNhaCC
            // 
            this.dgvNhaCC.AllowUserToAddRows = false;
            this.dgvNhaCC.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvNhaCC.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvNhaCC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhaCC.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaNCC,
            this.TenNCC,
            this.DC,
            this.email,
            this.SDT,
            this.GhiCHu});
            this.dgvNhaCC.Location = new System.Drawing.Point(0, 31);
            this.dgvNhaCC.Name = "dgvNhaCC";
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dgvNhaCC.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvNhaCC.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNhaCC.Size = new System.Drawing.Size(1200, 333);
            this.dgvNhaCC.TabIndex = 0;
            this.dgvNhaCC.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvNhaCC_CellMouseDoubleClick);
            // 
            // MaNCC
            // 
            this.MaNCC.DataPropertyName = "NhaCungCapId";
            this.MaNCC.HeaderText = "Mã";
            this.MaNCC.Name = "MaNCC";
            // 
            // TenNCC
            // 
            this.TenNCC.DataPropertyName = "TenNhaCungCap";
            this.TenNCC.HeaderText = "Nhà CC";
            this.TenNCC.Name = "TenNCC";
            this.TenNCC.Width = 250;
            // 
            // DC
            // 
            this.DC.DataPropertyName = "DiaChi";
            this.DC.HeaderText = "Địa chỉ";
            this.DC.Name = "DC";
            this.DC.Width = 280;
            // 
            // email
            // 
            this.email.DataPropertyName = "Email";
            this.email.HeaderText = "Email";
            this.email.Name = "email";
            this.email.Width = 200;
            // 
            // SDT
            // 
            this.SDT.DataPropertyName = "SDT";
            this.SDT.HeaderText = "SDT";
            this.SDT.Name = "SDT";
            this.SDT.Width = 250;
            // 
            // GhiCHu
            // 
            this.GhiCHu.DataPropertyName = "GhiChu";
            this.GhiCHu.HeaderText = "GhiChu";
            this.GhiCHu.Name = "GhiCHu";
            this.GhiCHu.Width = 220;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.DarkKhaki;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thêmToolStripMenuItem,
            this.sửaToolStripMenuItem,
            this.xóaToolStripMenuItem,
            this.refresToolStripMenuItem,
            this.Chon,
            this.thoat});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1200, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // thêmToolStripMenuItem
            // 
            this.thêmToolStripMenuItem.Image = global::QuanLyBachHoa.Properties.Resources.add;
            this.thêmToolStripMenuItem.Name = "thêmToolStripMenuItem";
            this.thêmToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.A)));
            this.thêmToolStripMenuItem.Size = new System.Drawing.Size(74, 24);
            this.thêmToolStripMenuItem.Text = "Thêm";
            this.thêmToolStripMenuItem.Click += new System.EventHandler(this.thêmToolStripMenuItem_Click);
            // 
            // sửaToolStripMenuItem
            // 
            this.sửaToolStripMenuItem.Image = global::QuanLyBachHoa.Properties.Resources.sua;
            this.sửaToolStripMenuItem.Name = "sửaToolStripMenuItem";
            this.sửaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.sửaToolStripMenuItem.Size = new System.Drawing.Size(62, 24);
            this.sửaToolStripMenuItem.Text = "Sửa";
            this.sửaToolStripMenuItem.Click += new System.EventHandler(this.sửaToolStripMenuItem_Click);
            // 
            // xóaToolStripMenuItem
            // 
            this.xóaToolStripMenuItem.Image = global::QuanLyBachHoa.Properties.Resources.xoa;
            this.xóaToolStripMenuItem.Name = "xóaToolStripMenuItem";
            this.xóaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.xóaToolStripMenuItem.Size = new System.Drawing.Size(63, 24);
            this.xóaToolStripMenuItem.Text = "Xóa";
            this.xóaToolStripMenuItem.Click += new System.EventHandler(this.xóaToolStripMenuItem_Click);
            // 
            // refresToolStripMenuItem
            // 
            this.refresToolStripMenuItem.Image = global::QuanLyBachHoa.Properties.Resources.refresh;
            this.refresToolStripMenuItem.Name = "refresToolStripMenuItem";
            this.refresToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.refresToolStripMenuItem.Size = new System.Drawing.Size(86, 24);
            this.refresToolStripMenuItem.Text = "Refresh";
            this.refresToolStripMenuItem.Click += new System.EventHandler(this.refresToolStripMenuItem_Click);
            // 
            // Chon
            // 
            this.Chon.Enabled = false;
            this.Chon.Image = global::QuanLyBachHoa.Properties.Resources.Plus__Orange;
            this.Chon.Name = "Chon";
            this.Chon.Size = new System.Drawing.Size(71, 24);
            this.Chon.Text = "Chọn";
            this.Chon.Click += new System.EventHandler(this.Chon_Click);
            // 
            // thoat
            // 
            this.thoat.Enabled = false;
            this.thoat.Image = global::QuanLyBachHoa.Properties.Resources.xoa;
            this.thoat.Name = "thoat";
            this.thoat.Size = new System.Drawing.Size(75, 24);
            this.thoat.Text = "Thoát";
            this.thoat.Click += new System.EventHandler(this.thoátToolStripMenuItem_Click);
            // 
            // frmNhaCC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 365);
            this.Controls.Add(this.dgvNhaCC);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "frmNhaCC";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh mục Nhà CC";
            this.Load += new System.EventHandler(this.frmNhaCC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhaCC)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvNhaCC;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem thêmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sửaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xóaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refresToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn DC;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn GhiCHu;
        public System.Windows.Forms.ToolStripMenuItem Chon;
        public System.Windows.Forms.ToolStripMenuItem thoat;
    }
}