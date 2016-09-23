namespace QuanLyBachHoa
{
    partial class frmQuanLyBanHang
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.txtKH = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cbNhanVien = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTienTra = new System.Windows.Forms.TextBox();
            this.txtTienKhach = new System.Windows.Forms.TextBox();
            this.txtTong = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnHuy = new System.Windows.Forms.Button();
            this.tvNH = new System.Windows.Forms.TreeView();
            this.dgvMatHang = new System.Windows.Forms.DataGridView();
            this.mHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tMH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dvitinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoaiMH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gchu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvNH = new System.Windows.Forms.DataGridView();
            this.dgvCTHD = new System.Windows.Forms.DataGridView();
            this.MaHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenMH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DVT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSearchMH = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.nudSL = new System.Windows.Forms.NumericUpDown();
            this.btnThem = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTHD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSL)).BeginInit();
            this.SuspendLayout();
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnThanhToan.Enabled = false;
            this.btnThanhToan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThanhToan.ForeColor = System.Drawing.Color.Black;
            this.btnThanhToan.Location = new System.Drawing.Point(286, 197);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(96, 53);
            this.btnThanhToan.TabIndex = 6;
            this.btnThanhToan.Text = "Thanh toán";
            this.btnThanhToan.UseVisualStyleBackColor = true;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.BackgroundImage = global::QuanLyBachHoa.Properties.Resources.bgGreen;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.txtTienTra);
            this.groupBox1.Controls.Add(this.txtTienKhach);
            this.groupBox1.Controls.Add(this.txtTong);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnThanhToan);
            this.groupBox1.Controls.Add(this.btnHuy);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.groupBox1.Location = new System.Drawing.Point(0, 281);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(809, 268);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thanh Toán";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.txtKH);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.cbNhanVien);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(597, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(210, 256);
            this.panel1.TabIndex = 22;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button2.BackgroundImage = global::QuanLyBachHoa.Properties.Resources.Plus__Orange;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(7, 194);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(70, 52);
            this.button2.TabIndex = 24;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // txtKH
            // 
            this.txtKH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.txtKH.Enabled = false;
            this.txtKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtKH.Location = new System.Drawing.Point(9, 153);
            this.txtKH.Multiline = true;
            this.txtKH.Name = "txtKH";
            this.txtKH.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtKH.Size = new System.Drawing.Size(192, 28);
            this.txtKH.TabIndex = 23;
            this.txtKH.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnSearch.BackgroundImage = global::QuanLyBachHoa.Properties.Resources.search;
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSearch.ForeColor = System.Drawing.Color.Black;
            this.btnSearch.Location = new System.Drawing.Point(135, 194);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(70, 52);
            this.btnSearch.TabIndex = 23;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(3, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 31);
            this.label5.TabIndex = 17;
            this.label5.Text = "Nhân viên:";
            // 
            // cbNhanVien
            // 
            this.cbNhanVien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.cbNhanVien.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbNhanVien.FormattingEnabled = true;
            this.cbNhanVien.Location = new System.Drawing.Point(7, 72);
            this.cbNhanVien.Name = "cbNhanVien";
            this.cbNhanVien.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cbNhanVien.Size = new System.Drawing.Size(198, 28);
            this.cbNhanVien.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(3, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 31);
            this.label3.TabIndex = 19;
            this.label3.Text = "Khách hàng:";
            // 
            // txtTienTra
            // 
            this.txtTienTra.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.txtTienTra.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTienTra.Location = new System.Drawing.Point(286, 133);
            this.txtTienTra.Multiline = true;
            this.txtTienTra.Name = "txtTienTra";
            this.txtTienTra.Size = new System.Drawing.Size(282, 45);
            this.txtTienTra.TabIndex = 21;
            this.txtTienTra.Text = "0";
            this.txtTienTra.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtTienKhach
            // 
            this.txtTienKhach.BackColor = System.Drawing.Color.White;
            this.txtTienKhach.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTienKhach.Location = new System.Drawing.Point(286, 82);
            this.txtTienKhach.Multiline = true;
            this.txtTienKhach.Name = "txtTienKhach";
            this.txtTienKhach.Size = new System.Drawing.Size(282, 45);
            this.txtTienKhach.TabIndex = 19;
            this.txtTienKhach.Text = "0";
            this.txtTienKhach.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTienKhach.TextChanged += new System.EventHandler(this.btnTienKhach_TextChanged);
            // 
            // txtTong
            // 
            this.txtTong.BackColor = System.Drawing.Color.White;
            this.txtTong.Enabled = false;
            this.txtTong.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTong.Location = new System.Drawing.Point(286, 31);
            this.txtTong.Multiline = true;
            this.txtTong.Name = "txtTong";
            this.txtTong.Size = new System.Drawing.Size(282, 45);
            this.txtTong.TabIndex = 18;
            this.txtTong.Text = "0";
            this.txtTong.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(4, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(219, 40);
            this.label4.TabIndex = 17;
            this.label4.Text = "Tiền Trả:";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(4, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(242, 40);
            this.label2.TabIndex = 15;
            this.label2.Text = "Tiền Khách Đưa:";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(4, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 40);
            this.label1.TabIndex = 14;
            this.label1.Text = "Tổng:";
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnHuy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnHuy.Enabled = false;
            this.btnHuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnHuy.ForeColor = System.Drawing.Color.Black;
            this.btnHuy.Location = new System.Drawing.Point(483, 198);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(85, 52);
            this.btnHuy.TabIndex = 14;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.button1_Click);
            // 
            // tvNH
            // 
            this.tvNH.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tvNH.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tvNH.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tvNH.FullRowSelect = true;
            this.tvNH.Indent = 30;
            this.tvNH.ItemHeight = 38;
            this.tvNH.Location = new System.Drawing.Point(597, 33);
            this.tvNH.Name = "tvNH";
            this.tvNH.Size = new System.Drawing.Size(212, 210);
            this.tvNH.TabIndex = 15;
            this.tvNH.TabStop = false;
            this.tvNH.DoubleClick += new System.EventHandler(this.tvNH_DoubleClick);
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
            this.gia,
            this.LoaiMH,
            this.gchu});
            this.dgvMatHang.Location = new System.Drawing.Point(809, 33);
            this.dgvMatHang.Name = "dgvMatHang";
            this.dgvMatHang.RowHeadersVisible = false;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dgvMatHang.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvMatHang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMatHang.Size = new System.Drawing.Size(565, 516);
            this.dgvMatHang.TabIndex = 23;
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
            this.tMH.HeaderText = "Tên mặt hàng";
            this.tMH.Name = "tMH";
            this.tMH.Width = 110;
            // 
            // Dvitinh
            // 
            this.Dvitinh.DataPropertyName = "DonViTinh";
            this.Dvitinh.HeaderText = "Đơn vị tính";
            this.Dvitinh.Name = "Dvitinh";
            this.Dvitinh.Width = 70;
            // 
            // gia
            // 
            this.gia.DataPropertyName = "GiaBan";
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Format = "C1";
            dataGridViewCellStyle1.NullValue = null;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.gia.DefaultCellStyle = dataGridViewCellStyle1;
            this.gia.HeaderText = "Giá";
            this.gia.Name = "gia";
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
            // dgvNH
            // 
            this.dgvNH.AllowUserToAddRows = false;
            this.dgvNH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNH.Location = new System.Drawing.Point(857, 323);
            this.dgvNH.Name = "dgvNH";
            this.dgvNH.Size = new System.Drawing.Size(64, 74);
            this.dgvNH.TabIndex = 30;
            // 
            // dgvCTHD
            // 
            this.dgvCTHD.AllowUserToAddRows = false;
            this.dgvCTHD.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.dgvCTHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCTHD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaHang,
            this.TenMH,
            this.DVT,
            this.GiaBan,
            this.SoLuong,
            this.DonGia});
            this.dgvCTHD.Location = new System.Drawing.Point(0, 0);
            this.dgvCTHD.Name = "dgvCTHD";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCTHD.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvCTHD.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dgvCTHD.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvCTHD.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCTHD.Size = new System.Drawing.Size(598, 275);
            this.dgvCTHD.TabIndex = 1;
            this.dgvCTHD.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvCTHD_CellMouseDoubleClick);
            // 
            // MaHang
            // 
            dataGridViewCellStyle3.NullValue = null;
            this.MaHang.DefaultCellStyle = dataGridViewCellStyle3;
            this.MaHang.HeaderText = "Mã Hàng";
            this.MaHang.Name = "MaHang";
            this.MaHang.Width = 70;
            // 
            // TenMH
            // 
            this.TenMH.HeaderText = "Mặt hàng";
            this.TenMH.Name = "TenMH";
            this.TenMH.Width = 120;
            // 
            // DVT
            // 
            this.DVT.HeaderText = "DVT";
            this.DVT.Name = "DVT";
            // 
            // GiaBan
            // 
            dataGridViewCellStyle4.Format = "C1";
            dataGridViewCellStyle4.NullValue = null;
            this.GiaBan.DefaultCellStyle = dataGridViewCellStyle4;
            this.GiaBan.HeaderText = "Giá bán";
            this.GiaBan.Name = "GiaBan";
            // 
            // SoLuong
            // 
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.SoLuong.DefaultCellStyle = dataGridViewCellStyle5;
            this.SoLuong.HeaderText = "Số lượng";
            this.SoLuong.Name = "SoLuong";
            // 
            // DonGia
            // 
            dataGridViewCellStyle6.Format = "C1";
            dataGridViewCellStyle6.NullValue = null;
            this.DonGia.DefaultCellStyle = dataGridViewCellStyle6;
            this.DonGia.HeaderText = "Đơn giá";
            this.DonGia.Name = "DonGia";
            this.DonGia.Width = 110;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(999, 5);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 17);
            this.label6.TabIndex = 24;
            this.label6.Text = "Mặt hàng:";
            // 
            // txtSearchMH
            // 
            this.txtSearchMH.BackColor = System.Drawing.Color.White;
            this.txtSearchMH.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearchMH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtSearchMH.Location = new System.Drawing.Point(1071, 3);
            this.txtSearchMH.Multiline = true;
            this.txtSearchMH.Name = "txtSearchMH";
            this.txtSearchMH.Size = new System.Drawing.Size(222, 23);
            this.txtSearchMH.TabIndex = 25;
            this.txtSearchMH.TextChanged += new System.EventHandler(this.button2_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.Location = new System.Drawing.Point(809, 5);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 17);
            this.label7.TabIndex = 27;
            this.label7.Text = "SL:";
            // 
            // nudSL
            // 
            this.nudSL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.nudSL.Location = new System.Drawing.Point(851, 4);
            this.nudSL.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudSL.Name = "nudSL";
            this.nudSL.Size = new System.Drawing.Size(64, 23);
            this.nudSL.TabIndex = 28;
            this.nudSL.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.DarkKhaki;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThem.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnThem.Location = new System.Drawing.Point(931, 0);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(62, 30);
            this.btnThem.TabIndex = 29;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(597, -1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(212, 39);
            this.button1.TabIndex = 23;
            this.button1.Text = "Refresh";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // frmQuanLyBanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ClientSize = new System.Drawing.Size(1370, 552);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvCTHD);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.nudSL);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtSearchMH);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dgvMatHang);
            this.Controls.Add(this.dgvNH);
            this.Controls.Add(this.tvNH);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmQuanLyBanHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý bán hàng";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmQuanLyBanHang_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTHD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSL)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnHuy;
        public System.Windows.Forms.TreeView tvNH;
        private System.Windows.Forms.TextBox txtTienTra;
        private System.Windows.Forms.TextBox txtTienKhach;
        private System.Windows.Forms.TextBox txtTong;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbNhanVien;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvMatHang;
        private System.Windows.Forms.DataGridView dgvNH;
        private System.Windows.Forms.DataGridView dgvCTHD;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenMH;
        private System.Windows.Forms.DataGridViewTextBoxColumn DVT;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSearchMH;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown nudSL;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DataGridViewTextBoxColumn mHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn tMH;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dvitinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn gia;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoaiMH;
        private System.Windows.Forms.DataGridViewTextBoxColumn gchu;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}