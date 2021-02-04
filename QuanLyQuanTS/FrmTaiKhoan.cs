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
    public partial class FrmTaiKhoan : Form
    {
        private Account loginAccount;

        public Account LoginAccount
        {
            get { return loginAccount; }
            set { loginAccount = value; } //ChangeAccount(loginAccount); }

        }

        public FrmTaiKhoan(Account acc)
        {
            InitializeComponent();
            ChangeAccount(acc);
            this.loginAccount = acc;
        }

        void ChangeAccount(Account acc)
        {
            txtTenTK.Text = acc.UserName;
            if (acc.Type.ToString() == "admin")
            {
                txtQuyenTK.Text = "Admin";
            }
            else if (acc.Type.ToString() == "staff")
            {
                txtQuyenTK.Text = "Nhân Viên";
            }
            else if (acc.Type.ToString() == "customer")
            {
                txtQuyenTK.Text = "Khách Hàng";
            }
        }

        
        void UpdateAccount()
        {
            string TenTaiKhoan = txtTenTK.Text;
            string MatKhauCu = txtMKCu.Text;
            string MatKhauMoi = txtMKMoi.Text;
            string NhapLaiMKMoi = txtNhapLai.Text;
            string QuyenTK = txtQuyenTK.Text;
            if (!MatKhauMoi.Equals(NhapLaiMKMoi))
            {
                MessageBox.Show("Vui lòng nhập mật khẩu trùng với mật khẩu mới");
            }
            else
            {
                if (BLAccount.Instance.UpdateAccount(TenTaiKhoan, MatKhauCu, MatKhauMoi))
                {
                    MessageBox.Show("Cập Nhật Thành Công");
                }
                else
                {
                    MessageBox.Show("Vui Lòng Nhập Lại");
                }
            }
        }

        private void txtLuu_Click(object sender, EventArgs e)
        {
            UpdateAccount();
        }

        private void txtHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmTaiKhoan_Load(object sender, EventArgs e)
        {

        }
    }
}
