namespace QuanLyQuanTS
{
    partial class FrmHoaDonChiTiet
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
            this.dgvHoaDonChiTiet = new System.Windows.Forms.DataGridView();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDonChiTiet)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvHoaDonChiTiet
            // 
            this.dgvHoaDonChiTiet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHoaDonChiTiet.Location = new System.Drawing.Point(40, 28);
            this.dgvHoaDonChiTiet.Name = "dgvHoaDonChiTiet";
            this.dgvHoaDonChiTiet.Size = new System.Drawing.Size(683, 327);
            this.dgvHoaDonChiTiet.TabIndex = 0;
            this.dgvHoaDonChiTiet.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHoaDonChiTiet_CellClick);
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.Location = new System.Drawing.Point(304, 384);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(75, 35);
            this.btnThanhToan.TabIndex = 1;
            this.btnThanhToan.Text = "Thanh Toan";
            this.btnThanhToan.UseVisualStyleBackColor = true;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(431, 390);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 2;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // FrmHoaDonChiTiet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnThanhToan);
            this.Controls.Add(this.dgvHoaDonChiTiet);
            this.Name = "FrmHoaDonChiTiet";
            this.Text = "FrmHoaDonChiTiet";
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDonChiTiet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvHoaDonChiTiet;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.Button btnRefresh;
    }
}