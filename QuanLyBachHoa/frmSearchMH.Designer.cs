namespace QuanLyBachHoa
{
    partial class frmSearchMH
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
            this.dgvMatHang = new System.Windows.Forms.DataGridView();
            this.txtSearchMH = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnChon = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.mHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tMH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dvitinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoaiMH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gchu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatHang)).BeginInit();
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
            this.gia,
            this.LoaiMH,
            this.gchu});
            this.dgvMatHang.Location = new System.Drawing.Point(2, 49);
            this.dgvMatHang.Name = "dgvMatHang";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dgvMatHang.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvMatHang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMatHang.Size = new System.Drawing.Size(671, 332);
            this.dgvMatHang.TabIndex = 26;
            // 
            // txtSearchMH
            // 
            this.txtSearchMH.BackColor = System.Drawing.Color.White;
            this.txtSearchMH.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearchMH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtSearchMH.Location = new System.Drawing.Point(89, 20);
            this.txtSearchMH.Multiline = true;
            this.txtSearchMH.Name = "txtSearchMH";
            this.txtSearchMH.Size = new System.Drawing.Size(211, 23);
            this.txtSearchMH.TabIndex = 1;
            this.txtSearchMH.TextChanged += new System.EventHandler(this.txtSearchMH_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(12, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 17);
            this.label6.TabIndex = 27;
            this.label6.Text = "&Mặt hàng:";
            // 
            // btnChon
            // 
            this.btnChon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnChon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnChon.Location = new System.Drawing.Point(474, 387);
            this.btnChon.Name = "btnChon";
            this.btnChon.Size = new System.Drawing.Size(75, 29);
            this.btnChon.TabIndex = 29;
            this.btnChon.Text = "Chọn";
            this.btnChon.UseVisualStyleBackColor = false;
            this.btnChon.Click += new System.EventHandler(this.btnChon_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThoat.Location = new System.Drawing.Point(591, 387);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 29);
            this.btnThoat.TabIndex = 30;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
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
            this.tMH.Width = 150;
            // 
            // Dvitinh
            // 
            this.Dvitinh.DataPropertyName = "DonViTinh";
            this.Dvitinh.HeaderText = "Đơn vị tính";
            this.Dvitinh.Name = "Dvitinh";
            // 
            // gia
            // 
            this.gia.DataPropertyName = "GiaBan";
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Format = "C1";
            dataGridViewCellStyle1.NullValue = null;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.gia.DefaultCellStyle = dataGridViewCellStyle1;
            this.gia.HeaderText = "Giá bán";
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
            // frmSearchMH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(678, 427);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnChon);
            this.Controls.Add(this.txtSearchMH);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dgvMatHang);
            this.MaximizeBox = false;
            this.Name = "frmSearchMH";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tìm kiếm mặt hàng";
            this.Load += new System.EventHandler(this.frmSearchMH_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatHang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMatHang;
        private System.Windows.Forms.TextBox txtSearchMH;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnChon;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.DataGridViewTextBoxColumn mHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn tMH;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dvitinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn gia;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoaiMH;
        private System.Windows.Forms.DataGridViewTextBoxColumn gchu;
    }
}