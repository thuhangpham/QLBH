namespace QuanLyBachHoa
{
    partial class frmNhanVien
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Tnv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.luong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tcv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.thêmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sửaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xíaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tnhv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenCV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gtinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Eml = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDThoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.luongnv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Tnv
            // 
            this.Tnv.DataPropertyName = "TenNV";
            this.Tnv.HeaderText = "Họ tên";
            this.Tnv.Name = "Tnv";
            // 
            // luong
            // 
            this.luong.DataPropertyName = "Luong";
            dataGridViewCellStyle1.Format = "C1";
            dataGridViewCellStyle1.NullValue = null;
            this.luong.DefaultCellStyle = dataGridViewCellStyle1;
            this.luong.HeaderText = "Luong";
            this.luong.Name = "luong";
            this.luong.Width = 70;
            // 
            // SDT
            // 
            this.SDT.DataPropertyName = "SDT";
            this.SDT.HeaderText = "SDT";
            this.SDT.Name = "SDT";
            this.SDT.Width = 70;
            // 
            // mail
            // 
            this.mail.DataPropertyName = "Email";
            this.mail.HeaderText = "Email";
            this.mail.Name = "mail";
            // 
            // dc
            // 
            this.dc.DataPropertyName = "DiaChi";
            this.dc.HeaderText = "Địa chỉ";
            this.dc.Name = "dc";
            this.dc.Width = 70;
            // 
            // gt
            // 
            this.gt.DataPropertyName = "GioiTinh";
            this.gt.HeaderText = "GT";
            this.gt.Name = "gt";
            this.gt.Width = 50;
            // 
            // tcv
            // 
            this.tcv.DataPropertyName = "TenCV";
            this.tcv.HeaderText = "Chức vụ";
            this.tcv.Name = "tcv";
            // 
            // MNV
            // 
            this.MNV.DataPropertyName = "MaNV";
            this.MNV.HeaderText = "Mã";
            this.MNV.Name = "MNV";
            this.MNV.Width = 40;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thêmToolStripMenuItem,
            this.sửaToolStripMenuItem,
            this.xíaToolStripMenuItem,
            this.refreshToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(836, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // thêmToolStripMenuItem
            // 
            this.thêmToolStripMenuItem.Image = global::QuanLyBachHoa.Properties.Resources.add;
            this.thêmToolStripMenuItem.Name = "thêmToolStripMenuItem";
            this.thêmToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.thêmToolStripMenuItem.Text = " Thêm";
            this.thêmToolStripMenuItem.Click += new System.EventHandler(this.thêmToolStripMenuItem_Click_1);
            // 
            // sửaToolStripMenuItem
            // 
            this.sửaToolStripMenuItem.Image = global::QuanLyBachHoa.Properties.Resources.sua;
            this.sửaToolStripMenuItem.Name = "sửaToolStripMenuItem";
            this.sửaToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.sửaToolStripMenuItem.Text = "Sửa";
            this.sửaToolStripMenuItem.Click += new System.EventHandler(this.sửaToolStripMenuItem_Click_1);
            // 
            // xíaToolStripMenuItem
            // 
            this.xíaToolStripMenuItem.Image = global::QuanLyBachHoa.Properties.Resources.xoa;
            this.xíaToolStripMenuItem.Name = "xíaToolStripMenuItem";
            this.xíaToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.xíaToolStripMenuItem.Text = "Xóa";
            this.xíaToolStripMenuItem.Click += new System.EventHandler(this.xíaToolStripMenuItem_Click);
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Image = global::QuanLyBachHoa.Properties.Resources.refresh;
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.refreshToolStripMenuItem.Text = "Refresh";
            this.refreshToolStripMenuItem.Click += new System.EventHandler(this.refreshToolStripMenuItem_Click);
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.tnhv,
            this.tenCV,
            this.gtinh,
            this.Dch,
            this.Eml,
            this.SDThoai,
            this.Column2,
            this.Column3,
            this.luongnv});
            this.dgv.Location = new System.Drawing.Point(3, 3);
            this.dgv.Name = "dgv";
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dgv.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(830, 352);
            this.dgv.TabIndex = 5;
            this.dgv.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_CellMouseDoubleClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "NhanVienId";
            this.Column1.HeaderText = "Mã NV";
            this.Column1.Name = "Column1";
            this.Column1.Width = 65;
            // 
            // tnhv
            // 
            this.tnhv.DataPropertyName = "TenNhanVien";
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tnhv.DefaultCellStyle = dataGridViewCellStyle2;
            this.tnhv.HeaderText = "Tên NV";
            this.tnhv.Name = "tnhv";
            this.tnhv.Width = 200;
            // 
            // tenCV
            // 
            this.tenCV.DataPropertyName = "TenChucVu";
            this.tenCV.HeaderText = "Công việc";
            this.tenCV.Name = "tenCV";
            // 
            // gtinh
            // 
            this.gtinh.DataPropertyName = "GioiTinh";
            this.gtinh.HeaderText = "Giới tính";
            this.gtinh.Name = "gtinh";
            this.gtinh.Width = 72;
            // 
            // Dch
            // 
            this.Dch.DataPropertyName = "DiaChi";
            this.Dch.HeaderText = "Địa chỉ";
            this.Dch.Name = "Dch";
            this.Dch.Width = 180;
            // 
            // Eml
            // 
            this.Eml.DataPropertyName = "Email";
            this.Eml.HeaderText = "Email";
            this.Eml.Name = "Eml";
            this.Eml.Width = 200;
            // 
            // SDThoai
            // 
            this.SDThoai.DataPropertyName = "SDT";
            this.SDThoai.HeaderText = "SDT";
            this.SDThoai.Name = "SDThoai";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Admin";
            this.Column2.HeaderText = "Admin";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Password";
            this.Column3.HeaderText = "Password";
            this.Column3.Name = "Column3";
            this.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column3.Width = 130;
            // 
            // luongnv
            // 
            this.luongnv.DataPropertyName = "Luong";
            dataGridViewCellStyle3.Format = "C1";
            dataGridViewCellStyle3.NullValue = null;
            this.luongnv.DefaultCellStyle = dataGridViewCellStyle3;
            this.luongnv.HeaderText = "Lương";
            this.luongnv.Name = "luongnv";
            this.luongnv.Width = 180;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.dgv, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 27);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(836, 358);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // frmNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(836, 386);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(1400, 900);
            this.Name = "frmNhanVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh mục nhân viên";
            this.Load += new System.EventHandler(this.frmNhanVien_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn Tnv;
        private System.Windows.Forms.DataGridViewTextBoxColumn luong;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn mail;
        private System.Windows.Forms.DataGridViewTextBoxColumn dc;
        private System.Windows.Forms.DataGridViewTextBoxColumn gt;
        private System.Windows.Forms.DataGridViewTextBoxColumn tcv;
        private System.Windows.Forms.DataGridViewTextBoxColumn MNV;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem thêmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sửaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xíaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tnhv;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenCV;
        private System.Windows.Forms.DataGridViewTextBoxColumn gtinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dch;
        private System.Windows.Forms.DataGridViewTextBoxColumn Eml;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDThoai;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn luongnv;



    }
}