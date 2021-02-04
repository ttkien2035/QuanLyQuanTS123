namespace QuanLyQuanTS
{
    partial class FrmThemHoaDon
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
            this.dgvListFood = new System.Windows.Forms.DataGridView();
            this.dgvListUsers = new System.Windows.Forms.DataGridView();
            this.btn_addBill = new System.Windows.Forms.Button();
            this.txb_userid = new System.Windows.Forms.TextBox();
            this.txb_foodid = new System.Windows.Forms.TextBox();
            this.txb_counts = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listViewFood = new System.Windows.Forms.ListView();
            this.button_XacNhan = new System.Windows.Forms.Button();
            this.button_ThanhToan = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListFood)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListFood
            // 
            this.dgvListFood.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListFood.Location = new System.Drawing.Point(278, 12);
            this.dgvListFood.Name = "dgvListFood";
            this.dgvListFood.Size = new System.Drawing.Size(527, 210);
            this.dgvListFood.TabIndex = 0;
            // 
            // dgvListUsers
            // 
            this.dgvListUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListUsers.Location = new System.Drawing.Point(278, 237);
            this.dgvListUsers.Name = "dgvListUsers";
            this.dgvListUsers.Size = new System.Drawing.Size(527, 201);
            this.dgvListUsers.TabIndex = 1;
            // 
            // btn_addBill
            // 
            this.btn_addBill.Location = new System.Drawing.Point(0, 390);
            this.btn_addBill.Name = "btn_addBill";
            this.btn_addBill.Size = new System.Drawing.Size(85, 39);
            this.btn_addBill.TabIndex = 2;
            this.btn_addBill.Text = "Add Bill";
            this.btn_addBill.UseVisualStyleBackColor = true;
            this.btn_addBill.Click += new System.EventHandler(this.btn_addBill_Click);
            // 
            // txb_userid
            // 
            this.txb_userid.Location = new System.Drawing.Point(89, 267);
            this.txb_userid.Name = "txb_userid";
            this.txb_userid.Size = new System.Drawing.Size(100, 20);
            this.txb_userid.TabIndex = 4;
            // 
            // txb_foodid
            // 
            this.txb_foodid.Location = new System.Drawing.Point(89, 313);
            this.txb_foodid.Name = "txb_foodid";
            this.txb_foodid.Size = new System.Drawing.Size(100, 20);
            this.txb_foodid.TabIndex = 4;
            this.txb_foodid.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txb_counts
            // 
            this.txb_counts.Location = new System.Drawing.Point(89, 352);
            this.txb_counts.Name = "txb_counts";
            this.txb_counts.Size = new System.Drawing.Size(100, 20);
            this.txb_counts.TabIndex = 4;
            this.txb_counts.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 274);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "User id";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 313);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Food id";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 352);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Counts";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(110, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Hóa đơn";
            // 
            // listViewFood
            // 
            this.listViewFood.HideSelection = false;
            this.listViewFood.Location = new System.Drawing.Point(0, 28);
            this.listViewFood.Name = "listViewFood";
            this.listViewFood.Size = new System.Drawing.Size(257, 208);
            this.listViewFood.TabIndex = 7;
            this.listViewFood.UseCompatibleStateImageBehavior = false;
            // 
            // button_XacNhan
            // 
            this.button_XacNhan.Location = new System.Drawing.Point(101, 398);
            this.button_XacNhan.Name = "button_XacNhan";
            this.button_XacNhan.Size = new System.Drawing.Size(75, 23);
            this.button_XacNhan.TabIndex = 8;
            this.button_XacNhan.Text = "Xác nhận";
            this.button_XacNhan.UseVisualStyleBackColor = true;
            this.button_XacNhan.Click += new System.EventHandler(this.button_XacNhan_Click);
            // 
            // button_ThanhToan
            // 
            this.button_ThanhToan.Location = new System.Drawing.Point(197, 398);
            this.button_ThanhToan.Name = "button_ThanhToan";
            this.button_ThanhToan.Size = new System.Drawing.Size(75, 23);
            this.button_ThanhToan.TabIndex = 9;
            this.button_ThanhToan.Text = "Thanh toán";
            this.button_ThanhToan.UseVisualStyleBackColor = true;
            this.button_ThanhToan.Click += new System.EventHandler(this.button2_Click);
            // 
            // FrmThemHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 450);
            this.Controls.Add(this.button_ThanhToan);
            this.Controls.Add(this.button_XacNhan);
            this.Controls.Add(this.listViewFood);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txb_counts);
            this.Controls.Add(this.txb_foodid);
            this.Controls.Add(this.txb_userid);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_addBill);
            this.Controls.Add(this.dgvListUsers);
            this.Controls.Add(this.dgvListFood);
            this.Name = "FrmThemHoaDon";
            this.Text = "FrmThemHoaDon";
            this.Load += new System.EventHandler(this.FrmThemHoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListFood)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListUsers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListFood;
        private System.Windows.Forms.DataGridView dgvListUsers;
        private System.Windows.Forms.Button btn_addBill;
        private System.Windows.Forms.TextBox txb_userid;
        private System.Windows.Forms.TextBox txb_foodid;
        private System.Windows.Forms.TextBox txb_counts;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listViewFood;
        private System.Windows.Forms.Button button_XacNhan;
        private System.Windows.Forms.Button button_ThanhToan;
    }
}