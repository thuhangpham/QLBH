namespace QuanLyBachHoa
{
    partial class frmEditLKH
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEditLKH));
            this.txtGC = new System.Windows.Forms.TextBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.txtTenLKH = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaLKH = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Corect = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtGC
            // 
            this.txtGC.Location = new System.Drawing.Point(133, 83);
            this.txtGC.Multiline = true;
            this.txtGC.Name = "txtGC";
            this.txtGC.Size = new System.Drawing.Size(272, 77);
            this.txtGC.TabIndex = 35;
            this.txtGC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGC_KeyPress);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnThoat.Location = new System.Drawing.Point(330, 183);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 31);
            this.btnThoat.TabIndex = 33;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnLuu.Location = new System.Drawing.Point(202, 183);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 31);
            this.btnLuu.TabIndex = 32;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // txtTenLKH
            // 
            this.txtTenLKH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtTenLKH.Location = new System.Drawing.Point(133, 57);
            this.txtTenLKH.Name = "txtTenLKH";
            this.txtTenLKH.Size = new System.Drawing.Size(272, 20);
            this.txtTenLKH.TabIndex = 21;
            this.txtTenLKH.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTenKH_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(10, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 15);
            this.label2.TabIndex = 20;
            this.label2.Text = "Tên loại khách:";
            // 
            // txtMaLKH
            // 
            this.txtMaLKH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.txtMaLKH.Enabled = false;
            this.txtMaLKH.Location = new System.Drawing.Point(133, 31);
            this.txtMaLKH.Name = "txtMaLKH";
            this.txtMaLKH.Size = new System.Drawing.Size(121, 20);
            this.txtMaLKH.TabIndex = 19;
            this.txtMaLKH.Text = "Defaul";
            this.txtMaLKH.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMaKH_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(14, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 15);
            this.label1.TabIndex = 18;
            this.label1.Text = "Mã loại khách:";
            // 
            // Corect
            // 
            this.Corect.BackColor = System.Drawing.Color.Transparent;
            this.Corect.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Corect.ForeColor = System.Drawing.Color.Red;
            this.Corect.Location = new System.Drawing.Point(133, 9);
            this.Corect.Name = "Corect";
            this.Corect.Size = new System.Drawing.Size(272, 23);
            this.Corect.TabIndex = 36;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(10, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(164, 52);
            this.label4.TabIndex = 37;
            this.label4.Text = "Nhấn f5 Refresh lại sau khi chỉnh sủa thông tin :)";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmEditLKH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.BackgroundImage = global::QuanLyBachHoa.Properties.Resources.tt;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(434, 226);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Corect);
            this.Controls.Add(this.txtGC);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.txtTenLKH);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMaLKH);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmEditLKH";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông Tin Loại Khách Hàng";
            this.Load += new System.EventHandler(this.frmEditLKH_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox txtGC;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnLuu;
        public System.Windows.Forms.TextBox txtTenLKH;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtMaLKH;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Corect;
        private System.Windows.Forms.Label label4;
    }
}