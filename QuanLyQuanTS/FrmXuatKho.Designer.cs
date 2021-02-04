namespace QuanLyQuanTS
{
    partial class FrmXuatKho
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
            this.button_Refresh = new System.Windows.Forms.Button();
            this.dgvXuatKho = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvXuatKho)).BeginInit();
            this.SuspendLayout();
            // 
            // button_Refresh
            // 
            this.button_Refresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Refresh.Location = new System.Drawing.Point(580, 67);
            this.button_Refresh.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_Refresh.Name = "button_Refresh";
            this.button_Refresh.Size = new System.Drawing.Size(130, 68);
            this.button_Refresh.TabIndex = 16;
            this.button_Refresh.Text = "Refresh";
            this.button_Refresh.UseVisualStyleBackColor = true;
            this.button_Refresh.Click += new System.EventHandler(this.button_Refresh_Click);
            // 
            // dgvXuatKho
            // 
            this.dgvXuatKho.AllowUserToAddRows = false;
            this.dgvXuatKho.AllowUserToDeleteRows = false;
            this.dgvXuatKho.AllowUserToResizeColumns = false;
            this.dgvXuatKho.AllowUserToResizeRows = false;
            this.dgvXuatKho.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvXuatKho.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvXuatKho.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvXuatKho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvXuatKho.Location = new System.Drawing.Point(13, 67);
            this.dgvXuatKho.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvXuatKho.Name = "dgvXuatKho";
            this.dgvXuatKho.RowHeadersWidth = 62;
            this.dgvXuatKho.Size = new System.Drawing.Size(559, 342);
            this.dgvXuatKho.TabIndex = 13;
            this.dgvXuatKho.Click += new System.EventHandler(this.dgvXuatKho_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(160, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(286, 33);
            this.label1.TabIndex = 24;
            this.label1.Text = "Kiểm kho";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmXuatKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 423);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_Refresh);
            this.Controls.Add(this.dgvXuatKho);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmXuatKho";
            this.Text = "FrmXuatKho";
            ((System.ComponentModel.ISupportInitialize)(this.dgvXuatKho)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button_Refresh;
        private System.Windows.Forms.DataGridView dgvXuatKho;
        private System.Windows.Forms.Label label1;
    }
}