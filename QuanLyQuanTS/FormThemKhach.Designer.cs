namespace QuanLyQuanTS
{
    partial class FormThemKhach
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
            this.comboBoxRank = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dateTimePickerdate = new System.Windows.Forms.DateTimePicker();
            this.numericUpDownpoint = new System.Windows.Forms.NumericUpDown();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.buttonEx = new System.Windows.Forms.Button();
            this.buttonOK = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxSDT = new System.Windows.Forms.TextBox();
            this.textBoxpass = new System.Windows.Forms.TextBox();
            this.textBoxuname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownpoint)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxRank
            // 
            this.comboBoxRank.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRank.FormattingEnabled = true;
            this.comboBoxRank.Items.AddRange(new object[] {
            "bronze",
            "silver",
            "gold"});
            this.comboBoxRank.Location = new System.Drawing.Point(192, 244);
            this.comboBoxRank.Name = "comboBoxRank";
            this.comboBoxRank.Size = new System.Drawing.Size(279, 28);
            this.comboBoxRank.TabIndex = 50;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label8.Location = new System.Drawing.Point(21, 238);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(165, 34);
            this.label8.TabIndex = 49;
            this.label8.Text = "Rank :";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dateTimePickerdate
            // 
            this.dateTimePickerdate.Location = new System.Drawing.Point(192, 340);
            this.dateTimePickerdate.Name = "dateTimePickerdate";
            this.dateTimePickerdate.Size = new System.Drawing.Size(279, 26);
            this.dateTimePickerdate.TabIndex = 48;
            // 
            // numericUpDownpoint
            // 
            this.numericUpDownpoint.Location = new System.Drawing.Point(192, 287);
            this.numericUpDownpoint.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDownpoint.Name = "numericUpDownpoint";
            this.numericUpDownpoint.Size = new System.Drawing.Size(279, 26);
            this.numericUpDownpoint.TabIndex = 46;
            this.numericUpDownpoint.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // textBoxName
            // 
            this.textBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBoxName.Location = new System.Drawing.Point(192, 151);
            this.textBoxName.MaxLength = 40;
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(279, 30);
            this.textBoxName.TabIndex = 44;
            // 
            // textBoxID
            // 
            this.textBoxID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBoxID.Location = new System.Drawing.Point(192, 100);
            this.textBoxID.MaxLength = 8;
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(279, 30);
            this.textBoxID.TabIndex = 43;
            this.textBoxID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxID_KeyPress);
            // 
            // buttonEx
            // 
            this.buttonEx.Location = new System.Drawing.Point(330, 540);
            this.buttonEx.Name = "buttonEx";
            this.buttonEx.Size = new System.Drawing.Size(141, 72);
            this.buttonEx.TabIndex = 42;
            this.buttonEx.Text = "Cancel";
            this.buttonEx.UseVisualStyleBackColor = true;
            this.buttonEx.Click += new System.EventHandler(this.buttonEx_Click);
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(37, 540);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(141, 72);
            this.buttonOK.TabIndex = 41;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label7.Location = new System.Drawing.Point(21, 336);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(165, 34);
            this.label7.TabIndex = 40;
            this.label7.Text = "Date of Birth  :";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label6.Location = new System.Drawing.Point(21, 195);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(165, 34);
            this.label6.TabIndex = 39;
            this.label6.Text = "SDT :";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(21, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 34);
            this.label3.TabIndex = 36;
            this.label3.Text = "Name :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(32, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 34);
            this.label2.TabIndex = 35;
            this.label2.Text = "ID :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.Location = new System.Drawing.Point(50, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(421, 62);
            this.label1.TabIndex = 34;
            this.label1.Text = "Thông tin";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(21, 287);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(165, 34);
            this.label5.TabIndex = 37;
            this.label5.Text = "Point :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxSDT
            // 
            this.textBoxSDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBoxSDT.Location = new System.Drawing.Point(192, 197);
            this.textBoxSDT.MaxLength = 12;
            this.textBoxSDT.Name = "textBoxSDT";
            this.textBoxSDT.Size = new System.Drawing.Size(279, 30);
            this.textBoxSDT.TabIndex = 51;
            this.textBoxSDT.TextChanged += new System.EventHandler(this.textBoxSDT_TextChanged);
            this.textBoxSDT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxSDT_KeyPress);
            // 
            // textBoxpass
            // 
            this.textBoxpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBoxpass.Location = new System.Drawing.Point(192, 487);
            this.textBoxpass.MaxLength = 40;
            this.textBoxpass.Name = "textBoxpass";
            this.textBoxpass.Size = new System.Drawing.Size(279, 30);
            this.textBoxpass.TabIndex = 55;
            // 
            // textBoxuname
            // 
            this.textBoxuname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBoxuname.Location = new System.Drawing.Point(192, 436);
            this.textBoxuname.MaxLength = 8;
            this.textBoxuname.Name = "textBoxuname";
            this.textBoxuname.Size = new System.Drawing.Size(279, 30);
            this.textBoxuname.TabIndex = 54;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(21, 483);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(165, 34);
            this.label4.TabIndex = 53;
            this.label4.Text = "Password :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label9.Location = new System.Drawing.Point(21, 432);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(165, 34);
            this.label9.TabIndex = 52;
            this.label9.Text = "Username :";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label10.Location = new System.Drawing.Point(50, 370);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(421, 62);
            this.label10.TabIndex = 56;
            this.label10.Text = "Tạo tài khoản";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormThemKhach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 626);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBoxpass);
            this.Controls.Add(this.textBoxuname);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBoxSDT);
            this.Controls.Add(this.comboBoxRank);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dateTimePickerdate);
            this.Controls.Add(this.numericUpDownpoint);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.buttonEx);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormThemKhach";
            this.Text = "Thêm Khách";
            this.Load += new System.EventHandler(this.FormThemKhach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownpoint)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxRank;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dateTimePickerdate;
        private System.Windows.Forms.NumericUpDown numericUpDownpoint;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Button buttonEx;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxSDT;
        private System.Windows.Forms.TextBox textBoxpass;
        private System.Windows.Forms.TextBox textBoxuname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}