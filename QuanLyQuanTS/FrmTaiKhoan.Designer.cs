namespace QuanLyQuanTS
{
    partial class FrmTaiKhoan
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
            this.txtTenTK = new System.Windows.Forms.TextBox();
            this.txtQuyenTK = new System.Windows.Forms.TextBox();
            this.txtMKCu = new System.Windows.Forms.TextBox();
            this.txtMKMoi = new System.Windows.Forms.TextBox();
            this.txtNhapLai = new System.Windows.Forms.TextBox();
            this.txtLuu = new System.Windows.Forms.Button();
            this.txtHuy = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtTenTK
            // 
            this.txtTenTK.Enabled = false;
            this.txtTenTK.Location = new System.Drawing.Point(184, 58);
            this.txtTenTK.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTenTK.Name = "txtTenTK";
            this.txtTenTK.Size = new System.Drawing.Size(284, 26);
            this.txtTenTK.TabIndex = 0;
            // 
            // txtQuyenTK
            // 
            this.txtQuyenTK.Enabled = false;
            this.txtQuyenTK.Location = new System.Drawing.Point(184, 148);
            this.txtQuyenTK.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtQuyenTK.Name = "txtQuyenTK";
            this.txtQuyenTK.Size = new System.Drawing.Size(284, 26);
            this.txtQuyenTK.TabIndex = 1;
            // 
            // txtMKCu
            // 
            this.txtMKCu.Location = new System.Drawing.Point(184, 242);
            this.txtMKCu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMKCu.Name = "txtMKCu";
            this.txtMKCu.Size = new System.Drawing.Size(284, 26);
            this.txtMKCu.TabIndex = 2;
            this.txtMKCu.UseSystemPasswordChar = true;
            // 
            // txtMKMoi
            // 
            this.txtMKMoi.Location = new System.Drawing.Point(184, 322);
            this.txtMKMoi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMKMoi.Name = "txtMKMoi";
            this.txtMKMoi.Size = new System.Drawing.Size(284, 26);
            this.txtMKMoi.TabIndex = 3;
            this.txtMKMoi.UseSystemPasswordChar = true;
            // 
            // txtNhapLai
            // 
            this.txtNhapLai.Location = new System.Drawing.Point(184, 423);
            this.txtNhapLai.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNhapLai.Name = "txtNhapLai";
            this.txtNhapLai.Size = new System.Drawing.Size(284, 26);
            this.txtNhapLai.TabIndex = 4;
            this.txtNhapLai.UseSystemPasswordChar = true;
            // 
            // txtLuu
            // 
            this.txtLuu.Location = new System.Drawing.Point(58, 527);
            this.txtLuu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtLuu.Name = "txtLuu";
            this.txtLuu.Size = new System.Drawing.Size(112, 68);
            this.txtLuu.TabIndex = 5;
            this.txtLuu.Text = "Lưu";
            this.txtLuu.UseVisualStyleBackColor = true;
            this.txtLuu.Click += new System.EventHandler(this.txtLuu_Click);
            // 
            // txtHuy
            // 
            this.txtHuy.Location = new System.Drawing.Point(340, 527);
            this.txtHuy.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtHuy.Name = "txtHuy";
            this.txtHuy.Size = new System.Drawing.Size(112, 69);
            this.txtHuy.TabIndex = 6;
            this.txtHuy.Text = "Hủy";
            this.txtHuy.UseVisualStyleBackColor = true;
            this.txtHuy.Click += new System.EventHandler(this.txtHuy_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 63);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Tên tài khoản :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 152);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Loại Tài Khoản :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 246);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Mật Khẩu :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 326);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Mật Khẩu Mới :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 423);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Nhập Lại Mật Khẩu :";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Location = new System.Drawing.Point(12, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(522, 33);
            this.label6.TabIndex = 14;
            this.label6.Text = "Thay đổi tài khoản";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 632);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtHuy);
            this.Controls.Add(this.txtLuu);
            this.Controls.Add(this.txtNhapLai);
            this.Controls.Add(this.txtMKMoi);
            this.Controls.Add(this.txtMKCu);
            this.Controls.Add(this.txtQuyenTK);
            this.Controls.Add(this.txtTenTK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmTaiKhoan";
            this.Text = "Thay đổi tài khoản";
            this.Load += new System.EventHandler(this.FrmTaiKhoan_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTenTK;
        private System.Windows.Forms.TextBox txtQuyenTK;
        private System.Windows.Forms.TextBox txtMKCu;
        private System.Windows.Forms.TextBox txtMKMoi;
        private System.Windows.Forms.TextBox txtNhapLai;
        private System.Windows.Forms.Button txtLuu;
        private System.Windows.Forms.Button txtHuy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}