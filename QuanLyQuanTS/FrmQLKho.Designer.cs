namespace QuanLyQuanTS
{
    partial class FrmQLKho
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
            this.textBoxsearch = new System.Windows.Forms.TextBox();
            this.buttonEx = new System.Windows.Forms.Button();
            this.dataGridViewKho = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonReload = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKho)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxsearch
            // 
            this.textBoxsearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxsearch.Location = new System.Drawing.Point(158, 56);
            this.textBoxsearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxsearch.Name = "textBoxsearch";
            this.textBoxsearch.Size = new System.Drawing.Size(463, 26);
            this.textBoxsearch.TabIndex = 12;
            this.textBoxsearch.TextChanged += new System.EventHandler(this.textBoxsearch_TextChanged);
            this.textBoxsearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxsearch_KeyUp);
            // 
            // buttonEx
            // 
            this.buttonEx.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonEx.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonEx.ForeColor = System.Drawing.Color.Red;
            this.buttonEx.Location = new System.Drawing.Point(634, 0);
            this.buttonEx.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonEx.Name = "buttonEx";
            this.buttonEx.Size = new System.Drawing.Size(45, 46);
            this.buttonEx.TabIndex = 10;
            this.buttonEx.Text = "x";
            this.buttonEx.UseVisualStyleBackColor = false;
            this.buttonEx.Click += new System.EventHandler(this.buttonEx_Click);
            // 
            // dataGridViewKho
            // 
            this.dataGridViewKho.AllowUserToAddRows = false;
            this.dataGridViewKho.AllowUserToDeleteRows = false;
            this.dataGridViewKho.AllowUserToResizeColumns = false;
            this.dataGridViewKho.AllowUserToResizeRows = false;
            this.dataGridViewKho.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewKho.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewKho.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewKho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewKho.Location = new System.Drawing.Point(14, 98);
            this.dataGridViewKho.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridViewKho.Name = "dataGridViewKho";
            this.dataGridViewKho.ReadOnly = true;
            this.dataGridViewKho.RowHeadersWidth = 62;
            this.dataGridViewKho.Size = new System.Drawing.Size(658, 358);
            this.dataGridViewKho.TabIndex = 8;
            this.dataGridViewKho.Click += new System.EventHandler(this.dataGridViewKho_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(48, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(522, 33);
            this.label1.TabIndex = 13;
            this.label1.Text = "Quản lý kho";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAdd.Location = new System.Drawing.Point(541, 466);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(130, 68);
            this.buttonAdd.TabIndex = 22;
            this.buttonAdd.Text = "Thêm";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click_1);
            // 
            // buttonReload
            // 
            this.buttonReload.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonReload.Location = new System.Drawing.Point(14, 472);
            this.buttonReload.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonReload.Name = "buttonReload";
            this.buttonReload.Size = new System.Drawing.Size(130, 68);
            this.buttonReload.TabIndex = 21;
            this.buttonReload.Text = "Tải lại";
            this.buttonReload.UseVisualStyleBackColor = true;
            this.buttonReload.Click += new System.EventHandler(this.buttonReload_Click_1);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.Location = new System.Drawing.Point(10, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 32);
            this.label2.TabIndex = 25;
            this.label2.Text = "Tìm kiếm : ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmQLKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 561);
            this.Controls.Add(this.textBoxsearch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonReload);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonEx);
            this.Controls.Add(this.dataGridViewKho);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmQLKho";
            this.Text = "FrmQLKho";
            this.Load += new System.EventHandler(this.FrmQLKho_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKho)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxsearch;
        private System.Windows.Forms.Button buttonEx;
        private System.Windows.Forms.DataGridView dataGridViewKho;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonReload;
        private System.Windows.Forms.Label label2;
    }
}