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
    public partial class FrmDangNhap : Form
    {
        
        public FrmDangNhap()
        {
            InitializeComponent();
        }

    

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string userName = txtUsername.Text.Trim();
            string passWord = txtPass.Text.Trim();
            DBMain.User = userName;
            DBMain.Pass = passWord;
            if (KiemTraDangNhap(userName, passWord))
            {
                    Account loginAccount = BLAccount.Instance.GetAccountByUserName(userName);
                    Form1 a = new Form1(loginAccount);
                    this.Hide();
                    a.ShowDialog();
                    this.Show();
            }
            else
            {
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu");
            }

        }

        bool KiemTraDangNhap(string userName, string passWord)
        {
            return BLAccount.Instance.Login(userName, passWord);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FrmDangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn Thật Sự Muốn Thoát Chương Trình?", "Thông Báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }

        }
    }
}
