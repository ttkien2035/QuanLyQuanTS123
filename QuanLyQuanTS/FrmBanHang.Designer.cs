namespace QuanLyQuanTS
{
    partial class FrmBanHang
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
            this.btnRefresh = new System.Windows.Forms.Button();
            this.addBill = new System.Windows.Forms.Button();
            this.btnXemChiTiet = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvBanHang = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBanHang)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.Location = new System.Drawing.Point(630, 232);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(130, 68);
            this.btnRefresh.TabIndex = 11;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // addBill
            // 
            this.addBill.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addBill.Location = new System.Drawing.Point(630, 98);
            this.addBill.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.addBill.Name = "addBill";
            this.addBill.Size = new System.Drawing.Size(130, 58);
            this.addBill.TabIndex = 13;
            this.addBill.Text = "Thêm hóa đơn";
            this.addBill.UseVisualStyleBackColor = true;
            this.addBill.Click += new System.EventHandler(this.addBill_Click);
            // 
            // btnXemChiTiet
            // 
            this.btnXemChiTiet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXemChiTiet.Location = new System.Drawing.Point(630, 162);
            this.btnXemChiTiet.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnXemChiTiet.Name = "btnXemChiTiet";
            this.btnXemChiTiet.Size = new System.Drawing.Size(130, 60);
            this.btnXemChiTiet.TabIndex = 14;
            this.btnXemChiTiet.Text = "Xem Chi tiết";
            this.btnXemChiTiet.UseVisualStyleBackColor = true;
            this.btnXemChiTiet.Click += new System.EventHandler(this.thanhToan_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(183, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(360, 70);
            this.label1.TabIndex = 24;
            this.label1.Text = "Bán hàng";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvBanHang
            // 
            this.dgvBanHang.AllowUserToAddRows = false;
            this.dgvBanHang.AllowUserToDeleteRows = false;
            this.dgvBanHang.AllowUserToResizeColumns = false;
            this.dgvBanHang.AllowUserToResizeRows = false;
            this.dgvBanHang.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvBanHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBanHang.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvBanHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBanHang.Location = new System.Drawing.Point(40, 98);
            this.dgvBanHang.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvBanHang.Name = "dgvBanHang";
            this.dgvBanHang.RowHeadersWidth = 51;
            this.dgvBanHang.Size = new System.Drawing.Size(580, 352);
            this.dgvBanHang.TabIndex = 8;
            // 
            // FrmBanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 489);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnXemChiTiet);
            this.Controls.Add(this.addBill);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.dgvBanHang);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmBanHang";
            this.Text = "FrmBanHang";
            this.Load += new System.EventHandler(this.FrmBanHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBanHang)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button addBill;
        private System.Windows.Forms.Button btnXemChiTiet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvBanHang;
    }
}