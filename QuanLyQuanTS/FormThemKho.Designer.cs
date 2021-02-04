namespace QuanLyQuanTS
{
    partial class FormThemKho
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
            this.comboBoxPro = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dateTimePickerdate = new System.Windows.Forms.DateTimePicker();
            this.textBoxCost = new System.Windows.Forms.TextBox();
            this.numericUpDowncount = new System.Windows.Forms.NumericUpDown();
            this.comboBoxtype = new System.Windows.Forms.ComboBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.buttonEx = new System.Windows.Forms.Button();
            this.buttonOK = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDowncount)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxPro
            // 
            this.comboBoxPro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPro.FormattingEnabled = true;
            this.comboBoxPro.Items.AddRange(new object[] {
            "Food",
            "Drink"});
            this.comboBoxPro.Location = new System.Drawing.Point(140, 288);
            this.comboBoxPro.Name = "comboBoxPro";
            this.comboBoxPro.Size = new System.Drawing.Size(279, 28);
            this.comboBoxPro.TabIndex = 33;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label8.Location = new System.Drawing.Point(-31, 282);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(165, 34);
            this.label8.TabIndex = 32;
            this.label8.Text = "Provider :";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dateTimePickerdate
            // 
            this.dateTimePickerdate.Location = new System.Drawing.Point(140, 439);
            this.dateTimePickerdate.Name = "dateTimePickerdate";
            this.dateTimePickerdate.Size = new System.Drawing.Size(279, 26);
            this.dateTimePickerdate.TabIndex = 31;
            // 
            // textBoxCost
            // 
            this.textBoxCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBoxCost.Location = new System.Drawing.Point(140, 386);
            this.textBoxCost.MaxLength = 8;
            this.textBoxCost.Name = "textBoxCost";
            this.textBoxCost.Size = new System.Drawing.Size(279, 30);
            this.textBoxCost.TabIndex = 30;
            this.textBoxCost.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCost_KeyPress);
            // 
            // numericUpDowncount
            // 
            this.numericUpDowncount.Location = new System.Drawing.Point(140, 331);
            this.numericUpDowncount.Name = "numericUpDowncount";
            this.numericUpDowncount.Size = new System.Drawing.Size(279, 26);
            this.numericUpDowncount.TabIndex = 29;
            this.numericUpDowncount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // comboBoxtype
            // 
            this.comboBoxtype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxtype.FormattingEnabled = true;
            this.comboBoxtype.Items.AddRange(new object[] {
            "Food",
            "Drink"});
            this.comboBoxtype.Location = new System.Drawing.Point(140, 245);
            this.comboBoxtype.Name = "comboBoxtype";
            this.comboBoxtype.Size = new System.Drawing.Size(279, 28);
            this.comboBoxtype.TabIndex = 28;
            // 
            // textBoxName
            // 
            this.textBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBoxName.Location = new System.Drawing.Point(140, 195);
            this.textBoxName.MaxLength = 40;
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(279, 30);
            this.textBoxName.TabIndex = 27;
            // 
            // textBoxID
            // 
            this.textBoxID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBoxID.Location = new System.Drawing.Point(140, 142);
            this.textBoxID.MaxLength = 8;
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(279, 30);
            this.textBoxID.TabIndex = 26;
            this.textBoxID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxID_KeyPress);
            // 
            // buttonEx
            // 
            this.buttonEx.Location = new System.Drawing.Point(278, 511);
            this.buttonEx.Name = "buttonEx";
            this.buttonEx.Size = new System.Drawing.Size(141, 72);
            this.buttonEx.TabIndex = 25;
            this.buttonEx.Text = "Cancel";
            this.buttonEx.UseVisualStyleBackColor = true;
            this.buttonEx.Click += new System.EventHandler(this.buttonEx_Click);
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(15, 511);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(141, 72);
            this.buttonOK.TabIndex = 24;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label7.Location = new System.Drawing.Point(-31, 435);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(165, 34);
            this.label7.TabIndex = 23;
            this.label7.Text = "Date :";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label6.Location = new System.Drawing.Point(-31, 239);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(165, 34);
            this.label6.TabIndex = 22;
            this.label6.Text = "Type :";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(-31, 384);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(165, 34);
            this.label4.TabIndex = 21;
            this.label4.Text = "Cost :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(-31, 331);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(165, 34);
            this.label5.TabIndex = 20;
            this.label5.Text = "Count :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(-31, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 34);
            this.label3.TabIndex = 19;
            this.label3.Text = "Name :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(-31, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 34);
            this.label2.TabIndex = 18;
            this.label2.Text = "ID :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.Location = new System.Drawing.Point(59, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(373, 62);
            this.label1.TabIndex = 17;
            this.label1.Text = "Thêm vào kho";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // FormThemKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 617);
            this.Controls.Add(this.comboBoxPro);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dateTimePickerdate);
            this.Controls.Add(this.textBoxCost);
            this.Controls.Add(this.numericUpDowncount);
            this.Controls.Add(this.comboBoxtype);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.buttonEx);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormThemKho";
            this.Text = "Thêm";
            this.Load += new System.EventHandler(this.FormThemKho_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDowncount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxPro;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dateTimePickerdate;
        private System.Windows.Forms.TextBox textBoxCost;
        private System.Windows.Forms.NumericUpDown numericUpDowncount;
        private System.Windows.Forms.ComboBox comboBoxtype;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Button buttonEx;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}