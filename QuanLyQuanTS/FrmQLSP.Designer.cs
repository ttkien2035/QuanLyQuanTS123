namespace QuanLyQuanTS
{
    partial class FrmQLSP
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
            this.btnThem = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dgvSanPham = new System.Windows.Forms.DataGridView();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnReload = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFoodId = new System.Windows.Forms.TextBox();
            this.asasas = new System.Windows.Forms.Label();
            this.txtFoodName = new System.Windows.Forms.TextBox();
            this.qwwq = new System.Windows.Forms.Label();
            this.sasasas = new System.Windows.Forms.Label();
            this.TxtGia = new System.Windows.Forms.TextBox();
            this.txtCategory = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).BeginInit();
            this.SuspendLayout();
            // 
            // btnThem
            // 
            this.btnThem.AutoSize = true;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold);
            this.btnThem.ForeColor = System.Drawing.Color.Red;
            this.btnThem.Location = new System.Drawing.Point(22, 315);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(131, 46);
            this.btnThem.TabIndex = 16;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.ForeColor = System.Drawing.Color.Red;
            this.button2.Location = new System.Drawing.Point(622, 0);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(45, 46);
            this.button2.TabIndex = 15;
            this.button2.Text = "x";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dgvSanPham
            // 
            this.dgvSanPham.AllowUserToAddRows = false;
            this.dgvSanPham.AllowUserToDeleteRows = false;
            this.dgvSanPham.AllowUserToResizeColumns = false;
            this.dgvSanPham.AllowUserToResizeRows = false;
            this.dgvSanPham.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSanPham.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSanPham.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSanPham.Location = new System.Drawing.Point(315, 78);
            this.dgvSanPham.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvSanPham.Name = "dgvSanPham";
            this.dgvSanPham.ReadOnly = true;
            this.dgvSanPham.RowHeadersWidth = 62;
            this.dgvSanPham.Size = new System.Drawing.Size(352, 437);
            this.dgvSanPham.TabIndex = 13;
            this.dgvSanPham.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSanPham_CellClick);
            this.dgvSanPham.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSanPham_CellContentClick);
            // 
            // btnXoa
            // 
            this.btnXoa.AutoSize = true;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold);
            this.btnXoa.ForeColor = System.Drawing.Color.DarkSeaGreen;
            this.btnXoa.Location = new System.Drawing.Point(161, 427);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(131, 46);
            this.btnXoa.TabIndex = 17;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.AutoSize = true;
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold);
            this.btnSua.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.btnSua.Location = new System.Drawing.Point(161, 315);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(131, 46);
            this.btnSua.TabIndex = 18;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.AutoSize = true;
            this.btnHuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold);
            this.btnHuy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnHuy.Location = new System.Drawing.Point(161, 371);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(131, 46);
            this.btnHuy.TabIndex = 19;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.AutoSize = true;
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold);
            this.btnLuu.ForeColor = System.Drawing.Color.GreenYellow;
            this.btnLuu.Location = new System.Drawing.Point(22, 371);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(131, 46);
            this.btnLuu.TabIndex = 20;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnReload
            // 
            this.btnReload.AutoSize = true;
            this.btnReload.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold);
            this.btnReload.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnReload.Location = new System.Drawing.Point(22, 427);
            this.btnReload.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(131, 46);
            this.btnReload.TabIndex = 22;
            this.btnReload.Text = "ReLoad";
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 64);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 20);
            this.label1.TabIndex = 23;
            this.label1.Text = "ID :";
            // 
            // txtFoodId
            // 
            this.txtFoodId.Enabled = false;
            this.txtFoodId.Location = new System.Drawing.Point(116, 60);
            this.txtFoodId.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtFoodId.Name = "txtFoodId";
            this.txtFoodId.Size = new System.Drawing.Size(148, 26);
            this.txtFoodId.TabIndex = 24;
            // 
            // asasas
            // 
            this.asasas.AutoSize = true;
            this.asasas.Location = new System.Drawing.Point(18, 97);
            this.asasas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.asasas.Name = "asasas";
            this.asasas.Size = new System.Drawing.Size(69, 20);
            this.asasas.TabIndex = 25;
            this.asasas.Text = "Tên SP :";
            // 
            // txtFoodName
            // 
            this.txtFoodName.Location = new System.Drawing.Point(116, 97);
            this.txtFoodName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtFoodName.Name = "txtFoodName";
            this.txtFoodName.Size = new System.Drawing.Size(148, 26);
            this.txtFoodName.TabIndex = 26;
            // 
            // qwwq
            // 
            this.qwwq.AutoSize = true;
            this.qwwq.Location = new System.Drawing.Point(18, 187);
            this.qwwq.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.qwwq.Name = "qwwq";
            this.qwwq.Size = new System.Drawing.Size(42, 20);
            this.qwwq.TabIndex = 27;
            this.qwwq.Text = "Giá :";
            // 
            // sasasas
            // 
            this.sasasas.AutoSize = true;
            this.sasasas.Location = new System.Drawing.Point(18, 141);
            this.sasasas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.sasasas.Name = "sasasas";
            this.sasasas.Size = new System.Drawing.Size(82, 20);
            this.sasasas.TabIndex = 29;
            this.sasasas.Text = "Phân loại :";
            // 
            // TxtGia
            // 
            this.TxtGia.Location = new System.Drawing.Point(116, 183);
            this.TxtGia.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtGia.Name = "TxtGia";
            this.TxtGia.Size = new System.Drawing.Size(148, 26);
            this.TxtGia.TabIndex = 33;
            // 
            // txtCategory
            // 
            this.txtCategory.Location = new System.Drawing.Point(116, 138);
            this.txtCategory.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.Size = new System.Drawing.Size(148, 26);
            this.txtCategory.TabIndex = 34;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Location = new System.Drawing.Point(78, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(522, 33);
            this.label2.TabIndex = 35;
            this.label2.Text = "Quản lý sản phẩm";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmQLSP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(684, 561);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCategory);
            this.Controls.Add(this.TxtGia);
            this.Controls.Add(this.sasasas);
            this.Controls.Add(this.qwwq);
            this.Controls.Add(this.txtFoodName);
            this.Controls.Add(this.asasas);
            this.Controls.Add(this.txtFoodId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dgvSanPham);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmQLSP";
            this.Text = "FrmQLSP";
            this.Load += new System.EventHandler(this.FrmQLSP_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dgvSanPham;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFoodId;
        private System.Windows.Forms.Label asasas;
        private System.Windows.Forms.TextBox txtFoodName;
        private System.Windows.Forms.Label qwwq;
        private System.Windows.Forms.Label sasasas;
        private System.Windows.Forms.TextBox TxtGia;
        private System.Windows.Forms.TextBox txtCategory;
        private System.Windows.Forms.Label label2;
    }
}