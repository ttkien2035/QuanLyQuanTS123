namespace QuanLyQuanTS
{
    partial class FrmLayHang
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_ID = new System.Windows.Forms.TextBox();
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.textBox_Type = new System.Windows.Forms.TextBox();
            this.textBox_Count = new System.Windows.Forms.TextBox();
            this.button_XacNhan = new System.Windows.Forms.Button();
            this.button_Thoat = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_Cost = new System.Windows.Forms.TextBox();
            this.textBox_Pro = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(137, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lấy hàng từ kho";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "id";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Type";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Count (cần lấy)";
            // 
            // textBox_ID
            // 
            this.textBox_ID.Location = new System.Drawing.Point(126, 69);
            this.textBox_ID.Name = "textBox_ID";
            this.textBox_ID.ReadOnly = true;
            this.textBox_ID.Size = new System.Drawing.Size(100, 20);
            this.textBox_ID.TabIndex = 5;
            // 
            // textBox_Name
            // 
            this.textBox_Name.Location = new System.Drawing.Point(126, 115);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.ReadOnly = true;
            this.textBox_Name.Size = new System.Drawing.Size(100, 20);
            this.textBox_Name.TabIndex = 5;
            // 
            // textBox_Type
            // 
            this.textBox_Type.Location = new System.Drawing.Point(126, 157);
            this.textBox_Type.Name = "textBox_Type";
            this.textBox_Type.ReadOnly = true;
            this.textBox_Type.Size = new System.Drawing.Size(100, 20);
            this.textBox_Type.TabIndex = 5;
            // 
            // textBox_Count
            // 
            this.textBox_Count.Location = new System.Drawing.Point(126, 199);
            this.textBox_Count.Name = "textBox_Count";
            this.textBox_Count.Size = new System.Drawing.Size(100, 20);
            this.textBox_Count.TabIndex = 5;
            // 
            // button_XacNhan
            // 
            this.button_XacNhan.Location = new System.Drawing.Point(64, 349);
            this.button_XacNhan.Name = "button_XacNhan";
            this.button_XacNhan.Size = new System.Drawing.Size(75, 23);
            this.button_XacNhan.TabIndex = 6;
            this.button_XacNhan.Text = "Xác nhận";
            this.button_XacNhan.UseVisualStyleBackColor = true;
            this.button_XacNhan.Click += new System.EventHandler(this.button_XacNhan_Click);
            // 
            // button_Thoat
            // 
            this.button_Thoat.Location = new System.Drawing.Point(173, 349);
            this.button_Thoat.Name = "button_Thoat";
            this.button_Thoat.Size = new System.Drawing.Size(75, 23);
            this.button_Thoat.TabIndex = 7;
            this.button_Thoat.Text = "Thoát";
            this.button_Thoat.UseVisualStyleBackColor = true;
            this.button_Thoat.Click += new System.EventHandler(this.button_Thoat_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(55, 247);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Cost";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(45, 291);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Nhà cung cấp";
            // 
            // textBox_Cost
            // 
            this.textBox_Cost.Location = new System.Drawing.Point(126, 240);
            this.textBox_Cost.Name = "textBox_Cost";
            this.textBox_Cost.ReadOnly = true;
            this.textBox_Cost.Size = new System.Drawing.Size(100, 20);
            this.textBox_Cost.TabIndex = 10;
            // 
            // textBox_Pro
            // 
            this.textBox_Pro.Location = new System.Drawing.Point(126, 284);
            this.textBox_Pro.Name = "textBox_Pro";
            this.textBox_Pro.ReadOnly = true;
            this.textBox_Pro.Size = new System.Drawing.Size(100, 20);
            this.textBox_Pro.TabIndex = 11;
            // 
            // FrmLayHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 396);
            this.Controls.Add(this.textBox_Pro);
            this.Controls.Add(this.textBox_Cost);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button_Thoat);
            this.Controls.Add(this.button_XacNhan);
            this.Controls.Add(this.textBox_Count);
            this.Controls.Add(this.textBox_Type);
            this.Controls.Add(this.textBox_Name);
            this.Controls.Add(this.textBox_ID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmLayHang";
            this.Text = "FrmLayHang";
            this.Load += new System.EventHandler(this.FrmLayHang_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_ID;
        private System.Windows.Forms.TextBox textBox_Name;
        private System.Windows.Forms.TextBox textBox_Type;
        private System.Windows.Forms.TextBox textBox_Count;
        private System.Windows.Forms.Button button_XacNhan;
        private System.Windows.Forms.Button button_Thoat;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_Cost;
        private System.Windows.Forms.TextBox textBox_Pro;
    }
}