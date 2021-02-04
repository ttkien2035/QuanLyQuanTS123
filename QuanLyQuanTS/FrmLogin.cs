using System;
using System.Windows.Forms;

namespace QuanLyQuanTS
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string userName = txtUserName.Text;
            string passWord = txtPass.Text;
            if (Login(userName, passWord))
            {
                Form1 f = new Form1();
                this.Hide();
                f.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Sai ten tai khoan hoac pass");
            }
        }

        bool Login(string userName, string passWord)
        {
            return false;
        }
    }
}
