using QuanLyQuanTS.BS_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanTS
{
    public partial class FrmThemTaiKhoan : Form
    {
        public FrmThemTaiKhoan()
        {
            InitializeComponent();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string user = txtUser.Text.ToString();
            string pass = txtPass.Text.ToString();
            if(Khach.CheckUserName(user))
            {
                MessageBox.Show("Tên tài khoản đã có trong database", "Alert");
            }
            else
            {
                string type = cbxType.GetItemText(cbxType.SelectedItem).ToString();
                try
                {
                    BLAccount.Instance.AddAcount(user, pass, type);
                    MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    MessageBox.Show("Lỗi truy cập Database", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.txtPass.Text = "";
            this.txtUser.Text = "";
        }

        private void FrmThemTaiKhoan_Load(object sender, EventArgs e)
        {
            cbxType.SelectedIndex = 0;
        }
    }
}
