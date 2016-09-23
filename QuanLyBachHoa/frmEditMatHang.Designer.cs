namespace QuanLyBachHoa
{
    partial class frmEditMatHang
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
            this.txtGC = new System.Windows.Forms.TextBox();
            this.cbNhomHang = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lblIncorrect = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.cbNuocSX = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtHSD = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTrongLuong = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDVT = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTenMH = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaHang = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtGiaBan = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtGiaNhap = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtThemNuocSX = new System.Windows.Forms.Button();
            this.txtRefresh = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtGC
            // 
            this.txtGC.BackColor = System.Drawing.Color.White;
            this.txtGC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtGC.Location = new System.Drawing.Point(131, 285);
            this.txtGC.Multiline = true;
            this.txtGC.Name = "txtGC";
            this.txtGC.Size = new System.Drawing.Size(273, 88);
            this.txtGC.TabIndex = 79;
            this.txtGC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGC_KeyPress);
            // 
            // cbNhomHang
            // 
            this.cbNhomHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbNhomHang.FormattingEnabled = true;
            this.cbNhomHang.Items.AddRange(new object[] {
            "Nam",
            "Nu"});
            this.cbNhomHang.Location = new System.Drawing.Point(131, 138);
            this.cbNhomHang.Name = "cbNhomHang";
            this.cbNhomHang.Size = new System.Drawing.Size(183, 23);
            this.cbNhomHang.TabIndex = 78;
            this.cbNhomHang.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbNhomHang_KeyPress);
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(11, 386);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 52);
            this.label8.TabIndex = 77;
            this.label8.Text = "Refresh lại sau khi chỉnh sủa thông tin :)";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblIncorrect
            // 
            this.lblIncorrect.BackColor = System.Drawing.Color.Transparent;
            this.lblIncorrect.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblIncorrect.ForeColor = System.Drawing.Color.Red;
            this.lblIncorrect.Location = new System.Drawing.Point(131, 11);
            this.lblIncorrect.Name = "lblIncorrect";
            this.lblIncorrect.Size = new System.Drawing.Size(272, 20);
            this.lblIncorrect.TabIndex = 76;
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThoat.Location = new System.Drawing.Point(313, 386);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(90, 42);
            this.btnThoat.TabIndex = 75;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnLuu.Location = new System.Drawing.Point(190, 386);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(90, 42);
            this.btnLuu.TabIndex = 74;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // cbNuocSX
            // 
            this.cbNuocSX.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbNuocSX.Location = new System.Drawing.Point(131, 247);
            this.cbNuocSX.Name = "cbNuocSX";
            this.cbNuocSX.Size = new System.Drawing.Size(183, 23);
            this.cbNuocSX.TabIndex = 70;
            this.cbNuocSX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbNuocSX_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(12, 253);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 15);
            this.label7.TabIndex = 73;
            this.label7.Text = "Nước sản xuất:";
            // 
            // txtHSD
            // 
            this.txtHSD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtHSD.Location = new System.Drawing.Point(131, 217);
            this.txtHSD.Name = "txtHSD";
            this.txtHSD.Size = new System.Drawing.Size(183, 21);
            this.txtHSD.TabIndex = 69;
            this.txtHSD.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHSD_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(12, 218);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 15);
            this.label6.TabIndex = 72;
            this.label6.Text = "HSD:";
            // 
            // txtTrongLuong
            // 
            this.txtTrongLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTrongLuong.Location = new System.Drawing.Point(131, 191);
            this.txtTrongLuong.Name = "txtTrongLuong";
            this.txtTrongLuong.Size = new System.Drawing.Size(183, 21);
            this.txtTrongLuong.TabIndex = 67;
            this.txtTrongLuong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTrongLuong_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(12, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 15);
            this.label5.TabIndex = 71;
            this.label5.Text = "Trọng lượng:";
            // 
            // txtDVT
            // 
            this.txtDVT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtDVT.Location = new System.Drawing.Point(131, 165);
            this.txtDVT.Name = "txtDVT";
            this.txtDVT.Size = new System.Drawing.Size(183, 21);
            this.txtDVT.TabIndex = 66;
            this.txtDVT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDVT_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(12, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 15);
            this.label4.TabIndex = 68;
            this.label4.Text = "DVT:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(12, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 15);
            this.label3.TabIndex = 65;
            this.label3.Text = "Nhóm hàng:";
            // 
            // txtTenMH
            // 
            this.txtTenMH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtTenMH.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTenMH.Location = new System.Drawing.Point(131, 60);
            this.txtTenMH.Name = "txtTenMH";
            this.txtTenMH.Size = new System.Drawing.Size(272, 21);
            this.txtTenMH.TabIndex = 64;
            this.txtTenMH.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTenMH_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(12, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 15);
            this.label2.TabIndex = 63;
            this.label2.Text = "Mặt hàng:";
            // 
            // txtMaHang
            // 
            this.txtMaHang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.txtMaHang.Enabled = false;
            this.txtMaHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMaHang.Location = new System.Drawing.Point(131, 34);
            this.txtMaHang.Name = "txtMaHang";
            this.txtMaHang.Size = new System.Drawing.Size(183, 21);
            this.txtMaHang.TabIndex = 62;
            this.txtMaHang.Text = "Defaul";
            this.txtMaHang.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMaHang_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(12, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 61;
            this.label1.Text = "Mã hàng:";
            // 
            // txtGiaBan
            // 
            this.txtGiaBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtGiaBan.Location = new System.Drawing.Point(131, 112);
            this.txtGiaBan.Name = "txtGiaBan";
            this.txtGiaBan.Size = new System.Drawing.Size(183, 21);
            this.txtGiaBan.TabIndex = 81;
            this.txtGiaBan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGiaBan_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(12, 113);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 15);
            this.label9.TabIndex = 83;
            this.label9.Text = "Giá bán:";
            // 
            // txtGiaNhap
            // 
            this.txtGiaNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtGiaNhap.Location = new System.Drawing.Point(131, 86);
            this.txtGiaNhap.Name = "txtGiaNhap";
            this.txtGiaNhap.Size = new System.Drawing.Size(183, 21);
            this.txtGiaNhap.TabIndex = 80;
            this.txtGiaNhap.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGiaNhap_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(12, 87);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 15);
            this.label10.TabIndex = 82;
            this.label10.Text = "Giá nhập:";
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Location = new System.Drawing.Point(339, 191);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 22);
            this.label11.TabIndex = 84;
            this.label11.Text = "gram";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtThemNuocSX
            // 
            this.txtThemNuocSX.BackgroundImage = global::QuanLyBachHoa.Properties.Resources.add;
            this.txtThemNuocSX.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.txtThemNuocSX.Location = new System.Drawing.Point(320, 245);
            this.txtThemNuocSX.Name = "txtThemNuocSX";
            this.txtThemNuocSX.Size = new System.Drawing.Size(30, 23);
            this.txtThemNuocSX.TabIndex = 85;
            this.txtThemNuocSX.UseVisualStyleBackColor = true;
            this.txtThemNuocSX.Click += new System.EventHandler(this.txtThemNuocSX_Click);
            // 
            // txtRefresh
            // 
            this.txtRefresh.BackgroundImage = global::QuanLyBachHoa.Properties.Resources.refresh;
            this.txtRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.txtRefresh.Location = new System.Drawing.Point(368, 245);
            this.txtRefresh.Name = "txtRefresh";
            this.txtRefresh.Size = new System.Drawing.Size(35, 23);
            this.txtRefresh.TabIndex = 86;
            this.txtRefresh.UseVisualStyleBackColor = true;
            this.txtRefresh.Click += new System.EventHandler(this.txtRefresh_Click);
            // 
            // frmEditMatHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::QuanLyBachHoa.Properties.Resources.tt;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(416, 436);
            this.Controls.Add(this.txtRefresh);
            this.Controls.Add(this.txtThemNuocSX);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtGiaBan);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtGiaNhap);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtGC);
            this.Controls.Add(this.cbNhomHang);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblIncorrect);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.cbNuocSX);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtHSD);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtTrongLuong);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDVT);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTenMH);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMaHang);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.Name = "frmEditMatHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông tin mặt hàng";
            this.Load += new System.EventHandler(this.frmEditMatHang_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox txtGC;
        public System.Windows.Forms.ComboBox cbNhomHang;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblIncorrect;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnLuu;
        public System.Windows.Forms.ComboBox cbNuocSX;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox txtHSD;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox txtTrongLuong;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txtDVT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txtTenMH;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtMaHang;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtGiaBan;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.TextBox txtGiaNhap;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button txtThemNuocSX;
        private System.Windows.Forms.Button txtRefresh;
    }
}