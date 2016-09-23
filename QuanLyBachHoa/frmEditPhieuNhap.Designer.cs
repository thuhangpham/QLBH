namespace QuanLyBachHoa
{
    partial class frmEditPhieuNhap
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.txtNcc = new System.Windows.Forms.TextBox();
            this.cbNhanVien = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMaPN = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.tvNH = new System.Windows.Forms.TreeView();
            this.dgvMatHang = new System.Windows.Forms.DataGridView();
            this.Mh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.th = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DVT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNhom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvNH = new System.Windows.Forms.DataGridView();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.txtSearchMH = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnThemMH = new System.Windows.Forms.Button();
            this.dgvCTPN = new System.Windows.Forms.DataGridView();
            this.MaHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtGC = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.txtTong = new System.Windows.Forms.TextBox();
            this.btnHuy = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.nudGiaNhap = new System.Windows.Forms.NumericUpDown();
            this.btnGiaNhap = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTPN)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudGiaNhap)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.txtNcc);
            this.panel1.Controls.Add(this.cbNhanVien);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtMaPN);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(646, 108);
            this.panel1.TabIndex = 0;
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button3.BackgroundImage = global::QuanLyBachHoa.Properties.Resources.search;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button3.Location = new System.Drawing.Point(461, 44);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(54, 34);
            this.button3.TabIndex = 11;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtNcc
            // 
            this.txtNcc.Enabled = false;
            this.txtNcc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtNcc.Location = new System.Drawing.Point(145, 44);
            this.txtNcc.Name = "txtNcc";
            this.txtNcc.Size = new System.Drawing.Size(310, 23);
            this.txtNcc.TabIndex = 10;
            // 
            // cbNhanVien
            // 
            this.cbNhanVien.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbNhanVien.FormattingEnabled = true;
            this.cbNhanVien.Location = new System.Drawing.Point(145, 76);
            this.cbNhanVien.Name = "cbNhanVien";
            this.cbNhanVien.Size = new System.Drawing.Size(310, 24);
            this.cbNhanVien.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(16, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "Nhân viên:";
            // 
            // txtMaPN
            // 
            this.txtMaPN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMaPN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.txtMaPN.Enabled = false;
            this.txtMaPN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMaPN.Location = new System.Drawing.Point(543, 15);
            this.txtMaPN.Name = "txtMaPN";
            this.txtMaPN.Size = new System.Drawing.Size(64, 23);
            this.txtMaPN.TabIndex = 6;
            this.txtMaPN.Text = "Defaul";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(461, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Số phiếu:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(16, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nhà cung cấp:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker1.Location = new System.Drawing.Point(145, 14);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(232, 20);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(16, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ngày:";
            // 
            // tvNH
            // 
            this.tvNH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tvNH.Indent = 30;
            this.tvNH.ItemHeight = 30;
            this.tvNH.Location = new System.Drawing.Point(12, 126);
            this.tvNH.Name = "tvNH";
            this.tvNH.Size = new System.Drawing.Size(645, 143);
            this.tvNH.TabIndex = 1;
            this.tvNH.DoubleClick += new System.EventHandler(this.tvNH_DoubleClick);
            // 
            // dgvMatHang
            // 
            this.dgvMatHang.AllowUserToAddRows = false;
            this.dgvMatHang.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvMatHang.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvMatHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMatHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Mh,
            this.th,
            this.DVT,
            this.GiaNhap,
            this.TenNhom,
            this.GC});
            this.dgvMatHang.Location = new System.Drawing.Point(13, 313);
            this.dgvMatHang.Name = "dgvMatHang";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dgvMatHang.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvMatHang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMatHang.Size = new System.Drawing.Size(646, 334);
            this.dgvMatHang.TabIndex = 2;
            this.dgvMatHang.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvMatHang_CellMouseDoubleClick);
            // 
            // Mh
            // 
            this.Mh.DataPropertyName = "MatHangId";
            this.Mh.HeaderText = "Mã hàng";
            this.Mh.Name = "Mh";
            // 
            // th
            // 
            this.th.DataPropertyName = "TenMatHang";
            this.th.HeaderText = "Mặt hàng";
            this.th.Name = "th";
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
            dataGridViewCellStyle1.Format = "C1";
            dataGridViewCellStyle1.NullValue = null;
            this.GiaNhap.DefaultCellStyle = dataGridViewCellStyle1;
            this.GiaNhap.HeaderText = "Giá nhập";
            this.GiaNhap.Name = "GiaNhap";
            // 
            // TenNhom
            // 
            this.TenNhom.DataPropertyName = "TenNhom";
            this.TenNhom.HeaderText = "Tên nhóm";
            this.TenNhom.Name = "TenNhom";
            // 
            // GC
            // 
            this.GC.DataPropertyName = "GhiChu";
            this.GC.HeaderText = "Ghi chú";
            this.GC.Name = "GC";
            // 
            // dgvNH
            // 
            this.dgvNH.AllowUserToAddRows = false;
            this.dgvNH.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvNH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNH.Location = new System.Drawing.Point(396, 314);
            this.dgvNH.Name = "dgvNH";
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dgvNH.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvNH.Size = new System.Drawing.Size(47, 48);
            this.dgvNH.TabIndex = 3;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.numericUpDown1.Location = new System.Drawing.Point(494, 280);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(56, 29);
            this.numericUpDown1.TabIndex = 5;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txtSearchMH
            // 
            this.txtSearchMH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtSearchMH.Location = new System.Drawing.Point(13, 284);
            this.txtSearchMH.Name = "txtSearchMH";
            this.txtSearchMH.Size = new System.Drawing.Size(193, 26);
            this.txtSearchMH.TabIndex = 6;
            this.txtSearchMH.TextChanged += new System.EventHandler(this.button2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(461, 285);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 18);
            this.label6.TabIndex = 7;
            this.label6.Text = "SL:";
            // 
            // btnThemMH
            // 
            this.btnThemMH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnThemMH.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThemMH.Location = new System.Drawing.Point(583, 275);
            this.btnThemMH.Name = "btnThemMH";
            this.btnThemMH.Size = new System.Drawing.Size(75, 36);
            this.btnThemMH.TabIndex = 8;
            this.btnThemMH.Text = "Thêm";
            this.btnThemMH.UseVisualStyleBackColor = false;
            this.btnThemMH.Click += new System.EventHandler(this.btnThemMH_Click);
            // 
            // dgvCTPN
            // 
            this.dgvCTPN.AllowUserToAddRows = false;
            this.dgvCTPN.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvCTPN.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvCTPN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCTPN.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaHang,
            this.TenHang,
            this.Gia,
            this.SL,
            this.DonGia,
            this.gch});
            this.dgvCTPN.Location = new System.Drawing.Point(664, 148);
            this.dgvCTPN.Name = "dgvCTPN";
            this.dgvCTPN.RowHeadersVisible = false;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dgvCTPN.RowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvCTPN.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCTPN.Size = new System.Drawing.Size(554, 499);
            this.dgvCTPN.TabIndex = 9;
            this.dgvCTPN.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvCTPN_CellMouseDoubleClick);
            // 
            // MaHang
            // 
            this.MaHang.HeaderText = "Mã hàng";
            this.MaHang.Name = "MaHang";
            // 
            // TenHang
            // 
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.TenHang.DefaultCellStyle = dataGridViewCellStyle4;
            this.TenHang.HeaderText = "Mặt hàng";
            this.TenHang.Name = "TenHang";
            this.TenHang.Width = 150;
            // 
            // Gia
            // 
            dataGridViewCellStyle5.Format = "C1";
            dataGridViewCellStyle5.NullValue = null;
            this.Gia.DefaultCellStyle = dataGridViewCellStyle5;
            this.Gia.HeaderText = "Giá nhập";
            this.Gia.Name = "Gia";
            // 
            // SL
            // 
            this.SL.HeaderText = "Số lượng";
            this.SL.Name = "SL";
            // 
            // DonGia
            // 
            dataGridViewCellStyle6.Format = "C1";
            dataGridViewCellStyle6.NullValue = null;
            this.DonGia.DefaultCellStyle = dataGridViewCellStyle6;
            this.DonGia.HeaderText = "Đơn giá";
            this.DonGia.Name = "DonGia";
            this.DonGia.Width = 150;
            // 
            // gch
            // 
            this.gch.HeaderText = "Ghi chú";
            this.gch.Name = "gch";
            // 
            // txtGC
            // 
            this.txtGC.Location = new System.Drawing.Point(664, 27);
            this.txtGC.Multiline = true;
            this.txtGC.Name = "txtGC";
            this.txtGC.Size = new System.Drawing.Size(237, 115);
            this.txtGC.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.Location = new System.Drawing.Point(664, 6);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 18);
            this.label7.TabIndex = 11;
            this.label7.Text = "Ghi chú:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnThoat);
            this.panel2.Controls.Add(this.btnThanhToan);
            this.panel2.Controls.Add(this.txtTong);
            this.panel2.Controls.Add(this.btnHuy);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Location = new System.Drawing.Point(907, 20);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(311, 122);
            this.panel2.TabIndex = 12;
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThoat.Location = new System.Drawing.Point(235, 69);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(64, 40);
            this.btnThoat.TabIndex = 16;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnThanhToan.Enabled = false;
            this.btnThanhToan.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThanhToan.Location = new System.Drawing.Point(6, 69);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(108, 40);
            this.btnThanhToan.TabIndex = 14;
            this.btnThanhToan.Text = "Thanh toán";
            this.btnThanhToan.UseVisualStyleBackColor = false;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // txtTong
            // 
            this.txtTong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.txtTong.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTong.Location = new System.Drawing.Point(82, 9);
            this.txtTong.Multiline = true;
            this.txtTong.Name = "txtTong";
            this.txtTong.Size = new System.Drawing.Size(217, 33);
            this.txtTong.TabIndex = 10;
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnHuy.Enabled = false;
            this.btnHuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnHuy.Location = new System.Drawing.Point(142, 69);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(70, 40);
            this.btnHuy.TabIndex = 13;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label8.Location = new System.Drawing.Point(3, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 18);
            this.label8.TabIndex = 13;
            this.label8.Text = "Tổng tiền:";
            // 
            // nudGiaNhap
            // 
            this.nudGiaNhap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.nudGiaNhap.Enabled = false;
            this.nudGiaNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.nudGiaNhap.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudGiaNhap.Location = new System.Drawing.Point(354, 280);
            this.nudGiaNhap.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.nudGiaNhap.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudGiaNhap.Name = "nudGiaNhap";
            this.nudGiaNhap.Size = new System.Drawing.Size(101, 29);
            this.nudGiaNhap.TabIndex = 14;
            this.nudGiaNhap.Value = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            // 
            // btnGiaNhap
            // 
            this.btnGiaNhap.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGiaNhap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnGiaNhap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnGiaNhap.Location = new System.Drawing.Point(262, 277);
            this.btnGiaNhap.Name = "btnGiaNhap";
            this.btnGiaNhap.Size = new System.Drawing.Size(86, 35);
            this.btnGiaNhap.TabIndex = 10;
            this.btnGiaNhap.Text = "Đổi giá nhập";
            this.btnGiaNhap.UseVisualStyleBackColor = false;
            this.btnGiaNhap.Click += new System.EventHandler(this.btnGiaNhap_Click);
            // 
            // frmEditPhieuNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1230, 648);
            this.Controls.Add(this.btnGiaNhap);
            this.Controls.Add(this.nudGiaNhap);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtGC);
            this.Controls.Add(this.dgvCTPN);
            this.Controls.Add(this.btnThemMH);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtSearchMH);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.dgvMatHang);
            this.Controls.Add(this.tvNH);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvNH);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmEditPhieuNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông tin phiếu nhập kho";
            this.Load += new System.EventHandler(this.frmEditPhieuNhap_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTPN)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudGiaNhap)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbNhanVien;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TreeView tvNH;
        private System.Windows.Forms.DataGridView dgvMatHang;
        private System.Windows.Forms.DataGridView dgvNH;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.TextBox txtSearchMH;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnThemMH;
        private System.Windows.Forms.DataGridView dgvCTPN;
        private System.Windows.Forms.TextBox txtGC;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtTong;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.NumericUpDown nudGiaNhap;
        private System.Windows.Forms.Button btnGiaNhap;
        private System.Windows.Forms.TextBox txtMaPN;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gia;
        private System.Windows.Forms.DataGridViewTextBoxColumn SL;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn gch;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mh;
        private System.Windows.Forms.DataGridViewTextBoxColumn th;
        private System.Windows.Forms.DataGridViewTextBoxColumn DVT;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNhom;
        private System.Windows.Forms.DataGridViewTextBoxColumn GC;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txtNcc;
    }
}