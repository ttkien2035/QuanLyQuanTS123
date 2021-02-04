namespace QuanLyQuanTS
{
    partial class FormEdiRemoveKhack
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
            this.textBoxSDT = new System.Windows.Forms.TextBox();
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
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownpoint)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxSDT
            // 
            this.textBoxSDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBoxSDT.Location = new System.Drawing.Point(192, 181);
            this.textBoxSDT.MaxLength = 8;
            this.textBoxSDT.Name = "textBoxSDT";
            this.textBoxSDT.Size = new System.Drawing.Size(279, 30);
            this.textBoxSDT.TabIndex = 71;
            // 
            // comboBoxRank
            // 
            this.comboBoxRank.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRank.FormattingEnabled = true;
            this.comboBoxRank.Items.AddRange(new object[] {
            "bronze",
            "silver",
            "gold"});
            this.comboBoxRank.Location = new System.Drawing.Point(192, 228);
            this.comboBoxRank.Name = "comboBoxRank";
            this.comboBoxRank.Size = new System.Drawing.Size(279, 28);
            this.comboBoxRank.TabIndex = 70;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label8.Location = new System.Drawing.Point(21, 222);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(165, 34);
            this.label8.TabIndex = 69;
            this.label8.Text = "Rank :";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dateTimePickerdate
            // 
            this.dateTimePickerdate.Location = new System.Drawing.Point(192, 324);
            this.dateTimePickerdate.Name = "dateTimePickerdate";
            this.dateTimePickerdate.Size = new System.Drawing.Size(279, 26);
            this.dateTimePickerdate.TabIndex = 68;
            // 
            // numericUpDownpoint
            // 
            this.numericUpDownpoint.Location = new System.Drawing.Point(192, 271);
            this.numericUpDownpoint.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDownpoint.Name = "numericUpDownpoint";
            this.numericUpDownpoint.Size = new System.Drawing.Size(279, 26);
            this.numericUpDownpoint.TabIndex = 67;
            this.numericUpDownpoint.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // textBoxName
            // 
            this.textBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBoxName.Location = new System.Drawing.Point(192, 135);
            this.textBoxName.MaxLength = 40;
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(279, 30);
            this.textBoxName.TabIndex = 66;
            // 
            // textBoxID
            // 
            this.textBoxID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBoxID.Location = new System.Drawing.Point(192, 84);
            this.textBoxID.MaxLength = 8;
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.ReadOnly = true;
            this.textBoxID.Size = new System.Drawing.Size(279, 30);
            this.textBoxID.TabIndex = 65;
            // 
            // buttonEx
            // 
            this.buttonEx.Location = new System.Drawing.Point(377, 370);
            this.buttonEx.Name = "buttonEx";
            this.buttonEx.Size = new System.Drawing.Size(141, 72);
            this.buttonEx.TabIndex = 64;
            this.buttonEx.Text = "Cancel";
            this.buttonEx.UseVisualStyleBackColor = true;
            this.buttonEx.Click += new System.EventHandler(this.buttonEx_Click);
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(37, 370);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(141, 72);
            this.buttonOK.TabIndex = 63;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label7.Location = new System.Drawing.Point(21, 320);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(165, 34);
            this.label7.TabIndex = 62;
            this.label7.Text = "Date of Birth  :";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label6.Location = new System.Drawing.Point(21, 179);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(165, 34);
            this.label6.TabIndex = 61;
            this.label6.Text = "SDT :";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(21, 271);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(165, 34);
            this.label5.TabIndex = 60;
            this.label5.Text = "Point :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(21, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 34);
            this.label3.TabIndex = 59;
            this.label3.Text = "Name :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(32, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 34);
            this.label2.TabIndex = 58;
            this.label2.Text = "ID :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.Location = new System.Drawing.Point(31, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(421, 62);
            this.label1.TabIndex = 57;
            this.label1.Text = "Thông tin";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(202, 370);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 72);
            this.button1.TabIndex = 72;
            this.button1.Text = "Xóa";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormEdiRemoveKhack
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 475);
            this.Controls.Add(this.button1);
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
            this.Name = "FormEdiRemoveKhack";
            this.Text = "Chỉnh sửa";
            this.Load += new System.EventHandler(this.FormEdiRemoveKhack_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownpoint)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxSDT;
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
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}