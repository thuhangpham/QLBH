namespace QuanLyBachHoa
{
    partial class frmXuatKho
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblCTPN = new System.Windows.Forms.Label();
            this.dgvCTXuatHang = new System.Windows.Forms.DataGridView();
            this.MH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DVT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.thêmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvXuatHang = new System.Windows.Forms.DataGridView();
            this.MaPX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayXuat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GhiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTXuatHang)).BeginInit();
            this.menuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvXuatHang)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCTPN
            // 
            this.lblCTPN.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCTPN.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblCTPN.ForeColor = System.Drawing.Color.Brown;
            this.lblCTPN.Location = new System.Drawing.Point(594, 9);
            this.lblCTPN.Name = "lblCTPN";
            this.lblCTPN.Size = new System.Drawing.Size(187, 23);
            this.lblCTPN.TabIndex = 8;
            this.lblCTPN.Text = "Chi tiết phiếu xuất kho";
            // 
            // dgvCTXuatHang
            // 
            this.dgvCTXuatHang.AllowUserToAddRows = false;
            this.dgvCTXuatHang.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCTXuatHang.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.dgvCTXuatHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCTXuatHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MH,
            this.DVT,
            this.GiaNhap,
            this.GiaB,
            this.SL});
            this.dgvCTXuatHang.GridColor = System.Drawing.SystemColors.Window;
            this.dgvCTXuatHang.Location = new System.Drawing.Point(585, 47);
            this.dgvCTXuatHang.Name = "dgvCTXuatHang";
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCTXuatHang.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dgvCTXuatHang.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvCTXuatHang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCTXuatHang.Size = new System.Drawing.Size(519, 232);
            this.dgvCTXuatHang.TabIndex = 7;
            // 
            // MH
            // 
            this.MH.DataPropertyName = "TenMatHang";
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.MH.DefaultCellStyle = dataGridViewCellStyle8;
            this.MH.HeaderText = "Mặt hàng";
            this.MH.Name = "MH";
            this.MH.Width = 200;
            // 
            // DVT
            // 
            this.DVT.DataPropertyName = "DonViTinh";
            this.DVT.HeaderText = "Đơn vị tính";
            this.DVT.Name = "DVT";
            // 
            // GiaNhap
            // 
            this.GiaNhap.DataPropertyName = "GiaNhap";
            dataGridViewCellStyle9.Format = "C1";
            dataGridViewCellStyle9.NullValue = null;
            this.GiaNhap.DefaultCellStyle = dataGridViewCellStyle9;
            this.GiaNhap.HeaderText = "Giá nhập";
            this.GiaNhap.Name = "GiaNhap";
            this.GiaNhap.Width = 180;
            // 
            // GiaB
            // 
            this.GiaB.DataPropertyName = "GiaBan";
            dataGridViewCellStyle10.Format = "C1";
            dataGridViewCellStyle10.NullValue = null;
            this.GiaB.DefaultCellStyle = dataGridViewCellStyle10;
            this.GiaB.HeaderText = "Giá bán";
            this.GiaB.Name = "GiaB";
            this.GiaB.Width = 180;
            // 
            // SL
            // 
            this.SL.DataPropertyName = "SoLuong";
            this.SL.HeaderText = "Số lượng";
            this.SL.Name = "SL";
            // 
            // menuStrip2
            // 
            this.menuStrip2.AutoSize = false;
            this.menuStrip2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.menuStrip2.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip2.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.menuStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thêmToolStripMenuItem,
            this.refreshToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(9, 9);
            this.menuStrip2.MaximumSize = new System.Drawing.Size(800, 40);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip2.Size = new System.Drawing.Size(570, 35);
            this.menuStrip2.TabIndex = 6;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // thêmToolStripMenuItem
            // 
            this.thêmToolStripMenuItem.Image = global::QuanLyBachHoa.Properties.Resources.add;
            this.thêmToolStripMenuItem.Name = "thêmToolStripMenuItem";
            this.thêmToolStripMenuItem.Size = new System.Drawing.Size(84, 31);
            this.thêmToolStripMenuItem.Text = "Thêm";
            this.thêmToolStripMenuItem.Click += new System.EventHandler(this.thêmToolStripMenuItem_Click_1);
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Image = global::QuanLyBachHoa.Properties.Resources.refresh_ogrange;
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(99, 31);
            this.refreshToolStripMenuItem.Text = "Refresh";
            this.refreshToolStripMenuItem.Click += new System.EventHandler(this.refreshToolStripMenuItem_Click);
            // 
            // dgvXuatHang
            // 
            this.dgvXuatHang.AllowUserToAddRows = false;
            this.dgvXuatHang.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvXuatHang.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvXuatHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvXuatHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaPX,
            this.NgayXuat,
            this.TenNV,
            this.GhiChu});
            this.dgvXuatHang.GridColor = System.Drawing.SystemColors.WindowFrame;
            this.dgvXuatHang.Location = new System.Drawing.Point(9, 47);
            this.dgvXuatHang.Name = "dgvXuatHang";
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dgvXuatHang.RowsDefaultCellStyle = dataGridViewCellStyle14;
            this.dgvXuatHang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvXuatHang.Size = new System.Drawing.Size(570, 232);
            this.dgvXuatHang.TabIndex = 5;
            this.dgvXuatHang.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvNhapHang_MouseClick);
            // 
            // MaPX
            // 
            this.MaPX.DataPropertyName = "PhieuXuatId";
            this.MaPX.HeaderText = " Mã PN";
            this.MaPX.Name = "MaPX";
            this.MaPX.Width = 80;
            // 
            // NgayXuat
            // 
            this.NgayXuat.DataPropertyName = "NgayXuat";
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.NgayXuat.DefaultCellStyle = dataGridViewCellStyle13;
            this.NgayXuat.HeaderText = "Ngày";
            this.NgayXuat.Name = "NgayXuat";
            this.NgayXuat.Width = 120;
            // 
            // TenNV
            // 
            this.TenNV.DataPropertyName = "TenNhanVien";
            this.TenNV.HeaderText = "Nhân viên";
            this.TenNV.Name = "TenNV";
            this.TenNV.Width = 200;
            // 
            // GhiChu
            // 
            this.GhiChu.DataPropertyName = "GhiChu";
            this.GhiChu.HeaderText = "Ghi chú";
            this.GhiChu.Name = "GhiChu";
            this.GhiChu.Width = 130;
            // 
            // frmXuatKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ClientSize = new System.Drawing.Size(1105, 282);
            this.Controls.Add(this.lblCTPN);
            this.Controls.Add(this.dgvCTXuatHang);
            this.Controls.Add(this.menuStrip2);
            this.Controls.Add(this.dgvXuatHang);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmXuatKho";
            this.Text = "Phiếu xuất kho";
            this.Load += new System.EventHandler(this.frmXuatKho_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTXuatHang)).EndInit();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvXuatHang)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thêmToolStripMenuItem;
        private System.Windows.Forms.Label lblCTPN;
        private System.Windows.Forms.DataGridView dgvCTXuatHang;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.DataGridView dgvXuatHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn MH;
        private System.Windows.Forms.DataGridViewTextBoxColumn DVT;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaB;
        private System.Windows.Forms.DataGridViewTextBoxColumn SL;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPX;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayXuat;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn GhiChu;
    }
}